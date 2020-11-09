namespace ExcelToTxt
{
  partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.ui_InputPathText = new System.Windows.Forms.TextBox();
            this.ui_ExcelPathBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ui_OutputPathText = new System.Windows.Forms.TextBox();
            this.ui_TxtPathBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ui_NewConfigBtn = new System.Windows.Forms.Button();
            this.ui_ConfigPathBtn = new System.Windows.Forms.Button();
            this.ui_ConfigPathText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ui_FileNameText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ui_StartBtn = new System.Windows.Forms.Button();
            this.ui_KeepNameCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ui_ResultText = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excel文件路径:";
            // 
            // ui_InputPathText
            // 
            this.ui_InputPathText.Location = new System.Drawing.Point(143, 21);
            this.ui_InputPathText.Name = "ui_InputPathText";
            this.ui_InputPathText.Size = new System.Drawing.Size(473, 23);
            this.ui_InputPathText.TabIndex = 1;
            // 
            // ui_ExcelPathBtn
            // 
            this.ui_ExcelPathBtn.Location = new System.Drawing.Point(623, 16);
            this.ui_ExcelPathBtn.Name = "ui_ExcelPathBtn";
            this.ui_ExcelPathBtn.Size = new System.Drawing.Size(89, 33);
            this.ui_ExcelPathBtn.TabIndex = 2;
            this.ui_ExcelPathBtn.Text = "打开";
            this.ui_ExcelPathBtn.UseVisualStyleBackColor = true;
            this.ui_ExcelPathBtn.Click += new System.EventHandler(this.ui_ExcelPathBtn_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Txt保存路径:";
            // 
            // ui_OutputPathText
            // 
            this.ui_OutputPathText.Location = new System.Drawing.Point(143, 64);
            this.ui_OutputPathText.Name = "ui_OutputPathText";
            this.ui_OutputPathText.Size = new System.Drawing.Size(473, 23);
            this.ui_OutputPathText.TabIndex = 1;
            // 
            // ui_TxtPathBtn
            // 
            this.ui_TxtPathBtn.Location = new System.Drawing.Point(623, 59);
            this.ui_TxtPathBtn.Name = "ui_TxtPathBtn";
            this.ui_TxtPathBtn.Size = new System.Drawing.Size(89, 33);
            this.ui_TxtPathBtn.TabIndex = 2;
            this.ui_TxtPathBtn.Text = "打开";
            this.ui_TxtPathBtn.UseVisualStyleBackColor = true;
            this.ui_TxtPathBtn.Click += new System.EventHandler(this.ui_TxtPathBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ui_TxtPathBtn);
            this.groupBox1.Controls.Add(this.ui_ExcelPathBtn);
            this.groupBox1.Controls.Add(this.ui_OutputPathText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ui_InputPathText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 98);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件路径";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ui_NewConfigBtn);
            this.groupBox2.Controls.Add(this.ui_ConfigPathBtn);
            this.groupBox2.Controls.Add(this.ui_ConfigPathText);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ui_FileNameText);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ui_StartBtn);
            this.groupBox2.Controls.Add(this.ui_KeepNameCheckBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 186);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "转换选项";
            // 
            // ui_NewConfigBtn
            // 
            this.ui_NewConfigBtn.Location = new System.Drawing.Point(174, 113);
            this.ui_NewConfigBtn.Name = "ui_NewConfigBtn";
            this.ui_NewConfigBtn.Size = new System.Drawing.Size(89, 27);
            this.ui_NewConfigBtn.TabIndex = 12;
            this.ui_NewConfigBtn.Text = "新建";
            this.ui_NewConfigBtn.UseVisualStyleBackColor = true;
            this.ui_NewConfigBtn.Click += new System.EventHandler(this.ui_NewConfigBtn_Click);
            // 
            // ui_ConfigPathBtn
            // 
            this.ui_ConfigPathBtn.Location = new System.Drawing.Point(269, 113);
            this.ui_ConfigPathBtn.Name = "ui_ConfigPathBtn";
            this.ui_ConfigPathBtn.Size = new System.Drawing.Size(89, 27);
            this.ui_ConfigPathBtn.TabIndex = 3;
            this.ui_ConfigPathBtn.Text = "打开";
            this.ui_ConfigPathBtn.UseVisualStyleBackColor = true;
            this.ui_ConfigPathBtn.Click += new System.EventHandler(this.ui_ConfigPathBtn_Click);
            // 
            // ui_ConfigPathText
            // 
            this.ui_ConfigPathText.Location = new System.Drawing.Point(31, 144);
            this.ui_ConfigPathText.Name = "ui_ConfigPathText";
            this.ui_ConfigPathText.Size = new System.Drawing.Size(327, 23);
            this.ui_ConfigPathText.TabIndex = 11;
            this.ui_ConfigPathText.TextChanged += new System.EventHandler(this.ui_ConfigPathText_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(31, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "3.类型转换表路径";
            // 
            // ui_FileNameText
            // 
            this.ui_FileNameText.Location = new System.Drawing.Point(122, 76);
            this.ui_FileNameText.Name = "ui_FileNameText";
            this.ui_FileNameText.Size = new System.Drawing.Size(235, 23);
            this.ui_FileNameText.TabIndex = 9;
            this.ui_FileNameText.Text = "TranslatedFileName";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(31, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "2.输出文件名";
            // 
            // ui_StartBtn
            // 
            this.ui_StartBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
            this.ui_StartBtn.Location = new System.Drawing.Point(409, 23);
            this.ui_StartBtn.Name = "ui_StartBtn";
            this.ui_StartBtn.Size = new System.Drawing.Size(303, 157);
            this.ui_StartBtn.TabIndex = 7;
            this.ui_StartBtn.Text = "转换";
            this.ui_StartBtn.UseVisualStyleBackColor = true;
            this.ui_StartBtn.Click += new System.EventHandler(this.ui_StartBtn_Click);
            // 
            // ui_KeepNameCheckBox
            // 
            this.ui_KeepNameCheckBox.Checked = true;
            this.ui_KeepNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ui_KeepNameCheckBox.Location = new System.Drawing.Point(122, 40);
            this.ui_KeepNameCheckBox.Name = "ui_KeepNameCheckBox";
            this.ui_KeepNameCheckBox.Size = new System.Drawing.Size(59, 20);
            this.ui_KeepNameCheckBox.TabIndex = 4;
            this.ui_KeepNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(30, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "1.保留行名";
            // 
            // ui_ResultText
            // 
            this.ui_ResultText.Location = new System.Drawing.Point(421, 112);
            this.ui_ResultText.Name = "ui_ResultText";
            this.ui_ResultText.Size = new System.Drawing.Size(230, 20);
            this.ui_ResultText.TabIndex = 8;
            this.ui_ResultText.Text = "Excel文件不存在";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(742, 333);
            this.Controls.Add(this.ui_ResultText);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "编程王精品工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ui_InputPathText;
        private System.Windows.Forms.TextBox ui_OutputPathText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ui_KeepNameCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ui_ResultText;
        private System.Windows.Forms.Button ui_StartBtn;
        private System.Windows.Forms.Button ui_TxtPathBtn;
        private System.Windows.Forms.Button ui_ExcelPathBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ui_FileNameText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ui_ConfigPathText;
        private System.Windows.Forms.Button ui_ConfigPathBtn;
        private System.Windows.Forms.Button ui_NewConfigBtn;
    }
}