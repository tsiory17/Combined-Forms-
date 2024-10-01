using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Tsiory Rakotoarimanana
namespace Final_Project
{
    internal class Lotto
    {
        private int Randomnumbers;

        public int RandomNumbers { get { return Randomnumbers; } }

        public Lotto()
        {

        }
        public Lotto(int randomNumbers)
        {
            this.Randomnumbers = randomNumbers;
        }

        string dir = @".\Final Project\";
        string path = @".\Final Project\LottoNbrs.txt";
        FileStream fs = null;


        public string WinningNumbers(int numberWithoutExtra,int minLimitOfRandom,int maxLimitOfRandom)
        {
            Random random = new Random();
            int[] randomNumbers = new int[numberWithoutExtra];
            string result = "";
            int lottoNumber;

            for (int numberIndex = 0; numberIndex < numberWithoutExtra; numberIndex++)
            {
                do
                {
                    lottoNumber = random.Next(minLimitOfRandom, maxLimitOfRandom);
                }
                while (randomNumbers.Contains(lottoNumber));
                randomNumbers[numberIndex] = lottoNumber;
                result = result + randomNumbers[numberIndex].ToString()+"\t";
            }
              
            int extra;
            do
            {
                extra = random.Next(minLimitOfRandom, maxLimitOfRandom);
            } while (randomNumbers.Contains(extra));
            
            string finalResult = result + extra.ToString();


            return finalResult;
        }

     public void Display (string toDisplay, TextBox winningNumbers)
        {
            winningNumbers.Text = toDisplay;
        }

        public void WriteTextFile()
        {

        } 
    }
}
