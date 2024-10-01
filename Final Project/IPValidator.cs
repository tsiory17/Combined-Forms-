using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
//Tsiory Rakotoarimanana
namespace Final_Project
{
    public partial class IPValidator : Form
    {
        string dir = @".\Final Project\";
        string path = @".\Final Project\IP.txt";
        FileStream fs = null;
        Regex ipV4;
        Regex ipV6;
        public IPValidator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void IPValidator_Load(object sender, EventArgs e)
        {
            DateTime now= DateTime.Today;
            label1.Text = "Today : "+ now.ToLongDateString();
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            ipV4 = new Regex(@"^(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}$");
            string v4 = txtV4.Text.Trim();
            v4 = v4.Replace(" ","");
            if (ipV4.IsMatch(v4))
            {
                MessageBox.Show(txtV4.Text + "\n The IP V4 is correct", "Valid IP");
                ipV6 = new Regex(@"^([0-9a-fA-F]{1,4}:){7}([0-9a-fA-F]){1,4}$");
                string v6= txtV6.Text.Trim();
                v6 = v6.Replace(" ","");
                if (ipV6.IsMatch(v6))
                {
                    MessageBox.Show(txtV4.Text + "\n The IP V6 is correct", "Valid IP");
                    try
                    {
                        fs = new FileStream(path, FileMode.Append, FileAccess.Write);

                        StreamWriter textOut = new StreamWriter(fs);


                       
                        textOut.Write("IPV4: " + v4 + "\nIPV6" + v6 +"\n");



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
                else
                {
                    MessageBox.Show("Invalid format\nPlease enter this format xxxx:xxxx:xxxx:xxxx:xxxx:xxxx:xxxx:xxxx\nx is an hexadecimal number (0-9)or(A-F)","Error");
                }
            }
            else
            {
                MessageBox.Show(txtV4.Text + "\nThe IP must have 4 bytes\n Integer number between 0 to 255\nseparated by a dot(255.255.255.255)", "Error");
                txtV4.Focus();
            }
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
                MessageBox.Show(textToPrint, "IP Validator");

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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtV4.Text = "";
            txtV6.Text= string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }

        }
    }
}
