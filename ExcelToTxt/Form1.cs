using System;
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
        
        void LoadExcel(string inputPath,string outputPath,bool keepName = true)
        {
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(inputPath);
            Worksheet sheet = workbook.Worksheets[0];
            FileStream fs = new FileStream(outputPath, FileMode.Create);
            Encoding utf8 = Encoding.UTF8;
            int index = keepName ? 0 : 1;
            for (;index < sheet.Rows.Length; index++)
            {
                var row = sheet.Rows[index];
                string content = "";
                for (int i = 0; i < row.Count; i++)
                {
                    if (i > 0)
                        content += "|";
                    string item = row.Cells[i].Value.Replace((char) 0x0A, (char) 0x1E).Replace('|', (char) 0x1F);
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

            outputPath = outputPath + "//" + fileName + ".txt";
            FileInfo fileInfo = new FileInfo(inputPath);
            try
            {
                bool keepName = ui_KeepNameCheckBox.Checked;
                if (fileInfo.Extension == ".csv")
                    LoadCSV(inputPath, outputPath,keepName);
                else
                    LoadExcel(inputPath, outputPath,keepName);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            ui_ResultText.Text = "转换成功";
        }
    }
}