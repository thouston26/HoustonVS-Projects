using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Materials_List_Estimator
{
    public partial class Estimator : Form
    {
        DataTable table;
        public Estimator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initializes table
            table = new DataTable();
            table.Columns.Add("Category", typeof(String));
            table.Columns.Add("Name", typeof(String));
            table.Columns.Add("Material", typeof(String));
            table.Columns.Add("Price Per Unit", typeof(Double));
            table.Columns.Add("Quantity", typeof(Double));
            table.Columns.Add("Units", typeof(String));
            table.Columns.Add("Total", typeof(Double));
            table.Columns.Add("Description", typeof(String));

            dataEstimator.DataSource = table;
            dataEstimator.Columns["Description"].Width = 428;//Stops last column at end of table
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Check for valid values in the text fields
            if (txtName.Text == null || txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Name field is empty");
                return;
            }
            if (txtMaterial.Text == null || txtMaterial.Text.Trim().Length == 0)
            {
                MessageBox.Show("Material field is empty");
                return;
            }
            if (txtQuantity.Text == null || txtQuantity.Text.Trim().Length == 0)
            {
                MessageBox.Show("Quantity field is empty");
                return;
            }
            if (txtPPU.Text == null || txtPPU.Text.Trim().Length == 0)
            {
                MessageBox.Show("Price per unit field is empty");
                return;
            }

            //calculates the total from Quantity and Price Per Unit
            double numTotal;
            double numQuantity;
            double numPPU;
            if (double.TryParse(txtQuantity.Text, out numQuantity) == false)
            {
                MessageBox.Show("Quantity field is not valid.");
                return;
            }
            if (double.TryParse(txtPPU.Text, out numPPU) == false)
            {
                MessageBox.Show("Price per unit field is not valid.");
                return;
            }
            numPPU = double.Parse(txtPPU.Text);
            numTotal = numQuantity * numPPU;

            //Adds all the columns to the table
            table.Rows.Add(cmboCategory.Text, txtName.Text, txtMaterial.Text, txtPPU.Text, txtQuantity.Text, cmboUnits.Text, numTotal, txtDescription.Text);

            //Clears all the buttons and drop downs
            txtName.Clear();
            txtDescription.Clear();
            txtMaterial.Clear();
            txtPPU.Clear();
            txtQuantity.Clear();
            cmboCategory.ResetText();
            cmboUnits.ResetText();

            txtTotal_TextChanged(sender, e);
        }

        private void btnClearbox_Click(object sender, EventArgs e)
        {
            //Clears all the buttons and drop downs
            txtName.Clear();
            txtDescription.Clear();
            txtMaterial.Clear();
            txtPPU.Clear();
            txtQuantity.Clear();
            cmboCategory.ResetText();
            cmboUnits.ResetText();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Allows the editing of selected rows in the table
            int index = dataEstimator.CurrentCell.RowIndex;

            if (index > -1)
            {
                cmboCategory.Text = table.Rows[index].ItemArray[0].ToString();
                txtName.Text = table.Rows[index].ItemArray[1].ToString();
                txtMaterial.Text = table.Rows[index].ItemArray[2].ToString();
                txtPPU.Text = table.Rows[index].ItemArray[3].ToString();
                txtQuantity.Text = table.Rows[index].ItemArray[4].ToString();
                cmboUnits.Text = table.Rows[index].ItemArray[5].ToString();
                txtDescription.Text = table.Rows[index].ItemArray[7].ToString();
            }
            btnDelete_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Allows you to delete rows in a table
            int index = dataEstimator.CurrentCell.RowIndex;

            table.Rows[index].Delete();
            txtTotal_TextChanged(sender, e);
        }

        private void btnClearlist_Click(object sender, EventArgs e)
        {
            //Remove everything from the list
            table.Rows.Clear();

            txtTotal.Text = "0";
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            //Opens the calculator form
            Form formCalculator = new Calculator();
            formCalculator.Show();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                StreamReader file = new StreamReader(filename);

                string line = file.ReadLine();
                do
                {
                    DataRow row = table.NewRow();
                    string[] splitLine = line.Split(',');
                    for (int j = 0; j < splitLine.Length; j++)
                    {
                        row[j] = splitLine[j];
                    }
                    table.Rows.Add(row);
                    line = file.ReadLine();
                } while (line != null);

                file.Close();
            }
            txtTotal_TextChanged(sender, e);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                StreamWriter file = new StreamWriter(filename);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow row = table.Rows[i];
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        file.Write(row[j].ToString());

                        //Check to avoid putting a trailing comma at the end of the row
                        if (j + 1 < table.Columns.Count)
                        {
                            file.Write(",");
                        }
                    }

                    file.Write("\n");
                }

                file.Close();
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

            double Total = 0;

            for (int i = 0; i < table.Rows.Count; i++)
                Total = (double)table.Rows[i][6] + Total;

            txtTotal.Text = Total.ToString();
        }
    }
}
