namespace Materials_List_Estimator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCalcQuantity = new System.Windows.Forms.Label();
            this.lblMultiply = new System.Windows.Forms.Label();
            this.lblCalcPPU = new System.Windows.Forms.Label();
            this.lblCalcTotal = new System.Windows.Forms.Label();
            this.txtCalcQuantity = new System.Windows.Forms.TextBox();
            this.txtCalcPPU = new System.Windows.Forms.TextBox();
            this.txtCalcTotal = new System.Windows.Forms.TextBox();
            this.lblEqual = new System.Windows.Forms.Label();
            this.btnCalcCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCalcQuantity
            // 
            this.lblCalcQuantity.AutoSize = true;
            this.lblCalcQuantity.Location = new System.Drawing.Point(24, 23);
            this.lblCalcQuantity.Name = "lblCalcQuantity";
            this.lblCalcQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblCalcQuantity.TabIndex = 0;
            this.lblCalcQuantity.Text = "Quantity";
            // 
            // lblMultiply
            // 
            this.lblMultiply.AutoSize = true;
            this.lblMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiply.Location = new System.Drawing.Point(162, 45);
            this.lblMultiply.Name = "lblMultiply";
            this.lblMultiply.Size = new System.Drawing.Size(32, 31);
            this.lblMultiply.TabIndex = 1;
            this.lblMultiply.Text = "X";
            // 
            // lblCalcPPU
            // 
            this.lblCalcPPU.AutoSize = true;
            this.lblCalcPPU.Location = new System.Drawing.Point(233, 23);
            this.lblCalcPPU.Name = "lblCalcPPU";
            this.lblCalcPPU.Size = new System.Drawing.Size(72, 13);
            this.lblCalcPPU.TabIndex = 2;
            this.lblCalcPPU.Text = "Price Per Unit";
            // 
            // lblCalcTotal
            // 
            this.lblCalcTotal.AutoSize = true;
            this.lblCalcTotal.Location = new System.Drawing.Point(474, 23);
            this.lblCalcTotal.Name = "lblCalcTotal";
            this.lblCalcTotal.Size = new System.Drawing.Size(31, 13);
            this.lblCalcTotal.TabIndex = 3;
            this.lblCalcTotal.Text = "Total";
            // 
            // txtCalcQuantity
            // 
            this.txtCalcQuantity.Location = new System.Drawing.Point(27, 74);
            this.txtCalcQuantity.Name = "txtCalcQuantity";
            this.txtCalcQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtCalcQuantity.TabIndex = 4;
            // 
            // txtCalcPPU
            // 
            this.txtCalcPPU.Location = new System.Drawing.Point(236, 74);
            this.txtCalcPPU.Name = "txtCalcPPU";
            this.txtCalcPPU.Size = new System.Drawing.Size(100, 20);
            this.txtCalcPPU.TabIndex = 5;
            // 
            // txtCalcTotal
            // 
            this.txtCalcTotal.Location = new System.Drawing.Point(477, 74);
            this.txtCalcTotal.Name = "txtCalcTotal";
            this.txtCalcTotal.ReadOnly = true;
            this.txtCalcTotal.Size = new System.Drawing.Size(100, 20);
            this.txtCalcTotal.TabIndex = 6;
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqual.Location = new System.Drawing.Point(387, 45);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(30, 31);
            this.lblEqual.TabIndex = 7;
            this.lblEqual.Text = "=";
            // 
            // btnCalcCalculate
            // 
            this.btnCalcCalculate.Location = new System.Drawing.Point(477, 123);
            this.btnCalcCalculate.Name = "btnCalcCalculate";
            this.btnCalcCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalcCalculate.TabIndex = 8;
            this.btnCalcCalculate.Text = "Calculate";
            this.btnCalcCalculate.UseVisualStyleBackColor = true;
            this.btnCalcCalculate.Click += new System.EventHandler(this.btnCalcCalculate_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 165);
            this.Controls.Add(this.btnCalcCalculate);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.txtCalcTotal);
            this.Controls.Add(this.txtCalcPPU);
            this.Controls.Add(this.txtCalcQuantity);
            this.Controls.Add(this.lblCalcTotal);
            this.Controls.Add(this.lblCalcPPU);
            this.Controls.Add(this.lblMultiply);
            this.Controls.Add(this.lblCalcQuantity);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalcQuantity;
        private System.Windows.Forms.Label lblMultiply;
        private System.Windows.Forms.Label lblCalcPPU;
        private System.Windows.Forms.Label lblCalcTotal;
        private System.Windows.Forms.TextBox txtCalcQuantity;
        private System.Windows.Forms.TextBox txtCalcPPU;
        private System.Windows.Forms.TextBox txtCalcTotal;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.Button btnCalcCalculate;
    }
}