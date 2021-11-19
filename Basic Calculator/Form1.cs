using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Define what happens when this button is clicked.
            double result = 0;

            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);

            result = num1 + num2;

            lblResult.Text = Convert.ToString(result);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            //Define what happens when this button is clicked.
            double result = 0;

            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);

            result = num1 - num2;

            lblResult.Text = Convert.ToString(result);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            //Define what happens when this button is clicked.
            double result = 0;

            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);

            result = num1 * num2;

            lblResult.Text = Convert.ToString(result);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            //Define what happens when this button is clicked.
            double result = 0;

            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);

            result = num1 / num2;

            lblResult.Text = Convert.ToString(result);
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            //Define what happens when this button is clicked.
            double result = 0;

            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);

            result = num1 % num2;

            lblResult.Text = Convert.ToString(result);
        }
    }
}
