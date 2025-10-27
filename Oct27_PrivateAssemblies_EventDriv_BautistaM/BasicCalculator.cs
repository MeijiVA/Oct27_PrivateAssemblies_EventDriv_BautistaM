using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace Oct27_ClassLib_EventDriv_BautistaM
{
    public partial class BasicCalculator : Form
    {

        public BasicCalculator()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbxOperation.Text)
                {
                    case "+":
                        lblCompute.Text = "" + BasicComputation.Addition(float.Parse(txtNum1.Text), float.Parse(txtNum2.Text));
                        break;
                    case "-":
                        lblCompute.Text = "" + BasicComputation.Subtraction(float.Parse(txtNum1.Text), float.Parse(txtNum2.Text));
                        break;
                    case "*":
                        lblCompute.Text = "" + BasicComputation.Multiplication(float.Parse(txtNum1.Text), float.Parse(txtNum2.Text));
                        break;
                    case "/":
                        lblCompute.Text = "" + BasicComputation.Division(float.Parse(txtNum1.Text), float.Parse(txtNum2.Text));
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Exception Thrown");
            }

        }
    }
}
