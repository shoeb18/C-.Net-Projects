using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        // Declaring variables for Calculations 

        double firstNumber; // for user input first Number
        double secondNumber; // for user input second Number
        double total;  // for store total value 
        char opera; // for operation selection
        bool isEqualButton = false; // for check condition


        // Define SetValue funtion for set user input number
        private void SetValue(string number)
        {
            // if input number appers no of times so concatinate that into previous one 
            if (displayBox.Text != "0")
            {
                displayBox.Text += number;
            }
            else 
            {
                displayBox.Text = number;
            }
        }


        // Calculation function to check which operation to have to execute
        // conform that using characters
        private void Calculation()
        {
            switch (opera)
            {
                case '+':
                    total = firstNumber + secondNumber;
                    break; 
                case '-':
                    total = firstNumber - secondNumber;
                    break; 
                case '*':
                    total = firstNumber * secondNumber;
                    break; 
                case '/':
                    total = firstNumber / secondNumber;
                    break;
            }

            // add total to the displayBox textbox
            displayBox.Text = total.ToString();
        }

        private void firstNumDisplayOp()
        {
            // this is function for display operands 
            displayOperation.Text = firstNumber.ToString() + opera;

            // if second number input so display this with concanicate the second number is also
            if (isEqualButton)
            {
                displayOperation.Text = firstNumber.ToString()+opera+secondNumber.ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetValue("1");
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            SetValue("2");
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            SetValue("3");

        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            SetValue("4");

        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            SetValue("5");

        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            SetValue("6");

        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            SetValue("7");

        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            SetValue("8");

        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            SetValue("9");

        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            SetValue("0");

        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            // Here we have to check is user input value valid or not 
            // if not so " pehli fursat me nikal error lekar! " 😂😂😂

            if (displayBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Invalid Operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // if user input value is correct getting input that
            // and perform operation
            secondNumber = Convert.ToDouble(displayBox.Text.Trim());

            isEqualButton = true;
            firstNumDisplayOp();

            // simply it check which operation have to calculate
            Calculation();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            // if input is empty so throws an error box 
            if (displayBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Invalid Operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //get user input string and convert into double
            // and store value in firstnumber variable
            firstNumber = Convert.ToDouble(displayBox.Text.Trim());

            // set the opera variable to '+' for plus operation
            opera = '+';
            // clear the displaybox text
            displayBox.Text = "";

            //display operands
            firstNumDisplayOp();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (displayBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Invalid Operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            firstNumber = Convert.ToDouble(displayBox.Text.Trim());
            opera = '-';
            displayBox.Text = "";
            firstNumDisplayOp();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (displayBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Invalid Operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            firstNumber = Convert.ToDouble(displayBox.Text.Trim());
            opera = '*';
            displayBox.Text = "";
            firstNumDisplayOp();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {

            if (displayBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Invalid Operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            firstNumber = Convert.ToDouble(displayBox.Text.Trim());
            opera = '/';
            displayBox.Text = "";
            firstNumDisplayOp();
        }

        private void squareButton_Click(object sender, EventArgs e)
        {

            //get user input string and convert into double
            firstNumber = Convert.ToDouble(displayBox.Text.Trim());

            // display the result of square of a number with the help of pow function in Math class 
            displayBox.Text = Math.Pow(firstNumber, 2).ToString();
            displayOperation.Text = "Square of "+firstNumber.ToString();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear button simply reset all variables and strings
            firstNumber = 0;
            secondNumber = 0;
            displayBox.Text = "";
            displayOperation.Text = "";
        }

        private void dotButton_Click(object sender, EventArgs e)
        {

            // if number is not contain . so we can use dot 
                if (!displayBox.Text.Contains("."))
                {
                    displayBox.Text += ".";
                }
            
        }

        private void sButton_Click(object sender, EventArgs e)
        {
            // this is me ok !
            displayOperation.Text = "Made by Shoeb";
           
        }
    }
}
