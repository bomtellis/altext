namespace Altext
{
    partial class MainInterface
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AttributeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PickBlockBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LeadingLetterTxtBox = new System.Windows.Forms.TextBox();
            this.LeadingLetterCheckBox = new System.Windows.Forms.CheckBox();
            this.LeadingZerosCheckBox = new System.Windows.Forms.CheckBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.EndNumberTxtBox = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.StartNumberTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SavePathBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.IncrementTxtBox = new System.Windows.Forms.TextBox();
            this.FilePathTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CsvOutputCheckBox = new System.Windows.Forms.CheckBox();
            this.ModeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PolylineStatusTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PickPolylineBtn = new System.Windows.Forms.Button();
            this.SaveFileDialogCSV = new System.Windows.Forms.SaveFileDialog();
            this.PLineDuplicates = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.AttributeComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PickBlockBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Block Details";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // AttributeComboBox
            // 
            this.AttributeComboBox.Enabled = false;
            this.AttributeComboBox.FormattingEnabled = true;
            this.AttributeComboBox.Location = new System.Drawing.Point(9, 36);
            this.AttributeComboBox.Name = "AttributeComboBox";
            this.AttributeComboBox.Size = new System.Drawing.Size(336, 21);
            this.AttributeComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Attribute to change:";
            // 
            // PickBlockBtn
            // 
            this.PickBlockBtn.Location = new System.Drawing.Point(360, 34);
            this.PickBlockBtn.Name = "PickBlockBtn";
            this.PickBlockBtn.Size = new System.Drawing.Size(75, 23);
            this.PickBlockBtn.TabIndex = 0;
            this.PickBlockBtn.Text = "Pick Blocks";
            this.PickBlockBtn.UseVisualStyleBackColor = true;
            this.PickBlockBtn.Click += new System.EventHandler(this.PickBlockBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.PLineDuplicates);
            this.groupBox2.Controls.Add(this.LeadingLetterTxtBox);
            this.groupBox2.Controls.Add(this.LeadingLetterCheckBox);
            this.groupBox2.Controls.Add(this.LeadingZerosCheckBox);
            this.groupBox2.Controls.Add(this.StartBtn);
            this.groupBox2.Controls.Add(this.EndNumberTxtBox);
            this.groupBox2.Controls.Add(this.CancelBtn);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.StartNumberTxtBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.SavePathBtn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.IncrementTxtBox);
            this.groupBox2.Controls.Add(this.FilePathTxtBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CsvOutputCheckBox);
            this.groupBox2.Controls.Add(this.ModeComboBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 242);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mode of Operation";
            // 
            // LeadingLetterTxtBox
            // 
            this.LeadingLetterTxtBox.Enabled = false;
            this.LeadingLetterTxtBox.Location = new System.Drawing.Point(12, 204);
            this.LeadingLetterTxtBox.Name = "LeadingLetterTxtBox";
            this.LeadingLetterTxtBox.Size = new System.Drawing.Size(200, 20);
            this.LeadingLetterTxtBox.TabIndex = 13;
            // 
            // LeadingLetterCheckBox
            // 
            this.LeadingLetterCheckBox.AutoSize = true;
            this.LeadingLetterCheckBox.Location = new System.Drawing.Point(12, 184);
            this.LeadingLetterCheckBox.Name = "LeadingLetterCheckBox";
            this.LeadingLetterCheckBox.Size = new System.Drawing.Size(88, 17);
            this.LeadingLetterCheckBox.TabIndex = 12;
            this.LeadingLetterCheckBox.Text = "Leading Text";
            this.LeadingLetterCheckBox.UseVisualStyleBackColor = true;
            this.LeadingLetterCheckBox.CheckedChanged += new System.EventHandler(this.LeadingLetterCheckBox_CheckedChanged);
            // 
            // LeadingZerosCheckBox
            // 
            this.LeadingZerosCheckBox.AutoSize = true;
            this.LeadingZerosCheckBox.Location = new System.Drawing.Point(235, 80);
            this.LeadingZerosCheckBox.Name = "LeadingZerosCheckBox";
            this.LeadingZerosCheckBox.Size = new System.Drawing.Size(94, 17);
            this.LeadingZerosCheckBox.TabIndex = 3;
            this.LeadingZerosCheckBox.Text = "Leading Zeros";
            this.LeadingZerosCheckBox.UseVisualStyleBackColor = true;
            // 
            // StartBtn
            // 
            this.StartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartBtn.Location = new System.Drawing.Point(283, 213);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 4;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // EndNumberTxtBox
            // 
            this.EndNumberTxtBox.Enabled = false;
            this.EndNumberTxtBox.Location = new System.Drawing.Point(12, 158);
            this.EndNumberTxtBox.Name = "EndNumberTxtBox";
            this.EndNumberTxtBox.Size = new System.Drawing.Size(143, 20);
            this.EndNumberTxtBox.TabIndex = 11;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.Location = new System.Drawing.Point(364, 213);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "End Number";
            // 
            // StartNumberTxtBox
            // 
            this.StartNumberTxtBox.Enabled = false;
            this.StartNumberTxtBox.Location = new System.Drawing.Point(12, 119);
            this.StartNumberTxtBox.Name = "StartNumberTxtBox";
            this.StartNumberTxtBox.Size = new System.Drawing.Size(143, 20);
            this.StartNumberTxtBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Start Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Type:";
            // 
            // SavePathBtn
            // 
            this.SavePathBtn.Location = new System.Drawing.Point(407, 18);
            this.SavePathBtn.Name = "SavePathBtn";
            this.SavePathBtn.Size = new System.Drawing.Size(28, 20);
            this.SavePathBtn.TabIndex = 6;
            this.SavePathBtn.Text = "...";
            this.SavePathBtn.UseVisualStyleBackColor = true;
            this.SavePathBtn.Click += new System.EventHandler(this.SavePathBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "File Path:";
            // 
            // IncrementTxtBox
            // 
            this.IncrementTxtBox.Location = new System.Drawing.Point(12, 80);
            this.IncrementTxtBox.Name = "IncrementTxtBox";
            this.IncrementTxtBox.Size = new System.Drawing.Size(143, 20);
            this.IncrementTxtBox.TabIndex = 2;
            // 
            // FilePathTxtBox
            // 
            this.FilePathTxtBox.Enabled = false;
            this.FilePathTxtBox.Location = new System.Drawing.Point(235, 18);
            this.FilePathTxtBox.Name = "FilePathTxtBox";
            this.FilePathTxtBox.Size = new System.Drawing.Size(166, 20);
            this.FilePathTxtBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Increment Value";
            // 
            // CsvOutputCheckBox
            // 
            this.CsvOutputCheckBox.AutoSize = true;
            this.CsvOutputCheckBox.Location = new System.Drawing.Point(235, 44);
            this.CsvOutputCheckBox.Name = "CsvOutputCheckBox";
            this.CsvOutputCheckBox.Size = new System.Drawing.Size(139, 17);
            this.CsvOutputCheckBox.TabIndex = 3;
            this.CsvOutputCheckBox.Text = "Output Changes to CSV";
            this.CsvOutputCheckBox.UseVisualStyleBackColor = true;
            this.CsvOutputCheckBox.CheckedChanged += new System.EventHandler(this.CsvOutputCheckBox_CheckedChanged);
            // 
            // ModeComboBox
            // 
            this.ModeComboBox.FormattingEnabled = true;
            this.ModeComboBox.Items.AddRange(new object[] {
            "All",
            "Increment Only",
            "From Number",
            "To Number",
            "Between Numbers"});
            this.ModeComboBox.Location = new System.Drawing.Point(12, 40);
            this.ModeComboBox.Name = "ModeComboBox";
            this.ModeComboBox.Size = new System.Drawing.Size(143, 21);
            this.ModeComboBox.TabIndex = 0;
            this.ModeComboBox.SelectedIndexChanged += new System.EventHandler(this.ModeComboBox_SelectedIndexChanged);
            this.ModeComboBox.TextChanged += new System.EventHandler(this.ModeComboBox_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.PolylineStatusTxtBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.PickPolylineBtn);
            this.groupBox3.Location = new System.Drawing.Point(12, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(445, 53);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Polyline Details";
            // 
            // PolylineStatusTxtBox
            // 
            this.PolylineStatusTxtBox.Enabled = false;
            this.PolylineStatusTxtBox.Location = new System.Drawing.Point(55, 19);
            this.PolylineStatusTxtBox.Name = "PolylineStatusTxtBox";
            this.PolylineStatusTxtBox.Size = new System.Drawing.Size(290, 20);
            this.PolylineStatusTxtBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status:";
            // 
            // PickPolylineBtn
            // 
            this.PickPolylineBtn.Location = new System.Drawing.Point(351, 17);
            this.PickPolylineBtn.Name = "PickPolylineBtn";
            this.PickPolylineBtn.Size = new System.Drawing.Size(84, 23);
            this.PickPolylineBtn.TabIndex = 3;
            this.PickPolylineBtn.Text = "Pick Polyline";
            this.PickPolylineBtn.UseVisualStyleBackColor = true;
            this.PickPolylineBtn.Click += new System.EventHandler(this.PickPolylineBtn_Click);
            // 
            // SaveFileDialogCSV
            // 
            this.SaveFileDialogCSV.CheckFileExists = true;
            this.SaveFileDialogCSV.CreatePrompt = true;
            this.SaveFileDialogCSV.DefaultExt = "csv";
            this.SaveFileDialogCSV.InitialDirectory = "%userprofile%";
            this.SaveFileDialogCSV.RestoreDirectory = true;
            this.SaveFileDialogCSV.SupportMultiDottedExtensions = true;
            this.SaveFileDialogCSV.Title = "Save to .CSV";
            this.SaveFileDialogCSV.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialogCSV_FileOk);
            // 
            // PLineDuplicates
            // 
            this.PLineDuplicates.AutoSize = true;
            this.PLineDuplicates.Location = new System.Drawing.Point(235, 119);
            this.PLineDuplicates.Name = "PLineDuplicates";
            this.PLineDuplicates.Size = new System.Drawing.Size(156, 17);
            this.PLineDuplicates.TabIndex = 14;
            this.PLineDuplicates.Text = "Polyline Vertices Duplicates";
            this.PLineDuplicates.UseVisualStyleBackColor = true;
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 406);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainInterface";
            this.Text = "Altext";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox AttributeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PickBlockBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox IncrementTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ModeComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox PolylineStatusTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PickPolylineBtn;
        private System.Windows.Forms.TextBox EndNumberTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox StartNumberTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SavePathBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FilePathTxtBox;
        private System.Windows.Forms.CheckBox CsvOutputCheckBox;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.CheckBox LeadingZerosCheckBox;
        private System.Windows.Forms.SaveFileDialog SaveFileDialogCSV;
        private System.Windows.Forms.TextBox LeadingLetterTxtBox;
        private System.Windows.Forms.CheckBox LeadingLetterCheckBox;
        private System.Windows.Forms.CheckBox PLineDuplicates;
    }
}