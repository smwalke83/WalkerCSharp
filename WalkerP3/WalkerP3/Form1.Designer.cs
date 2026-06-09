namespace WalkerP3
{
    partial class Form1
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
            lblOrderNumber = new Label();
            txbOrderNumber = new TextBox();
            txbNumberOfItems = new TextBox();
            lblNumberOfItems = new Label();
            gbxItemType = new GroupBox();
            rbtnPen = new RadioButton();
            rbtnUSB = new RadioButton();
            rbtnMug = new RadioButton();
            lblTextToEngrave = new Label();
            txbTextToEngrave = new TextBox();
            cbxHasLogo = new CheckBox();
            lblNumberOfColors = new Label();
            txbNumberOfColors = new TextBox();
            btnSubmit = new Button();
            txbResults = new TextBox();
            lblResults = new Label();
            btnClear = new Button();
            gbxItemType.SuspendLayout();
            SuspendLayout();
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.AutoSize = true;
            lblOrderNumber.Location = new Point(12, 36);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new Size(84, 15);
            lblOrderNumber.TabIndex = 0;
            lblOrderNumber.Text = "Order Number";
            // 
            // txbOrderNumber
            // 
            txbOrderNumber.Location = new Point(128, 33);
            txbOrderNumber.Name = "txbOrderNumber";
            txbOrderNumber.Size = new Size(100, 23);
            txbOrderNumber.TabIndex = 1;
            txbOrderNumber.Text = "0";
            // 
            // txbNumberOfItems
            // 
            txbNumberOfItems.Location = new Point(128, 72);
            txbNumberOfItems.Name = "txbNumberOfItems";
            txbNumberOfItems.Size = new Size(100, 23);
            txbNumberOfItems.TabIndex = 2;
            txbNumberOfItems.Text = "0";
            // 
            // lblNumberOfItems
            // 
            lblNumberOfItems.AutoSize = true;
            lblNumberOfItems.Location = new Point(12, 75);
            lblNumberOfItems.Name = "lblNumberOfItems";
            lblNumberOfItems.Size = new Size(97, 15);
            lblNumberOfItems.TabIndex = 3;
            lblNumberOfItems.Text = "Number of Items";
            // 
            // gbxItemType
            // 
            gbxItemType.Controls.Add(rbtnPen);
            gbxItemType.Controls.Add(rbtnUSB);
            gbxItemType.Controls.Add(rbtnMug);
            gbxItemType.Location = new Point(128, 114);
            gbxItemType.Name = "gbxItemType";
            gbxItemType.Size = new Size(100, 100);
            gbxItemType.TabIndex = 4;
            gbxItemType.TabStop = false;
            gbxItemType.Text = "Item Type";
            // 
            // rbtnPen
            // 
            rbtnPen.AutoSize = true;
            rbtnPen.Location = new Point(6, 75);
            rbtnPen.Name = "rbtnPen";
            rbtnPen.Size = new Size(45, 19);
            rbtnPen.TabIndex = 7;
            rbtnPen.Text = "Pen";
            rbtnPen.UseVisualStyleBackColor = true;
            // 
            // rbtnUSB
            // 
            rbtnUSB.AutoSize = true;
            rbtnUSB.Location = new Point(6, 22);
            rbtnUSB.Name = "rbtnUSB";
            rbtnUSB.Size = new Size(46, 19);
            rbtnUSB.TabIndex = 5;
            rbtnUSB.Text = "USB";
            rbtnUSB.UseVisualStyleBackColor = true;
            // 
            // rbtnMug
            // 
            rbtnMug.AutoSize = true;
            rbtnMug.Checked = true;
            rbtnMug.Location = new Point(6, 47);
            rbtnMug.Name = "rbtnMug";
            rbtnMug.Size = new Size(50, 19);
            rbtnMug.TabIndex = 6;
            rbtnMug.TabStop = true;
            rbtnMug.Text = "Mug";
            rbtnMug.UseVisualStyleBackColor = true;
            // 
            // lblTextToEngrave
            // 
            lblTextToEngrave.AutoSize = true;
            lblTextToEngrave.Location = new Point(12, 244);
            lblTextToEngrave.Name = "lblTextToEngrave";
            lblTextToEngrave.Size = new Size(120, 15);
            lblTextToEngrave.TabIndex = 5;
            lblTextToEngrave.Text = "Text to engrave/print:";
            // 
            // txbTextToEngrave
            // 
            txbTextToEngrave.Location = new Point(12, 262);
            txbTextToEngrave.Multiline = true;
            txbTextToEngrave.Name = "txbTextToEngrave";
            txbTextToEngrave.Size = new Size(216, 45);
            txbTextToEngrave.TabIndex = 6;
            txbTextToEngrave.Text = "Hello, World!";
            // 
            // cbxHasLogo
            // 
            cbxHasLogo.AutoSize = true;
            cbxHasLogo.Location = new Point(134, 313);
            cbxHasLogo.Name = "cbxHasLogo";
            cbxHasLogo.Size = new Size(58, 19);
            cbxHasLogo.TabIndex = 7;
            cbxHasLogo.Text = "Logo?";
            cbxHasLogo.UseVisualStyleBackColor = true;
            cbxHasLogo.CheckedChanged += cbxHasLogo_CheckedChanged;
            // 
            // lblNumberOfColors
            // 
            lblNumberOfColors.AutoSize = true;
            lblNumberOfColors.Location = new Point(12, 348);
            lblNumberOfColors.Name = "lblNumberOfColors";
            lblNumberOfColors.Size = new Size(102, 15);
            lblNumberOfColors.TabIndex = 8;
            lblNumberOfColors.Text = "Number of Colors";
            lblNumberOfColors.Visible = false;
            // 
            // txbNumberOfColors
            // 
            txbNumberOfColors.Location = new Point(128, 345);
            txbNumberOfColors.Name = "txbNumberOfColors";
            txbNumberOfColors.Size = new Size(100, 23);
            txbNumberOfColors.TabIndex = 9;
            txbNumberOfColors.Text = "0";
            txbNumberOfColors.Visible = false;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(21, 380);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txbResults
            // 
            txbResults.Location = new Point(328, 136);
            txbResults.Multiline = true;
            txbResults.Name = "txbResults";
            txbResults.ReadOnly = true;
            txbResults.Size = new Size(416, 183);
            txbResults.TabIndex = 11;
            txbResults.Text = "Click Submit for results.";
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(494, 80);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(75, 15);
            lblResults.TabIndex = 12;
            lblResults.Text = "Order Details";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(153, 380);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(lblResults);
            Controls.Add(txbResults);
            Controls.Add(btnSubmit);
            Controls.Add(txbNumberOfColors);
            Controls.Add(lblNumberOfColors);
            Controls.Add(cbxHasLogo);
            Controls.Add(txbTextToEngrave);
            Controls.Add(lblTextToEngrave);
            Controls.Add(gbxItemType);
            Controls.Add(lblNumberOfItems);
            Controls.Add(txbNumberOfItems);
            Controls.Add(txbOrderNumber);
            Controls.Add(lblOrderNumber);
            Name = "Form1";
            Text = "Form1";
            gbxItemType.ResumeLayout(false);
            gbxItemType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderNumber;
        private TextBox txbOrderNumber;
        private TextBox txbNumberOfItems;
        private Label lblNumberOfItems;
        private GroupBox gbxItemType;
        private RadioButton rbtnUSB;
        private RadioButton rbtnMug;
        private RadioButton rbtnPen;
        private Label lblTextToEngrave;
        private TextBox txbTextToEngrave;
        private CheckBox cbxHasLogo;
        private Label lblNumberOfColors;
        private TextBox txbNumberOfColors;
        private Button btnSubmit;
        private TextBox txbResults;
        private Label lblResults;
        private Button btnClear;
    }
}
