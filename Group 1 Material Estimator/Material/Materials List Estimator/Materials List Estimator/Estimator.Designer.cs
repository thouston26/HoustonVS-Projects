namespace Materials_List_Estimator
{
    partial class Estimator
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmboCategory = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblPPU = new System.Windows.Forms.Label();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.cmboUnits = new System.Windows.Forms.ComboBox();
            this.txtPPU = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClearbox = new System.Windows.Forms.Button();
            this.btnClearlist = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.dataEstimator = new System.Windows.Forms.DataGridView();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataEstimator)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(395, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(405, 44);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Materials List Estimator";
            // 
            // cmboCategory
            // 
            this.cmboCategory.FormattingEnabled = true;
            this.cmboCategory.Items.AddRange(new object[] {
            "Floors",
            "Walls",
            "Basement",
            "Roof",
            "Openings",
            "Electrical",
            "Other"});
            this.cmboCategory.Location = new System.Drawing.Point(15, 73);
            this.cmboCategory.Name = "cmboCategory";
            this.cmboCategory.Size = new System.Drawing.Size(121, 21);
            this.cmboCategory.TabIndex = 1;
            this.cmboCategory.Text = "Choose a Category";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(78, 109);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(1068, 20);
            this.txtDescription.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(154, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(157, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(370, 57);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(44, 13);
            this.lblMaterial.TabIndex = 7;
            this.lblMaterial.Text = "Material";
            // 
            // lblPPU
            // 
            this.lblPPU.AutoSize = true;
            this.lblPPU.Location = new System.Drawing.Point(728, 57);
            this.lblPPU.Name = "lblPPU";
            this.lblPPU.Size = new System.Drawing.Size(72, 13);
            this.lblPPU.TabIndex = 8;
            this.lblPPU.Text = "Price Per Unit";
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(373, 72);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(192, 20);
            this.txtMaterial.TabIndex = 3;
            // 
            // cmboUnits
            // 
            this.cmboUnits.FormattingEnabled = true;
            this.cmboUnits.Items.AddRange(new object[] {
            "Each",
            "LYDS",
            "SQYDS",
            "Feet",
            "SQFT",
            "Inches",
            "LBS",
            "Bales",
            "Gallons",
            "Grams",
            "KG"});
            this.cmboUnits.Location = new System.Drawing.Point(1029, 73);
            this.cmboUnits.Name = "cmboUnits";
            this.cmboUnits.Size = new System.Drawing.Size(117, 21);
            this.cmboUnits.TabIndex = 6;
            this.cmboUnits.Text = "Units";
            // 
            // txtPPU
            // 
            this.txtPPU.Location = new System.Drawing.Point(731, 73);
            this.txtPPU.Name = "txtPPU";
            this.txtPPU.Size = new System.Drawing.Size(123, 20);
            this.txtPPU.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(114, 146);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(212, 146);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClearbox
            // 
            this.btnClearbox.Location = new System.Drawing.Point(312, 146);
            this.btnClearbox.Name = "btnClearbox";
            this.btnClearbox.Size = new System.Drawing.Size(75, 23);
            this.btnClearbox.TabIndex = 15;
            this.btnClearbox.Text = "Clear boxes";
            this.btnClearbox.UseVisualStyleBackColor = true;
            this.btnClearbox.Click += new System.EventHandler(this.btnClearbox_Click);
            // 
            // btnClearlist
            // 
            this.btnClearlist.Location = new System.Drawing.Point(1071, 146);
            this.btnClearlist.Name = "btnClearlist";
            this.btnClearlist.Size = new System.Drawing.Size(75, 23);
            this.btnClearlist.TabIndex = 16;
            this.btnClearlist.Text = "Clear List";
            this.btnClearlist.UseVisualStyleBackColor = true;
            this.btnClearlist.Click += new System.EventHandler(this.btnClearlist_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(874, 57);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 17;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(877, 73);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(124, 20);
            this.txtQuantity.TabIndex = 5;
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(1039, 44);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(107, 23);
            this.btnCalculator.TabIndex = 19;
            this.btnCalculator.Text = "Cost Calculator";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // dataEstimator
            // 
            this.dataEstimator.AllowUserToAddRows = false;
            this.dataEstimator.AllowUserToDeleteRows = false;
            this.dataEstimator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEstimator.Location = new System.Drawing.Point(15, 175);
            this.dataEstimator.Name = "dataEstimator";
            this.dataEstimator.ReadOnly = true;
            this.dataEstimator.RowHeadersVisible = false;
            this.dataEstimator.RowHeadersWidth = 62;
            this.dataEstimator.Size = new System.Drawing.Size(1131, 309);
            this.dataEstimator.TabIndex = 20;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(15, 500);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 21;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(96, 500);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 22;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(970, 500);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(1021, 500);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(126, 20);
            this.txtTotal.TabIndex = 26;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Estimator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 539);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.dataEstimator);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnClearlist);
            this.Controls.Add(this.btnClearbox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPPU);
            this.Controls.Add(this.cmboUnits);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.lblPPU);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmboCategory);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Name = "Estimator";
            this.Text = "Materials List Estimator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEstimator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmboCategory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblPPU;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.ComboBox cmboUnits;
        private System.Windows.Forms.TextBox txtPPU;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClearbox;
        private System.Windows.Forms.Button btnClearlist;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.DataGridView dataEstimator;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

