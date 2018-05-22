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
            this.hikingBootsGridView = new System.Windows.Forms.DataGridView();
            this.cramponsGridView = new System.Windows.Forms.DataGridView();
            this.updateChild = new System.Windows.Forms.Button();
            this.addNewChild = new System.Windows.Forms.Button();
            this.displayChildRecords = new System.Windows.Forms.Button();
            this.deleteChild = new System.Windows.Forms.Button();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.displayParentRecords = new System.Windows.Forms.Button();
            this.hikingBootsIdTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hikingBootsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cramponsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hikingBootsGridView
            // 
            this.hikingBootsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hikingBootsGridView.Location = new System.Drawing.Point(12, 35);
            this.hikingBootsGridView.Name = "hikingBootsGridView";
            this.hikingBootsGridView.Size = new System.Drawing.Size(589, 226);
            this.hikingBootsGridView.TabIndex = 0;
            this.hikingBootsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cramponsGridView
            // 
            this.cramponsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cramponsGridView.Location = new System.Drawing.Point(12, 297);
            this.cramponsGridView.Name = "cramponsGridView";
            this.cramponsGridView.Size = new System.Drawing.Size(589, 220);
            this.cramponsGridView.TabIndex = 1;
            this.cramponsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(750, 127);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(215, 20);
            this.brandTextBox.TabIndex = 7;
            this.brandTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(750, 205);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(215, 20);
            this.priceTextBox.TabIndex = 8;
            this.priceTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(751, 179);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(215, 20);
            this.sizeTextBox.TabIndex = 9;
            this.sizeTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(751, 153);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(215, 20);
            this.quantityTextBox.TabIndex = 10;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(665, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Crampon Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(699, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Quantity";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(718, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(713, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Crampons";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Hiking Boots";
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
            // hikingBootsIdTextBox
            // 
            this.hikingBootsIdTextBox.Location = new System.Drawing.Point(751, 231);
            this.hikingBootsIdTextBox.Name = "hikingBootsIdTextBox";
            this.hikingBootsIdTextBox.Size = new System.Drawing.Size(215, 20);
            this.hikingBootsIdTextBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(666, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Hiking Boots Id";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 529);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hikingBootsIdTextBox);
            this.Controls.Add(this.displayParentRecords);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(this.deleteChild);
            this.Controls.Add(this.displayChildRecords);
            this.Controls.Add(this.addNewChild);
            this.Controls.Add(this.updateChild);
            this.Controls.Add(this.cramponsGridView);
            this.Controls.Add(this.hikingBootsGridView);
            this.Load += new System.EventHandler(this.MainForm_Load);   // should this be added manually?
            this.Name = "MainForm";
            this.Text = "Mountain Equipment Store";
            ((System.ComponentModel.ISupportInitialize)(this.hikingBootsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cramponsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView hikingBootsGridView;
        private System.Windows.Forms.DataGridView cramponsGridView;
        private System.Windows.Forms.Button updateChild;
        private System.Windows.Forms.Button addNewChild;
        private System.Windows.Forms.Button displayChildRecords;
        private System.Windows.Forms.Button deleteChild;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button displayParentRecords;
        private System.Windows.Forms.TextBox hikingBootsIdTextBox;
        private System.Windows.Forms.Label label7;
    }
}

