namespace VehicleInventory
{
    partial class VehicleInventoryForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabNewVehicleForm = new TabControl();
            tabNewVehicle = new TabPage();
            btnAdd = new Button();
            cbxType = new ComboBox();
            txbResults = new TextBox();
            txbVIN = new TextBox();
            txbLicense = new TextBox();
            lblType = new Label();
            lblVIn = new Label();
            lblLicense = new Label();
            lblNewVehicleForm = new Label();
            tabInventory = new TabPage();
            txbSummary = new TextBox();
            lbInventory = new ListBox();
            tabNewVehicleForm.SuspendLayout();
            tabNewVehicle.SuspendLayout();
            tabInventory.SuspendLayout();
            SuspendLayout();
            // 
            // tabNewVehicleForm
            // 
            tabNewVehicleForm.Alignment = TabAlignment.Right;
            tabNewVehicleForm.Controls.Add(tabNewVehicle);
            tabNewVehicleForm.Controls.Add(tabInventory);
            tabNewVehicleForm.Location = new Point(12, 3);
            tabNewVehicleForm.Multiline = true;
            tabNewVehicleForm.Name = "tabNewVehicleForm";
            tabNewVehicleForm.SelectedIndex = 0;
            tabNewVehicleForm.Size = new Size(450, 450);
            tabNewVehicleForm.TabIndex = 0;
            // 
            // tabNewVehicle
            // 
            tabNewVehicle.Controls.Add(btnAdd);
            tabNewVehicle.Controls.Add(cbxType);
            tabNewVehicle.Controls.Add(txbResults);
            tabNewVehicle.Controls.Add(txbVIN);
            tabNewVehicle.Controls.Add(txbLicense);
            tabNewVehicle.Controls.Add(lblType);
            tabNewVehicle.Controls.Add(lblVIn);
            tabNewVehicle.Controls.Add(lblLicense);
            tabNewVehicle.Controls.Add(lblNewVehicleForm);
            tabNewVehicle.Location = new Point(4, 4);
            tabNewVehicle.Name = "tabNewVehicle";
            tabNewVehicle.Padding = new Padding(3);
            tabNewVehicle.Size = new Size(419, 442);
            tabNewVehicle.TabIndex = 0;
            tabNewVehicle.Text = "New Vehicle Form";
            tabNewVehicle.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(165, 234);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbxType
            // 
            cbxType.FormattingEnabled = true;
            cbxType.Items.AddRange(new object[] { "Sedan", "Truck" });
            cbxType.Location = new Point(154, 191);
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(121, 23);
            cbxType.TabIndex = 7;
            cbxType.Text = "Sedan";
            // 
            // txbResults
            // 
            txbResults.Location = new Point(52, 274);
            txbResults.Multiline = true;
            txbResults.Name = "txbResults";
            txbResults.ReadOnly = true;
            txbResults.Size = new Size(307, 124);
            txbResults.TabIndex = 6;
            // 
            // txbVIN
            // 
            txbVIN.Location = new Point(154, 160);
            txbVIN.Name = "txbVIN";
            txbVIN.Size = new Size(100, 23);
            txbVIN.TabIndex = 5;
            // 
            // txbLicense
            // 
            txbLicense.Location = new Point(154, 124);
            txbLicense.Name = "txbLicense";
            txbLicense.Size = new Size(100, 23);
            txbLicense.TabIndex = 4;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(52, 194);
            lblType.Name = "lblType";
            lblType.Size = new Size(32, 15);
            lblType.TabIndex = 3;
            lblType.Text = "Type";
            // 
            // lblVIn
            // 
            lblVIn.AutoSize = true;
            lblVIn.Location = new Point(52, 163);
            lblVIn.Name = "lblVIn";
            lblVIn.Size = new Size(26, 15);
            lblVIn.TabIndex = 2;
            lblVIn.Text = "VIN";
            // 
            // lblLicense
            // 
            lblLicense.AutoSize = true;
            lblLicense.Location = new Point(52, 127);
            lblLicense.Name = "lblLicense";
            lblLicense.Size = new Size(46, 15);
            lblLicense.TabIndex = 1;
            lblLicense.Text = "License";
            // 
            // lblNewVehicleForm
            // 
            lblNewVehicleForm.AutoSize = true;
            lblNewVehicleForm.Location = new Point(154, 51);
            lblNewVehicleForm.Name = "lblNewVehicleForm";
            lblNewVehicleForm.Size = new Size(102, 15);
            lblNewVehicleForm.TabIndex = 0;
            lblNewVehicleForm.Text = "New Vehicle Form";
            // 
            // tabInventory
            // 
            tabInventory.Controls.Add(txbSummary);
            tabInventory.Controls.Add(lbInventory);
            tabInventory.Location = new Point(4, 4);
            tabInventory.Name = "tabInventory";
            tabInventory.Padding = new Padding(3);
            tabInventory.Size = new Size(419, 442);
            tabInventory.TabIndex = 1;
            tabInventory.Text = "Inventory List";
            tabInventory.UseVisualStyleBackColor = true;
            // 
            // txbSummary
            // 
            txbSummary.Location = new Point(36, 345);
            txbSummary.Multiline = true;
            txbSummary.Name = "txbSummary";
            txbSummary.ReadOnly = true;
            txbSummary.Size = new Size(345, 78);
            txbSummary.TabIndex = 1;
            // 
            // lbInventory
            // 
            lbInventory.FormattingEnabled = true;
            lbInventory.Location = new Point(36, 15);
            lbInventory.Name = "lbInventory";
            lbInventory.Size = new Size(345, 304);
            lbInventory.TabIndex = 0;
            lbInventory.MouseDoubleClick += lbInventory_MouseDoubleClick;
            // 
            // VehicleInventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 466);
            Controls.Add(tabNewVehicleForm);
            Name = "VehicleInventoryForm";
            Text = "Form1";
            tabNewVehicleForm.ResumeLayout(false);
            tabNewVehicle.ResumeLayout(false);
            tabNewVehicle.PerformLayout();
            tabInventory.ResumeLayout(false);
            tabInventory.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabNewVehicleForm;
        private TabPage tabNewVehicle;
        private TabPage tabInventory;
        private Label lblType;
        private Label lblVIn;
        private Label lblLicense;
        private Label lblNewVehicleForm;
        private ComboBox cbxType;
        private TextBox txbResults;
        private TextBox txbVIN;
        private TextBox txbLicense;
        private TextBox txbSummary;
        private ListBox lbInventory;
        private Button btnAdd;
    }
}
