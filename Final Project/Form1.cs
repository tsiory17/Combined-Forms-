using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Tsiory Rakotoarimanana
namespace Final_Project
{
    public partial class frm23Dashboard : Form
    {
        public frm23Dashboard()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMax obj = new frmMax();
            //obj.Show();
            obj.ShowDialog();
        }

        private void btn649_Click(object sender, EventArgs e)
        {
            frm649 obj = new frm649();
            //obj.Show();
            obj.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmMoneyExchanges obj= new FrmMoneyExchanges();
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTemp obj = new frmTemp();    
            obj.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void frm23Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmCalculator obj = new FrmCalculator();
            obj.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            IPValidator obj = new IPValidator();
            obj.ShowDialog();
        }
    }
}
