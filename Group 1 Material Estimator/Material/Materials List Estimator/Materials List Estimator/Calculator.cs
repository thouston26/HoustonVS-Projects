using System;
using System.Windows.Forms;

namespace Materials_List_Estimator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnCalcCalculate_Click(object sender, EventArgs e)
        {
            //Aquires numbers and multiples the cost and quantity to get the total cost
            double numCalcTotal;
            double numCalcQuantity;
            double numCalcPPU;
            if (txtCalcPPU.Text == null || txtCalcPPU.Text.Trim().Length == 0)
            {
                MessageBox.Show("Price per unit field is empty");
                return;
            }
            if (txtCalcQuantity.Text == null || txtCalcQuantity.Text.Trim().Length == 0)
            {
                MessageBox.Show("Quantity field is empty");
                return;
            }
            if (double.TryParse(txtCalcQuantity.Text, out numCalcQuantity) == false)
            {
                MessageBox.Show("Quantity field is not valid.");
                return;
            }
            if (double.TryParse(txtCalcPPU.Text, out numCalcPPU) == false)
            {
                MessageBox.Show("Price per unit field is not valid.");
                return;
            }
            numCalcQuantity = double.Parse(txtCalcQuantity.Text);
            numCalcPPU = double.Parse(txtCalcPPU.Text);
            numCalcTotal = numCalcQuantity * numCalcPPU;
            txtCalcTotal.Text = numCalcTotal.ToString();
        }
    }
}
