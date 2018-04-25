using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW02_IslasAngel
{
    public partial class HW02_IslasAngel : Form
    {

        public HW02_IslasAngel()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)


        {
            //Declaring value of coin

            decimal dollar = 1;
            decimal halfDollar = .50m;
            decimal quarter = .25m;
            decimal dime = .10m;
            decimal cent = .01m;
            decimal amountDue;
            decimal tenderedAmount;
            decimal changeDue;


            //Calculate change due to customer
            amountDue = decimal.Parse(amountDueTextBox.Text);
            tenderedAmount = decimal.Parse(tenderedAmountTextBox.Text);
            changeDue = tenderedAmount - amountDue;




            //Finding out how many dollars are in changeDue
            decimal dollarMath = changeDue / dollar;
            int numOfDollars = (int)dollarMath;

            //Getting the remainer amount to figure out how much is left after substracting dollars
            decimal remainerAfterDollars = changeDue % dollar;

            dollarsLabel2.Text = numOfDollars.ToString();





            //Finding out how many halfDollars are in changeDue
            decimal halfDollarMath = remainerAfterDollars / halfDollar;
            int numOfHalfDollar = (int)halfDollarMath;

            //Getting the remainer amount to figure out how much is left after substracting halfDollars
            decimal remainerAfterHalfDollars = remainerAfterDollars % halfDollar;


            halfDollarsLabel2.Text = numOfHalfDollar.ToString();



            //Finding out how many quarters are in changeDue
            decimal quarterMath = remainerAfterHalfDollars / quarter;
            int numOfQuarters = (int)quarterMath;

            //Getting the remainer amount to figure out how much is left after substracting quarters
            decimal remainerAfterQuarters = remainerAfterHalfDollars % quarter;


           quartersLabel2.Text = numOfQuarters.ToString();



            //Finding out how many dimes are in the remainerAfterQuarters
            decimal dimeMath = remainerAfterQuarters / dime;
            int numOfDimes = (int)dimeMath;
            //Getting the remainer amount to figure out whats left after substracting dimes
            decimal remainerAfterDimes = remainerAfterQuarters % dime;


            dimesLabel2.Text = numOfDimes.ToString();



            // Finding out how many pennies are in the remainerAfterNickles
            decimal pennyMath = remainerAfterDimes / cent;
            int numOfPennies = (int)pennyMath;


            centsLabel2.Text = numOfPennies.ToString();




        }


        //Clear text boxes
        private void clearButton_Click(object sender, EventArgs e)
        {

            amountDueTextBox.Text = "";
            tenderedAmountTextBox.Text = "";
            dollarsLabel2.Text = "";
            halfDollarsLabel2.Text = "";
            quartersLabel2.Text = "";
            dimesLabel2.Text = "";
            centsLabel2.Text = "";

            

        }

        //Close form
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
    


