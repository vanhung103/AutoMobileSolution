namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtManufacturer = new TextBox();
            txtYear = new TextBox();
            txtPrice = new TextBox();
            btnLoad = new Button();
            btnDelete = new Button();
            btnNew = new Button();
            dgvCarList = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(253, 39);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(255, 27);
            txtCarID.TabIndex = 16;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(253, 103);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(255, 27);
            txtCarName.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(527, 111);
            label5.Name = "label5";
            label5.Size = new Size(140, 23);
            label5.TabIndex = 14;
            label5.Text = "Released Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(527, 43);
            label4.Name = "label4";
            label4.Size = new Size(55, 23);
            label4.TabIndex = 13;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(54, 170);
            label3.Name = "label3";
            label3.Size = new Size(126, 23);
            label3.TabIndex = 12;
            label3.Text = "Manufacturer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 107);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 11;
            label2.Text = "Car Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 43);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 10;
            label1.Text = "Car ID";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(253, 170);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(255, 27);
            txtManufacturer.TabIndex = 17;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(690, 111);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(255, 27);
            txtYear.TabIndex = 18;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(690, 43);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(255, 27);
            txtPrice.TabIndex = 19;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.Highlight;
            btnLoad.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.ForeColor = Color.White;
            btnLoad.Location = new Point(253, 230);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(114, 44);
            btnLoad.TabIndex = 20;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(831, 230);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 44);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = SystemColors.Highlight;
            btnNew.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(553, 230);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(114, 44);
            btnNew.TabIndex = 22;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(54, 294);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.RowHeadersWidth = 51;
            dgvCarList.RowTemplate.Height = 29;
            dgvCarList.Size = new Size(983, 248);
            dgvCarList.TabIndex = 23;
            dgvCarList.CellDoubleClick += dgvCarList_CellDoubleClick;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(553, 554);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(114, 44);
            btnClose.TabIndex = 24;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 610);
            Controls.Add(btnClose);
            Controls.Add(dgvCarList);
            Controls.Add(btnNew);
            Controls.Add(btnDelete);
            Controls.Add(btnLoad);
            Controls.Add(txtPrice);
            Controls.Add(txtYear);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarID);
            Controls.Add(txtCarName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarManagement";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCarID;
        private TextBox txtCarName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtManufacturer;
        private TextBox txtYear;
        private TextBox txtPrice;
        private Button btnLoad;
        private Button btnDelete;
        private Button btnNew;
        private DataGridView dgvCarList;
        private Button btnClose;
    }
}