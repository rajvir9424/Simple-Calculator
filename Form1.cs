using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCalculator
{
    public partial class Calculator : Form
    {
        Double value = 0;
        string operation = "";
        bool operator_preessed = false; 
        public Calculator()
        {
            InitializeComponent();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            if ((resulttext.Text == "0") || (operator_preessed))
            
                resulttext.Clear();


            operator_preessed = false;

            Button b = (Button)sender;
            resulttext.Text = resulttext.Text + b.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;      
            operation = b.Text;
            value = Double.Parse(resulttext.Text);
            operator_preessed = true;
            equation.Text = value + " " + operation;
        }

        private void btnequals_Click(object sender, EventArgs e)
        {
            
            equation.Text = "";
            switch (operation)
            {
                
                case "+":
                    resulttext.Text = (value + Double.Parse(resulttext.Text)).ToString();
                    break;
                case "-":
                    resulttext.Text = (value - Double.Parse(resulttext.Text)).ToString();
                    break;
                case "*":
                    resulttext.Text = (value * Double.Parse(resulttext.Text)).ToString();
                    break;
                case "/":
                    resulttext.Text = (value / Double.Parse(resulttext.Text)).ToString();
                    break;




                default:
                    break;

            }
           
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            resulttext.Text= "0";
        }

        private void buttonce_Click(object sender, EventArgs e)
        {
            resulttext.Text= "0";
            value = 0;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
       
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
