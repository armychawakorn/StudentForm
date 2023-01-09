namespace StudentForm
{
    partial class StudentForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Submit_btn = new System.Windows.Forms.Button();
            this.Form_Name = new System.Windows.Forms.Label();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.TextBox_ID = new System.Windows.Forms.TextBox();
            this.Form_ID = new System.Windows.Forms.Label();
            this.TextBox_Year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_Tall = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_Grade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_Major = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TableGG = new System.Windows.Forms.DataGridView();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.ShowDataInGrid_btn = new System.Windows.Forms.Button();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.StudentCount = new System.Windows.Forms.TextBox();
            this.MaxGrade = new System.Windows.Forms.TextBox();
            this.MinGrade = new System.Windows.Forms.TextBox();
            this.SaveXML = new System.Windows.Forms.Button();
            this.ClearXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableGG)).BeginInit();
            this.SuspendLayout();
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(27, 304);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(94, 29);
            this.Submit_btn.TabIndex = 1;
            this.Submit_btn.Text = "ซับมิด";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // Form_Name
            // 
            this.Form_Name.AutoSize = true;
            this.Form_Name.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Form_Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Form_Name.Location = new System.Drawing.Point(71, 86);
            this.Form_Name.Name = "Form_Name";
            this.Form_Name.Size = new System.Drawing.Size(26, 20);
            this.Form_Name.TabIndex = 2;
            this.Form_Name.Text = "ชื่อ";
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(103, 83);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(206, 27);
            this.TextBox_Name.TabIndex = 3;
            // 
            // TextBox_ID
            // 
            this.TextBox_ID.Location = new System.Drawing.Point(103, 116);
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.Size = new System.Drawing.Size(206, 27);
            this.TextBox_ID.TabIndex = 5;
            // 
            // Form_ID
            // 
            this.Form_ID.AutoSize = true;
            this.Form_ID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Form_ID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Form_ID.Location = new System.Drawing.Point(13, 119);
            this.Form_ID.Name = "Form_ID";
            this.Form_ID.Size = new System.Drawing.Size(84, 20);
            this.Form_ID.TabIndex = 4;
            this.Form_ID.Text = "รหัสนักศึกษา";
            this.Form_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox_Year
            // 
            this.TextBox_Year.Location = new System.Drawing.Point(103, 149);
            this.TextBox_Year.Name = "TextBox_Year";
            this.TextBox_Year.Size = new System.Drawing.Size(206, 27);
            this.TextBox_Year.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(57, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "ปีเกิด";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox_Tall
            // 
            this.TextBox_Tall.Location = new System.Drawing.Point(103, 182);
            this.TextBox_Tall.Name = "TextBox_Tall";
            this.TextBox_Tall.Size = new System.Drawing.Size(206, 27);
            this.TextBox_Tall.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(49, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "ส่วนสูว";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox_Grade
            // 
            this.TextBox_Grade.Location = new System.Drawing.Point(103, 215);
            this.TextBox_Grade.Name = "TextBox_Grade";
            this.TextBox_Grade.Size = new System.Drawing.Size(206, 27);
            this.TextBox_Grade.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(60, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "เกรด";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox_Major
            // 
            this.TextBox_Major.Location = new System.Drawing.Point(103, 248);
            this.TextBox_Major.Name = "TextBox_Major";
            this.TextBox_Major.Size = new System.Drawing.Size(206, 27);
            this.TextBox_Major.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(57, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "สาขา";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableGG
            // 
            this.TableGG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableGG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.StudentID,
            this.Year,
            this.Tall,
            this.Grade,
            this.Major});
            this.TableGG.Location = new System.Drawing.Point(355, 58);
            this.TableGG.Name = "TableGG";
            this.TableGG.RowHeadersWidth = 51;
            this.TableGG.RowTemplate.Height = 29;
            this.TableGG.Size = new System.Drawing.Size(803, 362);
            this.TableGG.TabIndex = 14;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "ชื่อ";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 125;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "รหัสนักศึกษา";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Width = 125;
            // 
            // Year
            // 
            this.Year.HeaderText = "ปีเกิด";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 125;
            // 
            // Tall
            // 
            this.Tall.HeaderText = "ส่วนสูง";
            this.Tall.MinimumWidth = 6;
            this.Tall.Name = "Tall";
            this.Tall.ReadOnly = true;
            this.Tall.Width = 125;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "เกรด";
            this.Grade.MinimumWidth = 6;
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            this.Grade.Width = 125;
            // 
            // Major
            // 
            this.Major.HeaderText = "สาขา";
            this.Major.MinimumWidth = 6;
            this.Major.Name = "Major";
            this.Major.ReadOnly = true;
            this.Major.Width = 125;
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(127, 304);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(94, 29);
            this.Clear_btn.TabIndex = 15;
            this.Clear_btn.Text = "เคลียฟอร์ม";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // ShowDataInGrid_btn
            // 
            this.ShowDataInGrid_btn.Location = new System.Drawing.Point(227, 304);
            this.ShowDataInGrid_btn.Name = "ShowDataInGrid_btn";
            this.ShowDataInGrid_btn.Size = new System.Drawing.Size(94, 29);
            this.ShowDataInGrid_btn.TabIndex = 16;
            this.ShowDataInGrid_btn.Text = "เคลียกริด";
            this.ShowDataInGrid_btn.UseVisualStyleBackColor = true;
            this.ShowDataInGrid_btn.Click += new System.EventHandler(this.ShowDataInGrid_btn_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelTitle.Location = new System.Drawing.Point(112, 25);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(147, 38);
            this.LabelTitle.TabIndex = 17;
            this.LabelTitle.Text = "โปรแกรมหมี";
            // 
            // StudentCount
            // 
            this.StudentCount.Location = new System.Drawing.Point(941, 25);
            this.StudentCount.Name = "StudentCount";
            this.StudentCount.ReadOnly = true;
            this.StudentCount.Size = new System.Drawing.Size(216, 27);
            this.StudentCount.TabIndex = 18;
            this.StudentCount.Text = "จำนวนนักศึกษา 0 คน";
            this.StudentCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MaxGrade
            // 
            this.MaxGrade.Location = new System.Drawing.Point(648, 25);
            this.MaxGrade.Name = "MaxGrade";
            this.MaxGrade.ReadOnly = true;
            this.MaxGrade.Size = new System.Drawing.Size(287, 27);
            this.MaxGrade.TabIndex = 19;
            this.MaxGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MinGrade
            // 
            this.MinGrade.Location = new System.Drawing.Point(355, 25);
            this.MinGrade.Name = "MinGrade";
            this.MinGrade.ReadOnly = true;
            this.MinGrade.Size = new System.Drawing.Size(287, 27);
            this.MinGrade.TabIndex = 20;
            this.MinGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SaveXML
            // 
            this.SaveXML.Location = new System.Drawing.Point(27, 339);
            this.SaveXML.Name = "SaveXML";
            this.SaveXML.Size = new System.Drawing.Size(94, 29);
            this.SaveXML.TabIndex = 21;
            this.SaveXML.Text = "เซฟลงเครื่อง";
            this.SaveXML.UseVisualStyleBackColor = true;
            this.SaveXML.Click += new System.EventHandler(this.SaveXML_Click);
            // 
            // ClearXML
            // 
            this.ClearXML.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearXML.Location = new System.Drawing.Point(127, 339);
            this.ClearXML.Name = "ClearXML";
            this.ClearXML.Size = new System.Drawing.Size(94, 29);
            this.ClearXML.TabIndex = 22;
            this.ClearXML.Text = "เคลียเอ็กเอ็มแอล";
            this.ClearXML.UseVisualStyleBackColor = true;
            this.ClearXML.Click += new System.EventHandler(this.ClearXML_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1198, 450);
            this.Controls.Add(this.ClearXML);
            this.Controls.Add(this.SaveXML);
            this.Controls.Add(this.MinGrade);
            this.Controls.Add(this.MaxGrade);
            this.Controls.Add(this.StudentCount);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.ShowDataInGrid_btn);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.TableGG);
            this.Controls.Add(this.TextBox_Major);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBox_Grade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_Tall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_Year);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_ID);
            this.Controls.Add(this.Form_ID);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.Form_Name);
            this.Controls.Add(this.Submit_btn);
            this.Name = "StudentForm";
            this.Text = "โปรแกรมหมี";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableGG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Submit_btn;
        private Label Form_Name;
        private TextBox TextBox_Name;
        private TextBox TextBox_ID;
        private Label Form_ID;
        private TextBox TextBox_Year;
        private Label label1;
        private TextBox TextBox_Tall;
        private Label label2;
        private TextBox TextBox_Grade;
        private Label label3;
        private TextBox TextBox_Major;
        private Label label4;
        private DataGridView TableGG;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Tall;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewTextBoxColumn Major;
        private Button Clear_btn;
        private Button ShowDataInGrid_btn;
        private Label LabelTitle;
        private TextBox StudentCount;
        private TextBox MaxGrade;
        private TextBox MinGrade;
        private Button SaveXML;
        private Button ClearXML;
    }
}