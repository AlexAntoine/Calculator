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
    public partial class frmCalculator : Form
    {
        Calculate cal = new Calculate();
        double first, second;

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            grpNormalFunctions.Visible = false;
            grpExtraFunctions.Visible = false;
            txtResult.Visible = false;

        }

        private void btnModulus_Click(object sender, EventArgs e)
        {

        }

        private void lblCalculator_Click(object sender, EventArgs e)
        {

        }

        private void grpNormalFunctions_Enter(object sender, EventArgs e)
        {
            
        }

        private void grpExtraFunctions_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (double.TryParse(txtInputFirstNumber.Text, out first) && double.TryParse(txtInputSecondNumber.Text, out second))
            {
                txtResult.Visible = true;
                txtResult.Text = cal.add(first, second);
              
            }
            else
            {
                MessageBox.Show("You input was invalid, please enter a number");
                txtInputFirstNumber.Clear();
                txtInputSecondNumber.Clear();
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

        }

        private void btnIntegerDivision_Click(object sender, EventArgs e)
        {

        }

        private void btnPercent_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInputFirstNumber.Clear();
            txtInputSecondNumber.Clear();
            txtResult.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtInputFirstNumber_TextChanged(object sender, EventArgs e)
        {

            if (txtInputFirstNumber.Text != "" && txtInputSecondNumber.Text != "")
            {
                grpNormalFunctions.Visible = true;
                grpExtraFunctions.Visible = true;
            }
        }

        private void txtInputSecondNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtInputFirstNumber.Text != "" && txtInputSecondNumber.Text != "")
            {
                grpNormalFunctions.Visible = true;
                grpExtraFunctions.Visible = true;
            }
                
           
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtInputFirstNumber.Text, out first) && double.TryParse(txtInputSecondNumber.Text, out second))
            {
                txtResult.Visible = true;
                txtResult.Text = cal.subtract(first, second);

            }
            else
            {
                MessageBox.Show("You input was invalid, please enter a number");
                txtInputFirstNumber.Clear();
                txtInputSecondNumber.Clear();
            }
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
