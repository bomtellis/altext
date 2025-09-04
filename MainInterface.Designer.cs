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
            groupBox1 = new System.Windows.Forms.GroupBox();
            AttributeComboBox = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            PickBlockBtn = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            PLineDuplicates = new System.Windows.Forms.CheckBox();
            LeadingLetterTxtBox = new System.Windows.Forms.TextBox();
            LeadingLetterCheckBox = new System.Windows.Forms.CheckBox();
            LeadingZerosCheckBox = new System.Windows.Forms.CheckBox();
            StartBtn = new System.Windows.Forms.Button();
            CancelBtn = new System.Windows.Forms.Button();
            StartNumberTxtBox = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            SavePathBtn = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            IncrementTxtBox = new System.Windows.Forms.TextBox();
            FilePathTxtBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            CsvOutputCheckBox = new System.Windows.Forms.CheckBox();
            ModeComboBox = new System.Windows.Forms.ComboBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            PolylineStatusTxtBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            PickPolylineBtn = new System.Windows.Forms.Button();
            SaveFileDialogCSV = new System.Windows.Forms.SaveFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.Controls.Add(AttributeComboBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(PickBlockBtn);
            groupBox1.Location = new System.Drawing.Point(14, 14);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(519, 85);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Block Details";
            groupBox1.UseCompatibleTextRendering = true;
            // 
            // AttributeComboBox
            // 
            AttributeComboBox.Enabled = false;
            AttributeComboBox.FormattingEnabled = true;
            AttributeComboBox.Location = new System.Drawing.Point(10, 42);
            AttributeComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            AttributeComboBox.Name = "AttributeComboBox";
            AttributeComboBox.Size = new System.Drawing.Size(391, 23);
            AttributeComboBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 22);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(113, 15);
            label1.TabIndex = 2;
            label1.Text = "Attribute to change:";
            // 
            // PickBlockBtn
            // 
            PickBlockBtn.Location = new System.Drawing.Point(420, 39);
            PickBlockBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PickBlockBtn.Name = "PickBlockBtn";
            PickBlockBtn.Size = new System.Drawing.Size(88, 27);
            PickBlockBtn.TabIndex = 0;
            PickBlockBtn.Text = "Pick Blocks";
            PickBlockBtn.UseVisualStyleBackColor = true;
            PickBlockBtn.Click += PickBlockBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox2.Controls.Add(PLineDuplicates);
            groupBox2.Controls.Add(LeadingLetterTxtBox);
            groupBox2.Controls.Add(LeadingLetterCheckBox);
            groupBox2.Controls.Add(LeadingZerosCheckBox);
            groupBox2.Controls.Add(StartBtn);
            groupBox2.Controls.Add(CancelBtn);
            groupBox2.Controls.Add(StartNumberTxtBox);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(SavePathBtn);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(IncrementTxtBox);
            groupBox2.Controls.Add(FilePathTxtBox);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(CsvOutputCheckBox);
            groupBox2.Controls.Add(ModeComboBox);
            groupBox2.Location = new System.Drawing.Point(14, 175);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(519, 279);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mode of Operation";
            // 
            // PLineDuplicates
            // 
            PLineDuplicates.AutoSize = true;
            PLineDuplicates.Location = new System.Drawing.Point(274, 137);
            PLineDuplicates.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PLineDuplicates.Name = "PLineDuplicates";
            PLineDuplicates.Size = new System.Drawing.Size(169, 19);
            PLineDuplicates.TabIndex = 14;
            PLineDuplicates.Text = "Polyline Vertices Duplicates";
            PLineDuplicates.UseVisualStyleBackColor = true;
            // 
            // LeadingLetterTxtBox
            // 
            LeadingLetterTxtBox.Enabled = false;
            LeadingLetterTxtBox.Location = new System.Drawing.Point(14, 235);
            LeadingLetterTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LeadingLetterTxtBox.Name = "LeadingLetterTxtBox";
            LeadingLetterTxtBox.Size = new System.Drawing.Size(233, 23);
            LeadingLetterTxtBox.TabIndex = 13;
            // 
            // LeadingLetterCheckBox
            // 
            LeadingLetterCheckBox.AutoSize = true;
            LeadingLetterCheckBox.Location = new System.Drawing.Point(14, 212);
            LeadingLetterCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LeadingLetterCheckBox.Name = "LeadingLetterCheckBox";
            LeadingLetterCheckBox.Size = new System.Drawing.Size(92, 19);
            LeadingLetterCheckBox.TabIndex = 12;
            LeadingLetterCheckBox.Text = "Leading Text";
            LeadingLetterCheckBox.UseVisualStyleBackColor = true;
            LeadingLetterCheckBox.CheckedChanged += LeadingLetterCheckBox_CheckedChanged;
            // 
            // LeadingZerosCheckBox
            // 
            LeadingZerosCheckBox.AutoSize = true;
            LeadingZerosCheckBox.Location = new System.Drawing.Point(274, 92);
            LeadingZerosCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LeadingZerosCheckBox.Name = "LeadingZerosCheckBox";
            LeadingZerosCheckBox.Size = new System.Drawing.Size(100, 19);
            LeadingZerosCheckBox.TabIndex = 3;
            LeadingZerosCheckBox.Text = "Leading Zeros";
            LeadingZerosCheckBox.UseVisualStyleBackColor = true;
            // 
            // StartBtn
            // 
            StartBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            StartBtn.Location = new System.Drawing.Point(330, 246);
            StartBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new System.Drawing.Size(88, 27);
            StartBtn.TabIndex = 4;
            StartBtn.Text = "Start";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            CancelBtn.Location = new System.Drawing.Point(425, 246);
            CancelBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new System.Drawing.Size(88, 27);
            CancelBtn.TabIndex = 3;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // StartNumberTxtBox
            // 
            StartNumberTxtBox.Enabled = false;
            StartNumberTxtBox.Location = new System.Drawing.Point(14, 137);
            StartNumberTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            StartNumberTxtBox.Name = "StartNumberTxtBox";
            StartNumberTxtBox.Size = new System.Drawing.Size(166, 23);
            StartNumberTxtBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(10, 119);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(121, 15);
            label6.TabIndex = 8;
            label6.Text = "Increment from value";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(10, 21);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(35, 15);
            label5.TabIndex = 7;
            label5.Text = "Type:";
            // 
            // SavePathBtn
            // 
            SavePathBtn.Location = new System.Drawing.Point(475, 21);
            SavePathBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SavePathBtn.Name = "SavePathBtn";
            SavePathBtn.Size = new System.Drawing.Size(33, 23);
            SavePathBtn.TabIndex = 6;
            SavePathBtn.Text = "...";
            SavePathBtn.UseVisualStyleBackColor = true;
            SavePathBtn.Click += SavePathBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(208, 21);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 15);
            label4.TabIndex = 5;
            label4.Text = "File Path:";
            // 
            // IncrementTxtBox
            // 
            IncrementTxtBox.Location = new System.Drawing.Point(14, 92);
            IncrementTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            IncrementTxtBox.Name = "IncrementTxtBox";
            IncrementTxtBox.Size = new System.Drawing.Size(166, 23);
            IncrementTxtBox.TabIndex = 2;
            // 
            // FilePathTxtBox
            // 
            FilePathTxtBox.Enabled = false;
            FilePathTxtBox.Location = new System.Drawing.Point(274, 21);
            FilePathTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            FilePathTxtBox.Name = "FilePathTxtBox";
            FilePathTxtBox.Size = new System.Drawing.Size(193, 23);
            FilePathTxtBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 74);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 15);
            label2.TabIndex = 1;
            label2.Text = "Increment Value";
            // 
            // CsvOutputCheckBox
            // 
            CsvOutputCheckBox.AutoSize = true;
            CsvOutputCheckBox.Location = new System.Drawing.Point(274, 51);
            CsvOutputCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CsvOutputCheckBox.Name = "CsvOutputCheckBox";
            CsvOutputCheckBox.Size = new System.Drawing.Size(151, 19);
            CsvOutputCheckBox.TabIndex = 3;
            CsvOutputCheckBox.Text = "Output Changes to CSV";
            CsvOutputCheckBox.UseVisualStyleBackColor = true;
            CsvOutputCheckBox.CheckedChanged += CsvOutputCheckBox_CheckedChanged;
            // 
            // ModeComboBox
            // 
            ModeComboBox.FormattingEnabled = true;
            ModeComboBox.Items.AddRange(new object[] { "Renumber all", "Increment from value" });
            ModeComboBox.Location = new System.Drawing.Point(14, 46);
            ModeComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ModeComboBox.Name = "ModeComboBox";
            ModeComboBox.Size = new System.Drawing.Size(166, 23);
            ModeComboBox.TabIndex = 0;
            ModeComboBox.SelectedIndexChanged += ModeComboBox_SelectedIndexChanged;
            ModeComboBox.TextChanged += ModeComboBox_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox3.Controls.Add(PolylineStatusTxtBox);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(PickPolylineBtn);
            groupBox3.Location = new System.Drawing.Point(14, 107);
            groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Size = new System.Drawing.Size(519, 61);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Polyline Details";
            // 
            // PolylineStatusTxtBox
            // 
            PolylineStatusTxtBox.Enabled = false;
            PolylineStatusTxtBox.Location = new System.Drawing.Point(64, 22);
            PolylineStatusTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PolylineStatusTxtBox.Name = "PolylineStatusTxtBox";
            PolylineStatusTxtBox.Size = new System.Drawing.Size(338, 23);
            PolylineStatusTxtBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(10, 22);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Status:";
            // 
            // PickPolylineBtn
            // 
            PickPolylineBtn.Location = new System.Drawing.Point(410, 20);
            PickPolylineBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PickPolylineBtn.Name = "PickPolylineBtn";
            PickPolylineBtn.Size = new System.Drawing.Size(98, 27);
            PickPolylineBtn.TabIndex = 3;
            PickPolylineBtn.Text = "Pick Polyline";
            PickPolylineBtn.UseVisualStyleBackColor = true;
            PickPolylineBtn.Click += PickPolylineBtn_Click;
            // 
            // SaveFileDialogCSV
            // 
            SaveFileDialogCSV.CheckFileExists = true;
            SaveFileDialogCSV.CreatePrompt = true;
            SaveFileDialogCSV.DefaultExt = "csv";
            SaveFileDialogCSV.InitialDirectory = "%userprofile%";
            SaveFileDialogCSV.RestoreDirectory = true;
            SaveFileDialogCSV.SupportMultiDottedExtensions = true;
            SaveFileDialogCSV.Title = "Save to .CSV";
            SaveFileDialogCSV.FileOk += SaveFileDialogCSV_FileOk;
            // 
            // MainInterface
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(547, 468);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainInterface";
            Text = "Altext";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);

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