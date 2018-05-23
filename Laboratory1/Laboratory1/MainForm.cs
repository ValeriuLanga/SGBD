using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory2
{
    public partial class MainForm : Form
    {
        private SqlConnection m_sqlConnection;

        private SqlDataAdapter m_sqlDataAdapterParent;
        private SqlDataAdapter m_sqlDataAdapterChild;
        private DataSet m_dataSet;

        // binding sources
        private BindingSource m_bindingSourceParent;
        private BindingSource m_bindingSourceChild;

        private List<TextBox> m_textBoxList;
        private List<Label> m_labelList;

        private int m_index = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings connectionSettings = ConfigurationManager.ConnectionStrings["connectionString"];
            m_sqlConnection = new SqlConnection(connectionSettings.ConnectionString);

            m_bindingSourceParent = new BindingSource();
            m_sqlDataAdapterParent = new SqlDataAdapter();

            m_bindingSourceChild = new BindingSource();
            m_sqlDataAdapterChild = new SqlDataAdapter();

            m_dataSet = new DataSet();

            // fill data set
            initializeDataAdapters();

            // populate grid views
            initializeDataGridViews();

            // setup grids and labels
            initializeTextBoxesAndLabels();
        }

        private void initializeDataAdapters()
        {
            m_sqlConnection.Open();
            
            // update data set for the parent table
            m_sqlDataAdapterParent.SelectCommand = new SqlCommand(
                ConfigurationManager.AppSettings["ParentSelectCommand"],
                m_sqlConnection);
            m_sqlDataAdapterParent.Fill(m_dataSet, "ParentTable");

            m_sqlDataAdapterChild.SelectCommand = new SqlCommand(
                ConfigurationManager.AppSettings["ChildSelectCommand"],
                m_sqlConnection);
            m_sqlDataAdapterChild.SelectCommand.ExecuteNonQuery(); 
            m_sqlDataAdapterChild.Fill(m_dataSet, "ChildTable");

            m_sqlConnection.Close();
        }

        private void initializeTableRelations()
        {
            string id = ConfigurationManager.AppSettings["ParentId"];

            DataRelation dataRelation = new DataRelation(
                "FK_Parent_Child"
                , m_dataSet.Tables["ParentTable"].Columns[id]
                , m_dataSet.Tables["ChildTable"].Columns[id]
                );
            m_dataSet.Relations.Add(dataRelation);

            m_bindingSourceParent.DataSource = m_dataSet;
            m_bindingSourceParent.DataMember = "ParentTable";

            m_bindingSourceChild.DataSource = m_bindingSourceParent;
            m_bindingSourceChild.DataMember = "FK_Parent_Child";
        }

        private void initializeDataGridViews()
        {
            m_parentGridView.DataSource = m_bindingSourceParent;
            m_childGridView.DataSource = m_bindingSourceChild;

            initializeTableRelations();

            m_childGridView.AutoResizeColumns();
            m_parentGridView.AutoGenerateColumns = true;

            //UpdateChildGridView();
        }

        private void initializeTextBoxesAndLabels()
        {
            m_index = 0;
            m_textBoxList = new List<TextBox>();
            m_labelList = new List<Label>();

            // cleanup any remaining stuff

            foreach (Control item in panel1.Controls.OfType<TextBox>())
            {
                panel1.Controls.Remove(item);
            }
            foreach (Control item in panel1.Controls.OfType<Label>())
            {
                panel1.Controls.Remove(item);
            }


            for (int index = 1; index < m_dataSet.Tables["ChildTable"].Columns.Count - 1; index++)
            {
                Label label = new Label();
                label.Text = m_dataSet.Tables["ChildTable"].Columns[index].ColumnName;

                Point textP = new Point(80, m_index * 40);
                Point lableP = new Point(0, m_index * 40);
                label.Location = lableP;
                label.AutoSize = true;

                TextBox textBox = new TextBox();
                textBox.Location = textP;
                m_textBoxList.Add(textBox);
                m_labelList.Add(label);
                m_index++;

                panel1.Controls.Add(label);
                panel1.Controls.Add(textBox);
            }
        }

        private void displayChildRecords_Click(object sender, EventArgs e)
        {
            m_sqlDataAdapterChild.SelectCommand =
                new SqlCommand(ConfigurationManager.AppSettings["ChildSelectIdCommand"], m_sqlConnection);

            // get the hiking boots id
            int rowIndex = m_parentGridView.SelectedCells[0].RowIndex;
            string parentId = m_parentGridView.Rows[rowIndex].Cells[0].Value.ToString();

            m_sqlDataAdapterChild.SelectCommand.Parameters.Add("@value", SqlDbType.Int).Value = parentId;

            m_sqlConnection.Open();
            m_sqlDataAdapterChild.SelectCommand.ExecuteNonQuery();
            m_sqlConnection.Close();

            m_dataSet.Clear();
            m_sqlDataAdapterChild.Fill(m_dataSet, "ChildTable");
            m_childGridView.DataSource = m_dataSet.Tables[0];
        }

        private void UpdateChildGridView()
        {
            m_sqlConnection.Open();
            m_sqlDataAdapterChild.SelectCommand = new SqlCommand(
                ConfigurationManager.AppSettings["ChildSelectCommand"], m_sqlConnection);

            m_sqlDataAdapterChild.SelectCommand.ExecuteNonQuery();

            m_dataSet.Clear();
            m_sqlDataAdapterChild.Fill(m_dataSet, "ChildTable");

            m_childGridView.DataSource = m_dataSet.Tables[0];
            m_sqlConnection.Close();

        }

        private void addNewChild_Click(object sender, EventArgs e)
        {
            try
            {
                m_sqlDataAdapterChild.InsertCommand = new SqlCommand(
                    ConfigurationManager.AppSettings["ChildInsertCommand"], m_sqlConnection);

                int selectedRowIndex = m_parentGridView.SelectedCells[0].RowIndex;
                string parentId = m_parentGridView.Rows[selectedRowIndex].Cells[0].Value.ToString();

                m_sqlConnection.Open();

                string aux;
                int index;

                for (index = 0; index < m_dataSet.Tables["ChildTable"].Columns.Count - 2; index++)
                {
                    aux = "@value" + (index + 1).ToString();
                    m_sqlDataAdapterChild.InsertCommand.Parameters.Add(aux, SqlDbType.VarChar).Value = 
                        m_textBoxList[index].Text;
                }

                aux = "@value" + (index + 1).ToString();
                m_sqlDataAdapterChild.InsertCommand.Parameters.Add(aux, SqlDbType.VarChar).Value = parentId;

                m_sqlDataAdapterChild.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted Successful to the Database");

                m_sqlConnection.Close();

                // refresh the table so we can see the newly added stuff
                //UpdateChildGridView();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                m_sqlConnection.Close();
            }

        }

        private void deleteChild_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_childGridView.SelectedCells.Count == 0)
                    throw new Exception("Select a child row to delete!");

                int childId = m_childGridView.SelectedCells[0].RowIndex;

                // get the actual DB id
                DataGridViewRow dataGridViewRow = m_childGridView.Rows[childId];
                string databaseId = Convert.ToString(dataGridViewRow.Cells[0].Value);

                m_sqlDataAdapterChild.DeleteCommand = new SqlCommand(
                    ConfigurationManager.AppSettings["ChildDeleteCommand"], m_sqlConnection);
                m_sqlDataAdapterChild.DeleteCommand.Parameters.AddWithValue("@id", childId);

                m_sqlConnection.Open();
                m_sqlDataAdapterChild.DeleteCommand.ExecuteNonQuery();
                m_sqlConnection.Close();

                //UpdateChildGridView();
            }
            catch (SqlException ex)
            {
                m_sqlConnection.Close();
                MessageBox.Show(ex.ToString());
            }
            catch (Exception ex)
            {
                m_sqlConnection.Close();
                MessageBox.Show(ex.ToString());
            }


        }

        private void updateChild_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_childGridView.SelectedCells.Count == 0)
                    throw new Exception("Select a child row to delete!");

                m_sqlDataAdapterChild.UpdateCommand = new SqlCommand(
                    ConfigurationManager.AppSettings["ChildUpdateCommand"], m_sqlConnection);

                string childId = m_childGridView.CurrentRow.Cells[0].Value.ToString();
                string aux;
                int index;

                for (index = 0; index < index - 2; index++)
                {
                    aux = "@value" + (index + 1).ToString();
                    m_sqlDataAdapterChild.UpdateCommand.Parameters.Add(aux, SqlDbType.VarChar).Value =
                        m_textBoxList[index].Text;
                }

                aux = "@value" + (index + 1).ToString();
                m_sqlDataAdapterParent.UpdateCommand.Parameters.Add(aux, SqlDbType.VarChar).Value = childId;

                m_sqlConnection.Open();
                m_sqlDataAdapterChild.UpdateCommand.ExecuteNonQuery();
                m_sqlConnection.Close();

                // update stuff
                //UpdateChildGridView();
            }
            catch (SqlException ex)
            {
                m_sqlConnection.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void displayParentRecords_Click(object sender, EventArgs e)
        {
            m_sqlConnection.Open();

            m_sqlDataAdapterParent.SelectCommand = new SqlCommand(
                ConfigurationManager.AppSettings["ParentSelectCommand"], m_sqlConnection);

            m_dataSet.Clear();
            m_sqlDataAdapterParent.Fill(m_dataSet, "ParentTable");

            m_sqlConnection.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
