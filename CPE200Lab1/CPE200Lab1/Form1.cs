using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        double Result;
        public Form1()
        
        {
            InitializeComponent();

        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
        }
       
     
        private void btnDot_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = lblDisplay.Text + ".";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        { 
            double SecondNumber;
            
            string Ans;

            SecondNumber = Convert.ToDouble(lblDisplay.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                {
                    if (Result < 99999999)
                    {
                        lblDisplay.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                    }
                    else
                    {
                        lblDisplay.Text = "Undefined";
                    }
                }
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
              
                    lblDisplay.Text = Convert.ToString(Result);
                    FirstNumber = Result;
               
            }
            if (Operation == "X")
            {
                Result = (FirstNumber * SecondNumber);
                if (Result < 99999999)
                {
                    lblDisplay.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                else
                {
                    lblDisplay.Text = "Undefined";
                }
            }
            if (Operation == "÷")
            {
                if (SecondNumber == 0)
                {
                    lblDisplay.Text = "∞";

                }
                else
                {
                        Result = (FirstNumber / SecondNumber);
                        lblDisplay.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                }
            }
            Ans = Convert.ToString(Result);
            
            if (Ans.Length > 8 && Result>99999999)
            {
                lblDisplay.Text = "Undefined"; 
            }
            else
            {
                Result = Math.Round(Result, 6);
                lblDisplay.Text = Convert.ToString(Result);
            }
        }

        private void ClickNum(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length < 8) { 
            if (lblDisplay.Text == "0" && lblDisplay.Text != null)
            {
                lblDisplay.Text = ((Button)sender).Text;
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + ((Button)sender).Text;
            }
        }
        }

        
        
        private void ClickOperation(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = "0";
            Operation = ((Button)sender).Text;
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            double Result;
            
            if (lblDisplay.Text == "0")
            {
                Result = FirstNumber * FirstNumber / 100;
                lblDisplay.Text = Convert.ToString(Result);
            }
            else
            {
                double SecondNumber = Convert.ToDouble(lblDisplay.Text);
                Result = FirstNumber * SecondNumber / 100;
                lblDisplay.Text = Convert.ToString(Result);
            }
        }
    }
}
    


