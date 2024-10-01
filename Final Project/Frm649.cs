using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Tsiory Rakotoarimanana

namespace Final_Project
{
    public partial class frm649 : Form
    {
        public frm649()
        {
            InitializeComponent();
        }
        string dir = @".\Final Project\";
        string path = @".\Final Project\LottoNbrs.txt";
        FileStream fs = null;
        private void btnGenerate649_Click(object sender, EventArgs e)
        {
            Lotto obj1 = new Lotto();
            string result = obj1.WinningNumbers(6, 1, 49);
            obj1.Display(result, txtDisplay);
            result.Split();
            string[] results = result.Split('\t');
            try
            {
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);

                StreamWriter textOut = new StreamWriter(fs);


                textOut.Write("649, " + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss tt") + ",  ");
                for (int i = 0; i < results.Length; i++)
                {
                    if (i < 5)
                    {
                        textOut.Write(results[i]+ ",");
                    }
                    if (i == 5)
                    {
                        textOut.Write(results[i] + " ");
                    }
                    if (i == 6)
                    {
                        textOut.Write("\tExtra: " + results[i] + "\n");
                    }
                }

                textOut.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(path + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(path + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) fs.Close(); }
        }

        private void btnReadAndDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);

                StreamReader textIn = new StreamReader(fs);
                string textToPrint = "";

                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine().Trim();
                    textToPrint += row + "\n";
                }
                MessageBox.Show(textToPrint, "Lotto:");

                textIn.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(path + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(path + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) fs.Close(); }
        }

        private void frm649_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }
    }
}
