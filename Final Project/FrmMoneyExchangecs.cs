using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//Tsiory Rakotoarimanana
//10/07/2023

namespace Final_Project
{
    public partial class FrmMoneyExchanges : Form
    {
        string dir = @".\Final Project\";
        string path = @".\Final Project\MoneyConverter.txt";
        FileStream fs = null;
        DateTime initial;
        DateTime final;
        public FrmMoneyExchanges()
        {
            InitializeComponent();
            initial = DateTime.Now;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (radioCad.Checked)
            {
                MoneyConvert(1,txtFrom,txtCad,txtEur,txtMga,txtUsd,txtGbp,txtCop);
            }
            if (radioUsd.Checked)
            {
                MoneyConvert(2, txtFrom, txtCad, txtEur, txtMga, txtUsd, txtGbp, txtCop);
            }
            if (radioEur.Checked)
            {
                MoneyConvert(3, txtFrom, txtCad, txtEur, txtMga, txtUsd, txtGbp, txtCop);
            }
            if (radioGbp.Checked)
            {
                MoneyConvert(4, txtFrom, txtCad, txtEur, txtMga, txtUsd, txtGbp, txtCop);
            }
            if (radioMga.Checked)
            {
                MoneyConvert(5, txtFrom, txtCad, txtEur, txtMga, txtUsd, txtGbp, txtCop);
            }
          


        }
            static string currency;
            int valueToConvert;
        private void MoneyConvert(int num,TextBox from,TextBox t1, TextBox t2, TextBox t3, TextBox t4, TextBox t5, TextBox t6)
        {
           
            
            
                
                try
                {
                    valueToConvert= Convert.ToInt32(from.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Please enter a numeric value");
                    num = 0;
                    from.Focus();
                    
                }
                if (valueToConvert<0)
                {
                    MessageBox.Show("Please enter a positive value");
                    t1.Text = "XXXXXXX";
                    t2.Text = "XXXXXXX";
                    t3.Text = "XXXXXXX";
                    t4.Text = "XXXXXXX";
                    t5.Text = "XXXXXXX";
                    t6.Text = "XXXXXXX";
                    num = 0;
                    from.Focus();
                    
               
                }

                if (num == 1)
                {
                    t1.Text= valueToConvert.ToString();
                    t2.Text= (valueToConvert*0.685).ToString();
                    t3.Text = (valueToConvert * 3422.762).ToString();
                    t4.Text = (valueToConvert * 0.75).ToString();
                    t5.Text = (valueToConvert * 0.58).ToString();
                    t6.Text = (valueToConvert * 3131.25).ToString();
                currency = "CAD";
                }

                if (num == 2)
                {
                    t1.Text = (valueToConvert*1.32).ToString();
                    t2.Text = (valueToConvert * 0.90).ToString();
                    t3.Text = (valueToConvert * 4545.70).ToString();
                    t4.Text = (valueToConvert).ToString();
                    t5.Text = (valueToConvert * 0.77).ToString();
                    t6.Text = (valueToConvert * 4154.17).ToString();
                currency = "USD";
                }

                if (num == 3)
                {
                    t1.Text = (valueToConvert * 1.46).ToString();
                    t2.Text = (valueToConvert ).ToString();
                    t3.Text = (valueToConvert * 5000).ToString();
                    t4.Text = (valueToConvert*1.1).ToString();
                    t5.Text = (valueToConvert * 0.85).ToString();
                    t6.Text = (valueToConvert * 4572.93).ToString();
                currency = "EUR";
                }

                if (num == 4)
                {
                    t1.Text = (valueToConvert * 1.70).ToString();
                    t2.Text = (valueToConvert*1.16).ToString();
                    t3.Text = (valueToConvert * 5847.98).ToString();
                    t4.Text = (valueToConvert * 1.28).ToString();
                    t5.Text = (valueToConvert ).ToString();
                    t6.Text = (valueToConvert * 5346.41).ToString();
                currency = "GBP";
                }

                if (num == 5)
                {
                    t1.Text = (valueToConvert * 0.00029).ToString();
                    t2.Text = (valueToConvert * 0.00019).ToString();
                    t3.Text = (valueToConvert ).ToString();
                    t4.Text = (valueToConvert * 0.00022).ToString();
                    t5.Text = (valueToConvert*0.00017).ToString();
                    t6.Text = (valueToConvert * 0.91).ToString();
                currency = "MGA";
                }
                if (num>=1 && num<=5)
                {

                    try
                    {
                        fs = new FileStream(path, FileMode.Append, FileAccess.Write);

                        StreamWriter textOut = new StreamWriter(fs);


                        textOut.Write(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss tt\n"));
                        textOut.Write(valueToConvert + " " + currency + "= " + t1.Text + " CAD; " + t2.Text + " EUR; " + t3.Text + " MGA; " + t4.Text + " USD; " + t5.Text + " GBP; " + t6.Text + " COP; \n");



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
             }

        private void FrmMoneyExchanges_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
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
                    textToPrint += row + "\n\n";
                }
                MessageBox.Show(textToPrint, "Money Exchange");

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            final=DateTime.Now;
            TimeSpan timeSpent = final.Subtract(initial);
            if (MessageBox.Show("Do you want to quit the app? You have been here "+timeSpent.Minutes+"min "+timeSpent.Seconds+"s", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
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
