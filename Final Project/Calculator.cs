using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    internal class Calculator
    {
        private decimal currentValue;
        private decimal operand1=0;
        private decimal operand2=0;
        private string op;

        public decimal CurrentValue { get { return currentValue; } }
        public decimal Operand1 { get { return operand1; } }
        public decimal Operand2 { get { return operand2; } }
        public string OP { get { return op; } }

        public Calculator() { }
        public Calculator(decimal currentValue, decimal operand1, decimal operand2, string op)
        {
            currentValue = this.currentValue;
            operand1 = this.operand1;
            operand2 = this.operand2;
            op = this.op;
        }

        
        public decimal Add(TextBox txt)
        {
            string display = txt.Text;
            string[] numbers = display.Split('+');
            this.operand1 = Convert.ToDecimal(numbers[0]);
            this.operand2 = Convert.ToDecimal(numbers[1]);
            this.currentValue = this.operand1 + this.operand2;
            //string display = txt.Text;
            //this.operand1 = Convert.ToDecimal(display);
            //this.currentValue = operand1;
            //this.op = "+";
            this.operand1 = this.currentValue;
            return currentValue;
        }

        public decimal Divide(TextBox txt)
        {
            string display = txt.Text;
            string[] numbers = display.Split('/');
            this.operand1 = Convert.ToDecimal(numbers[0]);
            this.operand2 = Convert.ToDecimal(numbers[1]);
            this.currentValue = this.operand1 / this.operand2;
            //string display = txt.Text;
            //this.operand1 = Convert.ToDecimal(display);
            //this.currentValue = operand1;
            //this.op = "+";
            this.operand1 = this.currentValue;
            return currentValue;
        }
        public decimal Subtract(TextBox txt)
        {
            string display = txt.Text;
            string[] numbers = display.Split('-');
            this.operand1 = Convert.ToDecimal(numbers[0]);
            this.operand2 = Convert.ToDecimal(numbers[1]);
            this.currentValue = this.operand1 - this.operand2;
            //string display = txt.Text;
            //this.operand1 = Convert.ToDecimal(display);
            //this.currentValue = operand1;
            //this.op = "+";
            this.operand1 = this.currentValue;
            return currentValue;
        }
        public decimal Multiply(TextBox txt)
        {
            string display = txt.Text;
            string[] numbers = display.Split('*');
            this.operand1 = Convert.ToDecimal(numbers[0]);
            this.operand2 = Convert.ToDecimal(numbers[1]);
            this.currentValue = this.operand1 * this.operand2;
            //string display = txt.Text;
            //this.operand1 = Convert.ToDecimal(display);
            //this.currentValue = operand1;
            //this.op = "+";
            this.operand1 = this.currentValue;
            return currentValue;
        }

        public decimal Equals(TextBox txt)
        {
            char operation=Convert.ToChar(this.op);
            string display = txt.Text;
            string[] numbers = display.Split(operation);
            this.operand2= Convert.ToDecimal(numbers[1]);
            if (operation=='+')
            {
                currentValue = currentValue + operand2;
            }
            if (operation == '-')
            {
                currentValue = currentValue - operand2;
            }
            if (operation=='*')
            {
                currentValue= currentValue * operand2;
            }
            if (operation=='/')
            {
                currentValue= currentValue/operand2;
            }

            numbers[0]=currentValue.ToString();
            return currentValue;

        }
     
        public void Clear()
        {
            operand1 = 0;
            operand2 = 0;
            currentValue = 0;
            op= " ";
        }
    }
}
