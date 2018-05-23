namespace Laboratory2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_parentGridView = new System.Windows.Forms.DataGridView();
            this.m_childGridView = new System.Windows.Forms.DataGridView();
            this.updateChild = new System.Windows.Forms.Button();
            this.addNewChild = new System.Windows.Forms.Button();
            this.displayChildRecords = new System.Windows.Forms.Button();
            this.deleteChild = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.displayParentRecords = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.m_parentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_childGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // m_parentGridView
            // 
            this.m_parentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_parentGridView.Location = new System.Drawing.Point(12, 35);
            this.m_parentGridView.Name = "m_parentGridView";
            this.m_parentGridView.Size = new System.Drawing.Size(589, 226);
            this.m_parentGridView.TabIndex = 0;
            this.m_parentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // m_childGridView
            // 
            this.m_childGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_childGridView.Location = new System.Drawing.Point(12, 297);
            this.m_childGridView.Name = "m_childGridView";
            this.m_childGridView.Size = new System.Drawing.Size(589, 220);
            this.m_childGridView.TabIndex = 1;
            this.m_childGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // updateChild
            // 
            this.updateChild.Location = new System.Drawing.Point(750, 485);
            this.updateChild.Name = "updateChild";
            this.updateChild.Size = new System.Drawing.Size(216, 32);
            this.updateChild.TabIndex = 3;
            this.updateChild.Text = "Update Child Record";
            this.updateChild.UseVisualStyleBackColor = true;
            this.updateChild.Click += new System.EventHandler(this.updateChild_Click);
            // 
            // addNewChild
            // 
            this.addNewChild.Location = new System.Drawing.Point(750, 88);
            this.addNewChild.Name = "addNewChild";
            this.addNewChild.Size = new System.Drawing.Size(216, 32);
            this.addNewChild.TabIndex = 4;
            this.addNewChild.Text = "Add New Child Record";
            this.addNewChild.UseVisualStyleBackColor = true;
            this.addNewChild.Click += new System.EventHandler(this.addNewChild_Click);
            // 
            // displayChildRecords
            // 
            this.displayChildRecords.Location = new System.Drawing.Point(750, 50);
            this.displayChildRecords.Name = "displayChildRecords";
            this.displayChildRecords.Size = new System.Drawing.Size(216, 32);
            this.displayChildRecords.TabIndex = 5;
            this.displayChildRecords.Text = "Display Child Records";
            this.displayChildRecords.UseVisualStyleBackColor = true;
            this.displayChildRecords.Click += new System.EventHandler(this.displayChildRecords_Click);
            // 
            // deleteChild
            // 
            this.deleteChild.Location = new System.Drawing.Point(750, 447);
            this.deleteChild.Name = "deleteChild";
            this.deleteChild.Size = new System.Drawing.Size(216, 32);
            this.deleteChild.TabIndex = 6;
            this.deleteChild.Text = "Remove Child Record";
            this.deleteChild.UseVisualStyleBackColor = true;
            this.deleteChild.Click += new System.EventHandler(this.deleteChild_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Child";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Parent";
            // 
            // displayParentRecords
            // 
            this.displayParentRecords.Location = new System.Drawing.Point(750, 12);
            this.displayParentRecords.Name = "displayParentRecords";
            this.displayParentRecords.Size = new System.Drawing.Size(216, 32);
            this.displayParentRecords.TabIndex = 17;
            this.displayParentRecords.Text = "Display Parent Records";
            this.displayParentRecords.UseVisualStyleBackColor = true;
            this.displayParentRecords.Click += new System.EventHandler(this.displayParentRecords_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(750, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 274);
            this.panel1.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 529);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.displayParentRecords);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deleteChild);
            this.Controls.Add(this.displayChildRecords);
            this.Controls.Add(this.addNewChild);
            this.Controls.Add(this.updateChild);
            this.Controls.Add(this.m_childGridView);
            this.Controls.Add(this.m_parentGridView);
            this.Name = "MainForm";
            this.Text = "Mountain Equipment Store";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_parentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_childGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView m_parentGridView;
        private System.Windows.Forms.DataGridView m_childGridView;
        private System.Windows.Forms.Button updateChild;
        private System.Windows.Forms.Button addNewChild;
        private System.Windows.Forms.Button displayChildRecords;
        private System.Windows.Forms.Button deleteChild;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button displayParentRecords;
        private System.Windows.Forms.Panel panel1;
    }
}

