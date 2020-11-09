using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Spire.Xls;
using System.Windows.Forms;

namespace ExcelToTxt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ui_ResultText.Text = "";
        }
        
        void LoadExcel(string inputPath,string outputPath,bool keepName,Dictionary<string,Dictionary<string,string>> config)
        {
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(inputPath);
            Worksheet sheet = workbook.Worksheets[0];
            FileStream fs = new FileStream(outputPath, FileMode.Create);
            Encoding utf8 = Encoding.UTF8;
            
            string[] columnNames = new string[sheet.Columns.Length];
            for(int i = 0; i < columnNames.Length; i++)
            {
                columnNames[i] = sheet.Columns[i].DisplayedText;
            }
            
            int index = keepName ? 0 : 1;
            for (;index < sheet.Rows.Length; index++)
            {
                var row = sheet.Rows[index];
                string content = "";
                for (int i = 0; i < row.Count; i++)
                {
                    string item = row.Cells[i].Value;
                    if (config.ContainsKey(columnNames[i]) && config[columnNames[i]].ContainsKey(item))
                    {
                        item = config[columnNames[i]][item];
                    }
                    
                    if (i > 0)
                        content += "|";
                    item = item.Replace((char) 0x0A, (char) 0x1E).Replace('|', (char) 0x1F);
                    content += item;
                }

                content += (char) 0x0A;
                byte[] bytes = utf8.GetBytes(content);
                fs.Write(bytes, 0, bytes.Length);
            }
            fs.Close();
        }

        void LoadCSV(string inputPath,string outputPath,bool keepName = true)
        {
            throw new Exception("暂时不能读取CSV");
            using (StreamReader  sr = new StreamReader (inputPath,Encoding.Default))
            {
                FileStream fs = new FileStream(outputPath, FileMode.Create);
                Encoding utf8 = Encoding.UTF8;
                string curLine;
                if (!keepName)
                    sr.ReadLine();
                while ((curLine = sr.ReadLine()) != null)
                {
                    string[] items = curLine.Split(',');
                    string content = "";
                    for (int i = 0; i < items.Length; i++)
                    {
                        if (i > 0)
                            content += "|";
                        string item = items[i].Replace((char) 0x0A, (char) 0x1E).Replace('|', (char) 0x1F);
                        content += item;
                    }
                    content += (char) 0x0A;
                    byte[] bytes = utf8.GetBytes(content);
                    fs.Write(bytes, 0, bytes.Length);
                }
                fs.Close();
            }
        }

        private void ui_ExcelPathBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ui_InputPathText.Text = dialog.FileName;
            }
        }

        private void ui_TxtPathBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ui_OutputPathText.Text = dialog.SelectedPath;
            }
        }
        
        private void ui_ConfigPathBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ui_ConfigPathText.Text = dialog.FileName;
            }
        }

        private void ui_StartBtn_Click(object sender, EventArgs e)
        {
            string inputPath = ui_InputPathText.Text;
            string outputPath = ui_OutputPathText.Text;
            if (!File.Exists(inputPath) || !Directory.Exists(outputPath))
            {
                ui_ResultText.Text = "目标文件或路径不存在";
                return;
            }

            string fileName = ui_FileNameText.Text;
            if (fileName.Trim() == "")
            {
                ui_ResultText.Text = "输出文件名不能为空";
                return;
            }

            var config = new Dictionary<string, Dictionary<string, string>>();
            if (configPath != String.Empty)
            {
                try
                {
                    Workbook workbook = new Workbook();
                    
                    workbook.LoadFromFile(configPath);
                    Worksheet sheet = workbook.Worksheets[0];
                    if (sheet.Columns.Length != 3)
                        throw new Exception("配置表格式错误！格式：1、对应列名 2、替换前字符 3、替换后字符");
                    for (int index = 1;index < sheet.Rows.Length; index++)
                    {
                        var row = sheet.Rows[index];
                        string columnName = row.Cells[0].Value;
                        string oldValue = row.Cells[1].Value;
                        string newValue = row.Cells[2].Value;
                        if(!config.ContainsKey(columnName))
                            config.Add(columnName,new Dictionary<string, string>());
                        if(!config.ContainsKey(oldValue))
                            config[columnName].Add(oldValue,newValue);
                        else
                            throw new Exception($"映射表中列({columnName})的OldValue有重复值({oldValue})");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
            }

            outputPath = outputPath + "//" + fileName + ".txt";
            FileInfo fileInfo = new FileInfo(inputPath);
            try
            {
                bool keepName = ui_KeepNameCheckBox.Checked;
                if (fileInfo.Extension == ".csv")
                    LoadCSV(inputPath, outputPath,keepName);
                else
                    LoadExcel(inputPath, outputPath,keepName,config);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            ui_ResultText.Text = "转换成功";
        }

        string configPath = String.Empty;
        private void ui_ConfigPathText_TextChanged(object sender, EventArgs e)
        {
            if (ui_ConfigPathText.Text.Trim() == String.Empty)
            {
                configPath = String.Empty;
                ui_ResultText.Text = "";
                return;
            }

            FileInfo fi = new FileInfo(ui_ConfigPathText.Text);
            if (!fi.Exists)
            {
                ui_ResultText.Text = "类型转换表不存在";
            }
            else if(fi.Extension != ".xls" && fi.Extension != ".xlsx")
            {
                ui_ResultText.Text = "类型转换表不是excel文件";
            }
            else
            {
                ui_ResultText.Text = "";
                configPath = ui_ConfigPathText.Text;
            }
        }

        private void ui_NewConfigBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                string newConfigPath = dialog.SelectedPath;
                Workbook workbook = new Workbook();
                Worksheet sheet = workbook.Worksheets[0];
                sheet.Range["A1"].Text = "Column";
                sheet.Range["B1"].Text = "OldValue";
                sheet.Range["C1"].Text = "NewValue";
                workbook.SaveToFile(newConfigPath + "/config.xlsx",FileFormat.Version2013);
                workbook.Dispose();
                System.Diagnostics.Process.Start(newConfigPath + "/config.xlsx");
                ui_ConfigPathText.Text = newConfigPath + "\\config.xlsx";
            }
        }
    }
}