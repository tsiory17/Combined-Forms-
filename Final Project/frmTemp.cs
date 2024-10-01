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
//17/07/2023
namespace Final_Project
{
    public partial class frmTemp : Form
    {
        double valueEntered;
        double result;
        string message;
        char symbolTO;
        char symbolFrom;
        bool validate = false;
        string dir = @".\Final Project\";
        string path = @".\Final Project\TemperatureConversions.txt";
        FileStream fs = null;
        bool color = false;
        public frmTemp()
        {
            InitializeComponent();
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                valueEntered = Convert.ToDouble(txtFrom.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid number ");
                validate= true; 
                txtTo.Focus();
            }
            message = " ";
            txtFrom.ForeColor= Color.Black; 
            if (radioCtoF.Checked)
            {
                result = (valueEntered * 9 / 5) + 32;
                txtTo.Text = result.ToString();
                //if (result > 212 && result <= 212 && result > 104)
                //if ( result == 212)
                //{
                //    message = "Water boils";
                //    txtFrom.ForeColor= Color.Red;
                //    txtFrom.Font = new Font(txtFrom.Font, FontStyle.Bold) ;
                //    color= true;
                //}

                //if (result==104 )
                //{
                //    message = "Hot Bath";
                //    txtFrom.ForeColor = Color.Red;
                //    txtFrom.Font = new Font(txtFrom.Font, FontStyle.Bold);
                //    color = true;
                //}
                //if (result == 98.6)
                //{
                //    message = "Body Temperature";
                //    txtFrom.ForeColor = Color.Yellow;
                //    txtFrom.Font = new Font(txtFrom.Font, FontStyle.Bold);
                //    color = true;
                //}
                //if (result == 86)
                //{
                //    message = "Beach Weather";
                //    txtFrom.ForeColor = Color.Yellow;
                //    txtFrom.Font = new Font(txtFrom.Font, FontStyle.Bold);
                //    color = true;
                //}
                //if (result == 70)
                //{
                //    message = "Room Temperature";
                //    txtFrom.ForeColor = Color.Green;
                //    color= true;
                //    txtDisplay.Text = message;
                //}

                //if (result == 50)
                //{
                //    message = "Cool day";
                //    txtFrom.ForeColor = Color.DarkBlue;
                //    color= true;
                //    txtFrom.Font = new Font(txtFrom.Font, FontStyle.Bold);
                //    txtDisplay.Text = message;
                //}

                //if (result == 32)
                //{
                //    message = "Freezing point of water";
                //    txtFrom.ForeColor = Color.DarkBlue;
                //    txtFrom.Font = new Font(txtFrom.Font, FontStyle.Bold);
                //    color = true;
                //    txtDisplay.Text = message;
                //}
                //if (result == 0 )
                //{
                //    message = "Very Cold Day";
                //    color= true;
                //    txtDisplay.Text = message;
                //}
                //if (result == -40)
                //{

                //    message = "Extremely Cold Day\n(and the same number!)";
                //    color= true;
                //    txtDisplay.Text = message;
                //    txtFrom.Font = new Font(txtFrom.Font, FontStyle.Bold);
                //}
                if (result >= 104)
                {
                    txtFrom.ForeColor = Color.Red;
                    txtFrom.Font = new Font(txtFrom.Font, FontStyle.Bold);
                    if (result == 212)
                    {
                        message = "Water boils";
                    }
                    if (result == 104)
                    {
                        message = "Hot Bath";
                        txtFrom.ForeColor = Color.Red;
                        txtFrom.Font = new Font(txtFrom.Font, FontStyle.Bold);
                    }
                }

                if (result >= 86 && result <= 98.6)
                {

                    txtFrom.ForeColor = Color.Yellow;
                    txtFrom.Font = new Font(txtFrom.Font, FontStyle.Bold);
                    if (result == 98.6)
                    {
                        message = "Body Temperature";
                    }
                    if (result == 86)
                    {
                        message = "Beach Weather";
                        txtFrom.ForeColor = Color.Yellow;
                        txtFrom.Font = new Font(txtFrom.Font, FontStyle.Bold);
                    }
                }
                if (result >= 70 && result < 86)
                {

                    txtFrom.ForeColor = Color.Green;
                    if (result == 70)
                    {
                        message = "Room Temperature";
                    }
                }

                if (result < 70 && result >= 32)
                {

                    txtFrom.ForeColor = Color.DarkBlue;
                    txtFrom.Font = new Font(txtFrom.Font, FontStyle.Bold);
                    if (result == 50)
                    {
                        message = "Cool day";
                    }

                    if (result == 32)
                    {
                        message = "Freezing point of water";
                        txtFrom.ForeColor = Color.DarkBlue;
                        txtFrom.Font = new Font(txtFrom.Font, FontStyle.Bold);
                    }
                }
                if (result >= 0 && result < 32)
                {

                    if (result == 0)
                    {
                        message = "Very Cold day";
                    }
                }
                if (result < 0)
                {

                    txtFrom.Font = new Font(txtFrom.Font, FontStyle.Bold);
                    if (result == -40)
                    {
                        message = "Extremely Cold Day\n(and the same number!)";
                    }

                }
                txtDisplay.Text = message;
                symbolFrom = 'C';
                symbolTO = 'F';
            }

            if (radioFtoC.Checked)
            {
                //lblC. = "F";
                //lblF.Text = "C";
                result = (valueEntered - 32) * 5 / 9;
                txtTo.Text = result.ToString();
                if (valueEntered>=104)
                {
                    txtFrom.ForeColor = Color.Red;
                    txtFrom.Font = new Font(txtFrom.Font, FontStyle.Bold);
                    if (valueEntered == 212)
                    {
                        message = "Water boils";
                    }
                    if (valueEntered == 104 )
                    {
                        message = "Hot Bath";
                        txtFrom.ForeColor = Color.Red;
                        txtFrom.Font = new Font(txtFrom.Font, FontStyle.Bold);
                    }
                }

                if (valueEntered>=86 && valueEntered<=98.6)
                {

                    txtFrom.ForeColor = Color.Yellow;
                    txtFrom.Font = new Font(txtFrom.Font, FontStyle.Bold);
                    if (valueEntered == 98.6 )
                    {
                        message = "Body Temperature";
                    }
                    if (valueEntered == 86 )
                    {
                        message = "Beach Weather";
                        txtFrom.ForeColor = Color.Yellow;
                        txtFrom.Font = new Font(txtFrom.Font, FontStyle.Bold);
                    }
                }
                if (valueEntered>=70 && valueEntered<86)
                {

                     txtFrom.ForeColor = Color.Green;
                    if (valueEntered == 70)
                    {
                        message = "Room Temperature";
                    }
                }

                if (valueEntered<70 && valueEntered>=32)
                {

                    txtFrom.ForeColor = Color.DarkBlue;
                    txtFrom.Font = new Font(txtFrom.Font, FontStyle.Bold);
                    if (valueEntered == 50)
                    {
                        message = "Cool day";
                    }

                    if (valueEntered == 32)
                    {
                        message = "Freezing point of water";
                        txtFrom.ForeColor = Color.DarkBlue;
                        txtFrom.Font = new Font(txtFrom.Font, FontStyle.Bold);
                    }
                }
                if (valueEntered>=0 && valueEntered<32)
                {

                    if (valueEntered == 0 )
                    {
                        message = "Very Cold day";
                    }
                }
                if (valueEntered<0)
                {

                    txtFrom.Font = new Font(txtFrom.Font, FontStyle.Bold);
                    if (valueEntered == -40)
                    {
                        message = "Extremely Cold Day\n(and the same number!)";
                    }
               
                }
                txtDisplay.Text = message;
                symbolFrom = 'F';
                symbolTO = 'C';
            }
            string check;
            if (validate == false)
            {

             
                try
                {
                    fs = new FileStream(path, FileMode.Append, FileAccess.Write);

                    StreamWriter textOut = new StreamWriter(fs);


                    textOut.WriteLine(valueEntered + " " + symbolFrom + "  =  " + result + " " + symbolTO+ DateTime.Now.ToString(",  yyyy/MM/dd hh:mm:ss tt ") + message);
                    textOut.Write(" ");



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

        private void frmTemp_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }

        private void btnRead_Click(object sender, EventArgs e)
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
                MessageBox.Show(textToPrint, "Temperature conversion");

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
            if (MessageBox.Show("Do you want to quit the app? You have been here ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void radioFtoC_CheckedChanged(object sender, EventArgs e)
        {
            lblC.Text = "F";
            lblF.Text= "C";
        }

        private void radioCtoF_CheckedChanged(object sender, EventArgs e)
        {
            lblC.Text = "C";
            lblF.Text = "F";
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }
    }

    //private void frmTemp_Load(object sender, EventArgs e)
    //    {
            
    //    }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}
}

