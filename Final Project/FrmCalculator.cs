using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Tsiory Rakotoarimanana
namespace Final_Project
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }

        static string messageOperation="";
        static bool dot ;
        static bool oper ;
        static char sign;
        static decimal result;
        bool retour;
        bool resultExist;
        bool start;
        bool deuxiemeOperation;//second operation after you click result
        bool allow; //boolean from the operator button 
        bool exist;
        bool clearStart;
        string dir = @".\Final Project\";
        string path = @".\Final Project\Calculator.txt";
        FileStream fs = null;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
                clearStart = true;

            if (clearStart == true)
            {
                btnAdd.Enabled = true;
                btnDivide.Enabled = true;
                btnSubtract.Enabled = true;
                btnMultiply.Enabled = true;
                btnResult.Enabled = false;
             //   allow = false;
                start = false;
            }

            if (allow == true)
            {
               start= true ;
                btnAdd.Enabled = false;
                btnDivide.Enabled = false;
                btnSubtract.Enabled = false;
                btnMultiply.Enabled = false;
            } 
            if (start == true)
            {
                btnResult.Enabled = true ;
            }
            else
            {
                btnResult.Enabled = false;
            }

            resultExist = false;
            messageOperation = messageOperation + "1";
            textBox1.Text = messageOperation;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            clearStart = true;
            if (clearStart == true)
            {
                btnAdd.Enabled = true;
                btnDivide.Enabled = true;
                btnSubtract.Enabled = true;
                btnMultiply.Enabled = true;
              //  allow = false;
                start = false;
            }
            if (allow == true )
            {
                
                start = true;
                btnAdd.Enabled = false;
                btnDivide.Enabled = false;
                btnSubtract.Enabled = false;
                btnMultiply.Enabled = false;
            }
            if (start == true)
            {
                btnResult.Enabled = true;
            }
            else
            {
                btnResult.Enabled = false;
            }
            if (retour == true)
        
            resultExist = false;
            messageOperation = messageOperation + "2";
            textBox1.Text = messageOperation;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            clearStart = true;
            if (clearStart == true)
            {
                btnAdd.Enabled = true;
                btnDivide.Enabled = true;
                btnSubtract.Enabled = true;
                btnMultiply.Enabled = true;
              //  allow = false;
                start = false;
            }
            if (allow == true)
            {
               
                start = true;
                btnAdd.Enabled = false;
                btnDivide.Enabled = false;
                btnSubtract.Enabled = false;
                btnMultiply.Enabled = false;

            }
            if (start == true)
            {
                btnResult.Enabled = true;
            }
            else
            {
                btnResult.Enabled = false;
            }
       
            resultExist = false;
            messageOperation = messageOperation + "3";
            textBox1.Text = messageOperation;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            clearStart = true;
            if (clearStart == true)
            {
                btnAdd.Enabled = true;
                btnDivide.Enabled = true;
                btnSubtract.Enabled = true;
                btnMultiply.Enabled = true;
                //allow = false;
                start = false;
            }
            if (allow == true)
            {
                start = true;
                btnAdd.Enabled = false;
                btnDivide.Enabled = false;
                btnSubtract.Enabled = false;
                btnMultiply.Enabled = false;
            }
            if (start == true)
            {
                btnResult.Enabled = true;
            }
            else
            {
                btnResult.Enabled = false;
            }
            //if (retour == true)
            //{
            //    btnAdd.Enabled = true;
            //    btnDivide.Enabled = true;
            //    btnSubtract.Enabled = true;
            //    btnMultiply.Enabled = true;
            //    btnResult.Enabled = false;

            //}
            resultExist = false;
            messageOperation = messageOperation + "4";
            textBox1.Text = messageOperation;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //clearStart = true;
            if (clearStart == true)
            {
                btnAdd.Enabled = true;
                btnDivide.Enabled = true;
                btnSubtract.Enabled = true;
                btnMultiply.Enabled = true;
              //  allow = false;
                start = false;
            }
            if (allow == true)
            {
                start = true;
                btnAdd.Enabled = false;
                btnDivide.Enabled = false;
                btnSubtract.Enabled = false;
                btnMultiply.Enabled = false;
            }
            if (start == true)
            {
                btnResult.Enabled = true;
            }
            else
            {
                btnResult.Enabled = false;
            }
            resultExist = false;
            messageOperation = messageOperation + "5";
            textBox1.Text = messageOperation;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            clearStart = true;
            if (clearStart == true)
            {
                btnAdd.Enabled = true;
                btnDivide.Enabled = true;
                btnSubtract.Enabled = true;
                btnMultiply.Enabled = true;
              //  allow = false;
                start = false;
            }
            if (allow == true)
            {
                start = true;
                btnAdd.Enabled = false;
                btnDivide.Enabled = false;
                btnSubtract.Enabled = false;
                btnMultiply.Enabled = false;
            }
            if (start == true)
            {
                btnResult.Enabled = true;
            }
            else
            {
                btnResult.Enabled = false;
            }
            //if (retour == true)
            //{
            //    btnAdd.Enabled = true;
            //    btnDivide.Enabled = true;
            //    btnSubtract.Enabled = true;
            //    btnMultiply.Enabled = true;
            //    btnResult.Enabled = false;

            //}
            resultExist = false;
            messageOperation = messageOperation + "6";
            textBox1.Text = messageOperation;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            clearStart = true;
            if (clearStart == true)
            {
                btnAdd.Enabled = true;
                btnDivide.Enabled = true;
                btnSubtract.Enabled = true;
                btnMultiply.Enabled = true;
             //   allow = false;
                start = false;
            }
            if (allow == true)
            {
                start = true;
                btnAdd.Enabled = false;
                btnDivide.Enabled = false;
                btnSubtract.Enabled = false;
                btnMultiply.Enabled = false;
            }
            if (start == true)
            {
                btnResult.Enabled = true;
            }
            else
            {
                btnResult.Enabled = false;
            }
            //if (retour == true)
            //{
            //    btnAdd.Enabled = true;
            //    btnDivide.Enabled = true;
            //    btnSubtract.Enabled = true;
            //    btnMultiply.Enabled = true;
            //    btnResult.Enabled = false;

            //}
            resultExist = false;
            messageOperation = messageOperation + "7";
            textBox1.Text = messageOperation;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            clearStart = true;
            if (clearStart == true)
            {
                btnAdd.Enabled = true;
                btnDivide.Enabled = true;
                btnSubtract.Enabled = true;
                btnMultiply.Enabled = true;
               // allow = false;
                start = false;
            }
            if (allow == true)
            {
                start = true;
                btnAdd.Enabled = false;
                btnDivide.Enabled = false;
                btnSubtract.Enabled = false;
                btnMultiply.Enabled = false;

            }
            if (start == true)
            {
                btnResult.Enabled = true;
            }
            else
            {
                btnResult.Enabled = false;
            }
        
            resultExist = false;
            messageOperation = messageOperation + "8";
            textBox1.Text = messageOperation;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            clearStart = true;
            if (clearStart == true)
            {
                btnAdd.Enabled = true;
                btnDivide.Enabled = true;
                btnSubtract.Enabled = true;
                btnMultiply.Enabled = true;
              //  allow = false;
                start = false;
            }
            if (allow == true)
            {
                start = true;
                btnAdd.Enabled = false;
                btnDivide.Enabled = false;
                btnSubtract.Enabled = false;
                btnMultiply.Enabled = false;
            }
            if (start == true)
            {
                btnResult.Enabled = true;
            }
            else
            {
                btnResult.Enabled = false;
            }
        
            resultExist = false;
            messageOperation = messageOperation + "9";
            textBox1.Text = messageOperation;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            clearStart = true;
            if (clearStart == true)
            {
                btnAdd.Enabled = true;
                btnDivide.Enabled = true;
                btnSubtract.Enabled = true;
                btnMultiply.Enabled = true;
             //   allow = false;
                start = false;
            }
            if (allow == true)
            {
                start = true;
                btnAdd.Enabled = false;
                btnDivide.Enabled = false;
                btnSubtract.Enabled = false;
                btnMultiply.Enabled = false;
            }   

        
            if (start == true)
            {
                btnResult.Enabled = true;
            }
            else
            {
                btnResult.Enabled = false;
            }
            resultExist = false;
            messageOperation = messageOperation + "0";
            textBox1.Text = messageOperation;
        }

        private void btndecimal_Click(object sender, EventArgs e)
        {
            resultExist = false;
            messageOperation = messageOperation + ".";
            dot = true;
            if (dot==true)
            {
                btndecimal.Enabled = false ;
            }
            else
            {
                btndecimal.Enabled = true ;
            }
            textBox1.Text = messageOperation;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Calculator obj = new Calculator();
            if (resultExist==true)
            {
                messageOperation= Convert.ToString(result);
            }
            dot = false;
            messageOperation = messageOperation + "+";
            oper = true;
            if (oper == true)
            {
                btnAdd.Enabled = false ;
                btnDivide.Enabled = false;
                btnSubtract.Enabled = false;
                btnMultiply.Enabled = false;
                btndecimal.Enabled = true;
               // btnResult.Enabled = true ;
            }
            textBox1.Text = messageOperation;
            sign = '+';
            allow = true;
            start = true;
            //  result = obj.Add(textBox1);
        }
            

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Calculator obj = new Calculator();
            if (resultExist == true)
            {
                messageOperation = Convert.ToString(result);
            }
            dot = false;
            messageOperation = messageOperation + "-";
            oper = true;
            if (oper == true)
            {
                btnAdd.Enabled = false;
                btnDivide.Enabled = false;
                btnSubtract.Enabled = false;
                btnMultiply.Enabled = false;
                btndecimal.Enabled = true;
              //  btnResult.Enabled = true;
            }
            textBox1.Text = messageOperation;
            sign = '-';
            allow = true;
        }
        

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            
            Calculator obj = new Calculator();
            if (resultExist == true)
            {
                messageOperation = Convert.ToString(result);
            }
            dot = false;
            messageOperation = messageOperation + "*";
            oper = true;
            if (oper == true)
            {
                btnAdd.Enabled = false;
                btnDivide.Enabled = false;
                btnSubtract.Enabled = false;
                btnMultiply.Enabled = false;
                btndecimal.Enabled = true;
               // btnResult.Enabled = true;
            }
            textBox1.Text = messageOperation;
            sign = '*';
            allow=true;
            //textBox1.Text = messageOperation + (Convert.ToString(result));
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Calculator obj = new Calculator();
            if (resultExist == true)
            {
                messageOperation = Convert.ToString(result);
            }
            dot = false;
            messageOperation = messageOperation + "/";
            oper = true;
            if (oper == true)
            {
                btnAdd.Enabled = false;
                btnDivide.Enabled = false;
                btnSubtract.Enabled = false;
                btnMultiply.Enabled = false;
                button10.Enabled = false;
                btndecimal.Enabled = true;
               // btnResult.Enabled = true;
            }
            textBox1.Text = messageOperation;
            sign = '/';
            allow = true;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Calculator obj = new Calculator();
            //oper = true;
            allow = false;
            if (oper == true)
            {
                btnAdd.Enabled = true;
                btnDivide.Enabled = true;
                btnSubtract.Enabled = true;
                btnMultiply.Enabled = true;
            }
            btnResult.Enabled = false;
            button10.Enabled = true;
            // textBox1.Text=messageOperation;
            //textBox1.Text = messageOperation;
            if (sign == '+')
            {
                result = obj.Add(textBox1);
            }
            if (sign == '-')
            {
                result = obj.Subtract(textBox1);
            }
            if (sign == '*')
            {
                result = obj.Multiply(textBox1);
            }
            if (sign == '/')
            {
                result = obj.Divide(textBox1);
            }
            
            messageOperation = messageOperation + "="+ (Convert.ToString(result));
            textBox1.Text = messageOperation;
            textBox2.Text=Convert.ToString(result);
            resultExist = true;
            messageOperation = "";
            try
            {
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);

                StreamWriter textOut = new StreamWriter(fs);



                textOut.Write(textBox1.Text+"\n");



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
            retour = true;
           
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {
            btnResult.Enabled = false;
            Calculator obj = new Calculator();
            if (start ==true)
            {
                btnResult.Enabled = true;
            }

            btnAdd.Enabled = false;
            btnDivide.Enabled = false;
            btnSubtract.Enabled = false;
            btnMultiply.Enabled = false;
            btnResult.Enabled = false;
            allow = false;
           
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            messageOperation = "";
            textBox1.Text= messageOperation;
            textBox2.Text=messageOperation;
            btnAdd.Enabled = false;
            btnDivide.Enabled = false;
            btnSubtract.Enabled = false;
            btnMultiply.Enabled = false;
            btnResult.Enabled = false;
            allow = false;
            clearStart = true;// a boolean to help enabling the operator button only if we click number
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
