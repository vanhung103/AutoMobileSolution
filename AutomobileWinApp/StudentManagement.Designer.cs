namespace AutomobileWinApp
{
    partial class StudentManagement
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtStudentName = new TextBox();
            txtStudenID = new TextBox();
            txtGender = new TextBox();
            txtAddress = new TextBox();
            txtDiemTB = new TextBox();
            btnInsert = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dgvStudent = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(62, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 23);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(62, 57);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 1;
            label2.Text = "Student Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(62, 106);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 2;
            label3.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(62, 161);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(62, 216);
            label5.Name = "label5";
            label5.Size = new Size(86, 23);
            label5.TabIndex = 4;
            label5.Text = "Diem TB";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(222, 53);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(328, 27);
            txtStudentName.TabIndex = 5;
            // 
            // txtStudenID
            // 
            txtStudenID.Location = new Point(222, 9);
            txtStudenID.Name = "txtStudenID";
            txtStudenID.ReadOnly = true;
            txtStudenID.Size = new Size(328, 27);
            txtStudenID.TabIndex = 6;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(222, 106);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(328, 27);
            txtGender.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(222, 161);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(328, 27);
            txtAddress.TabIndex = 8;
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(222, 212);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(328, 27);
            txtDiemTB.TabIndex = 9;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.Location = new Point(62, 262);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(103, 39);
            btnInsert.TabIndex = 10;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(498, 262);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 39);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(292, 262);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(91, 39);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvStudent
            // 
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(62, 321);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.RowTemplate.Height = 29;
            dgvStudent.Size = new Size(544, 174);
            dgvStudent.TabIndex = 13;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(292, 510);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(91, 39);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // StudentManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 561);
            Controls.Add(btnClose);
            Controls.Add(dgvStudent);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(txtDiemTB);
            Controls.Add(txtAddress);
            Controls.Add(txtGender);
            Controls.Add(txtStudenID);
            Controls.Add(txtStudentName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentManagement";
            Text = "StudentManagement";
            Load += StudentManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtStudentName;
        private TextBox txtStudenID;
        private TextBox txtGender;
        private TextBox txtAddress;
        private TextBox txtDiemTB;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView dgvStudent;
        private Button btnClose;
    }
}