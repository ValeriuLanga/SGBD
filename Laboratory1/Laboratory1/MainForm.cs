using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory2
{
    public partial class MainForm : Form
    {
        private SqlConnection m_sqlConnection;

        private SqlDataAdapter m_sqlDataAdapterParent;
        private DataSet m_dataSetParent;

        private SqlDataAdapter m_sqlDataAdapterChild;
        private DataSet m_dataSetChild;

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
            string connectionString = connectionSettings.ConnectionString;
            m_sqlConnection = new SqlConnection(connectionString);

            m_bindingSourceParent = new BindingSource();
            m_bindingSourceChild = new BindingSource();
            m_sqlDataAdapterChild = new SqlDataAdapter();
            m_sqlDataAdapterParent = new SqlDataAdapter();
            m_dataSetParent = new DataSet();
            m_dataSetChild = new DataSet();
        }

        private void displayChildRecords_Click(object sender, EventArgs e)
        {
            m_sqlDataAdapterChild.SelectCommand =
                new SqlCommand(ConfigurationManager.AppSettings["ChildSelectCommand"], m_sqlConnection);

            // get the hiking boots id
            Int32 HbId;
            if (!int.TryParse(this.hikingBootsGridView.CurrentRow.Cells[0].Value.ToString(), out HbId))
            {
                throw new Exception("Could not parse Hiking Boots Id from Grid View!");
            }

            m_sqlDataAdapterChild.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = HbId;

            m_sqlConnection.Open();
            m_sqlDataAdapterChild.SelectCommand.ExecuteNonQuery();
            m_sqlConnection.Close();

            m_dataSetChild.Clear();
            m_sqlDataAdapterChild.Fill(m_dataSetChild);
            cramponsGridView.DataSource = m_dataSetChild.Tables[0];
        }

        private void UpdateChildGridView()
        {
            m_sqlConnection.Open();
            m_sqlDataAdapterChild.SelectCommand = new SqlCommand(
                ConfigurationManager.AppSettings["ChildSelectCommand"], m_sqlConnection);

            m_sqlDataAdapterChild.SelectCommand.ExecuteNonQuery();

            m_dataSetChild.Clear();
            m_sqlDataAdapterChild.Fill(m_dataSetChild);

            cramponsGridView.DataSource = m_dataSetChild.Tables[0];
            m_sqlConnection.Close();

        }

        private void addNewChild_Click(object sender, EventArgs e)
        {
            try
            {
                m_sqlDataAdapterChild.InsertCommand = new SqlCommand(
                    ConfigurationManager.AppSettings["ChildInsertCommand"], m_sqlConnection);

                // add the parameters from the text boxes
                Int32 HbId;
                if (!int.TryParse(this.hikingBootsGridView.CurrentRow.Cells[0].Value.ToString(), out HbId))
                {
                    throw new Exception("Could not parse Hiking Boots Id from Grid View!");
                }

                m_sqlDataAdapterChild.InsertCommand.Parameters.Add("@HikingBootsId", SqlDbType.Int).Value = HbId;

                m_sqlDataAdapterChild.InsertCommand.Parameters.Add("@brand", SqlDbType.VarChar).Value = brandTextBox.Text;

                m_sqlDataAdapterChild.InsertCommand.Parameters.Add("@quantity", SqlDbType.Int).Value = 
                    Int32.Parse(quantityTextBox.Text);

                m_sqlDataAdapterChild.InsertCommand.Parameters.Add("@size", SqlDbType.Int).Value =
                    Int32.Parse(sizeTextBox.Text);

                m_sqlDataAdapterChild.InsertCommand.Parameters.Add("@price", SqlDbType.Int).Value = 
                    Int32.Parse(priceTextBox.Text);

                m_sqlConnection.Open();

                

                m_sqlDataAdapterChild.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted Successful to the Database");

                m_sqlConnection.Close();

                // refresh the table so we can see the newly added stuff
                UpdateChildGridView();
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
                int childId;

                if (!int.TryParse(this.cramponsGridView.CurrentRow.Cells[0].Value.ToString(), out childId))
                    throw new Exception("Failed to convert Id from Crampon Id from GridView!");

                m_sqlDataAdapterChild.DeleteCommand = new SqlCommand(
                    ConfigurationManager.AppSettings["ChildDeleteCommand"], m_sqlConnection);
                m_sqlDataAdapterChild.DeleteCommand.Parameters.AddWithValue("@id", childId);

                m_sqlConnection.Open();
                m_sqlDataAdapterChild.DeleteCommand.ExecuteNonQuery();
                m_sqlConnection.Close();

                UpdateChildGridView();
            }
            catch (SqlException ex)
            {
                m_sqlConnection.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void updateChild_Click(object sender, EventArgs e)
        {
            try
            {
                int childId;

                if (!int.TryParse(this.cramponsGridView.CurrentRow.Cells[0].Value.ToString(), out childId))
                    throw new Exception("Failed to convert Id from Crampon Id from GridView!");

                m_sqlDataAdapterChild.UpdateCommand = new SqlCommand(
                    ConfigurationManager.AppSettings["ChildUpdateCommand"], m_sqlConnection);
               
                m_sqlDataAdapterChild.UpdateCommand.Parameters.AddWithValue("@id", childId);

                m_sqlDataAdapterChild.UpdateCommand.Parameters.AddWithValue("@brand", brandTextBox.Text);

                m_sqlDataAdapterChild.UpdateCommand.Parameters.AddWithValue("@quantity", Int32.Parse(quantityTextBox.Text));

                m_sqlDataAdapterChild.UpdateCommand.Parameters.AddWithValue("@size", Int32.Parse(sizeTextBox.Text));

                m_sqlDataAdapterChild.UpdateCommand.Parameters.AddWithValue("@price", Int32.Parse(priceTextBox.Text));

                m_sqlConnection.Open();
                m_sqlDataAdapterChild.UpdateCommand.ExecuteNonQuery();
                m_sqlConnection.Close();

                // update stuff
                UpdateChildGridView();
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

            m_dataSetParent.Clear();
            m_sqlDataAdapterParent.Fill(m_dataSetParent);

            hikingBootsGridView.DataSource = m_dataSetParent.Tables[0];

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
