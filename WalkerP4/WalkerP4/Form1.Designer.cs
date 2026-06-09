namespace WalkerP4
{
    partial class Form1 : Form
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
            tabControl1 = new TabControl();
            tabHowTo = new TabPage();
            txbWelcome = new TextBox();
            lblHeader = new Label();
            tabInventory = new TabPage();
            btnAdd = new Button();
            btnRemove = new Button();
            dtpDateOut = new DateTimePicker();
            dtpDateIn = new DateTimePicker();
            rbDoubleDeclining = new RadioButton();
            rbStraightLine = new RadioButton();
            txbLifetime = new TextBox();
            txbEndValue = new TextBox();
            txbStartingValue = new TextBox();
            txbTitle = new TextBox();
            lblDateOut = new Label();
            lblDateIn = new Label();
            lblLifetime = new Label();
            lblEndValue = new Label();
            lblStartingValue = new Label();
            lblTitle = new Label();
            lbInventory = new ListBox();
            tabSummary = new TabPage();
            lblCalcValue = new Label();
            btnCalcValue = new Button();
            txbError = new TextBox();
            tabControl1.SuspendLayout();
            tabHowTo.SuspendLayout();
            tabInventory.SuspendLayout();
            tabSummary.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabHowTo);
            tabControl1.Controls.Add(tabInventory);
            tabControl1.Controls.Add(tabSummary);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabHowTo
            // 
            tabHowTo.Controls.Add(txbWelcome);
            tabHowTo.Controls.Add(lblHeader);
            tabHowTo.Location = new Point(4, 24);
            tabHowTo.Name = "tabHowTo";
            tabHowTo.Padding = new Padding(3);
            tabHowTo.Size = new Size(768, 398);
            tabHowTo.TabIndex = 0;
            tabHowTo.Text = "How to use this Application";
            tabHowTo.UseVisualStyleBackColor = true;
            // 
            // txbWelcome
            // 
            txbWelcome.Font = new Font("Segoe UI", 12F);
            txbWelcome.Location = new Point(131, 134);
            txbWelcome.Multiline = true;
            txbWelcome.Name = "txbWelcome";
            txbWelcome.Size = new Size(463, 71);
            txbWelcome.TabIndex = 1;
            txbWelcome.Text = "Welcome to Super Depreciation Calculator 3000. Enter your inventory in the inventory tab. Then go to the summary tab to find the value of your inventory.";
            // 
            // lblHeader
            // 
            lblHeader.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHeader.Location = new Point(131, 24);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(492, 50);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Super Depreciation Calculator 3000";
            // 
            // tabInventory
            // 
            tabInventory.Controls.Add(txbError);
            tabInventory.Controls.Add(btnAdd);
            tabInventory.Controls.Add(btnRemove);
            tabInventory.Controls.Add(dtpDateOut);
            tabInventory.Controls.Add(dtpDateIn);
            tabInventory.Controls.Add(rbDoubleDeclining);
            tabInventory.Controls.Add(rbStraightLine);
            tabInventory.Controls.Add(txbLifetime);
            tabInventory.Controls.Add(txbEndValue);
            tabInventory.Controls.Add(txbStartingValue);
            tabInventory.Controls.Add(txbTitle);
            tabInventory.Controls.Add(lblDateOut);
            tabInventory.Controls.Add(lblDateIn);
            tabInventory.Controls.Add(lblLifetime);
            tabInventory.Controls.Add(lblEndValue);
            tabInventory.Controls.Add(lblStartingValue);
            tabInventory.Controls.Add(lblTitle);
            tabInventory.Controls.Add(lbInventory);
            tabInventory.Location = new Point(4, 24);
            tabInventory.Name = "tabInventory";
            tabInventory.Padding = new Padding(3);
            tabInventory.Size = new Size(768, 398);
            tabInventory.TabIndex = 1;
            tabInventory.Text = "Inventory";
            tabInventory.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(397, 278);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(233, 23);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add Form Item To Inventory";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(6, 341);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(288, 23);
            btnRemove.TabIndex = 17;
            btnRemove.Text = "Remove Selected Item From Inventory";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // dtpDateOut
            // 
            dtpDateOut.Location = new Point(486, 168);
            dtpDateOut.Name = "dtpDateOut";
            dtpDateOut.Size = new Size(216, 23);
            dtpDateOut.TabIndex = 16;
            // 
            // dtpDateIn
            // 
            dtpDateIn.Location = new Point(486, 141);
            dtpDateIn.Name = "dtpDateIn";
            dtpDateIn.Size = new Size(216, 23);
            dtpDateIn.TabIndex = 15;
            // 
            // rbDoubleDeclining
            // 
            rbDoubleDeclining.AutoSize = true;
            rbDoubleDeclining.Location = new Point(459, 235);
            rbDoubleDeclining.Name = "rbDoubleDeclining";
            rbDoubleDeclining.Size = new Size(116, 19);
            rbDoubleDeclining.TabIndex = 14;
            rbDoubleDeclining.Text = "Double Declining";
            rbDoubleDeclining.UseVisualStyleBackColor = true;
            // 
            // rbStraightLine
            // 
            rbStraightLine.AutoSize = true;
            rbStraightLine.Checked = true;
            rbStraightLine.Location = new Point(459, 210);
            rbStraightLine.Name = "rbStraightLine";
            rbStraightLine.Size = new Size(91, 19);
            rbStraightLine.TabIndex = 13;
            rbStraightLine.TabStop = true;
            rbStraightLine.Text = "Straight Line";
            rbStraightLine.UseVisualStyleBackColor = true;
            // 
            // txbLifetime
            // 
            txbLifetime.Location = new Point(486, 115);
            txbLifetime.Name = "txbLifetime";
            txbLifetime.Size = new Size(216, 23);
            txbLifetime.TabIndex = 10;
            // 
            // txbEndValue
            // 
            txbEndValue.Location = new Point(486, 88);
            txbEndValue.Name = "txbEndValue";
            txbEndValue.Size = new Size(216, 23);
            txbEndValue.TabIndex = 9;
            // 
            // txbStartingValue
            // 
            txbStartingValue.Location = new Point(486, 58);
            txbStartingValue.Name = "txbStartingValue";
            txbStartingValue.Size = new Size(216, 23);
            txbStartingValue.TabIndex = 8;
            // 
            // txbTitle
            // 
            txbTitle.Location = new Point(486, 30);
            txbTitle.Name = "txbTitle";
            txbTitle.Size = new Size(216, 23);
            txbTitle.TabIndex = 7;
            // 
            // lblDateOut
            // 
            lblDateOut.AutoSize = true;
            lblDateOut.Location = new Point(334, 174);
            lblDateOut.Name = "lblDateOut";
            lblDateOut.Size = new Size(119, 15);
            lblDateOut.TabIndex = 6;
            lblDateOut.Text = "Date out of Inventory";
            // 
            // lblDateIn
            // 
            lblDateIn.AutoSize = true;
            lblDateIn.Location = new Point(334, 147);
            lblDateIn.Name = "lblDateIn";
            lblDateIn.Size = new Size(97, 15);
            lblDateIn.TabIndex = 5;
            lblDateIn.Text = "Date in Inventory";
            // 
            // lblLifetime
            // 
            lblLifetime.AutoSize = true;
            lblLifetime.Location = new Point(334, 118);
            lblLifetime.Name = "lblLifetime";
            lblLifetime.Size = new Size(88, 15);
            lblLifetime.TabIndex = 4;
            lblLifetime.Text = "Lifetime (years)";
            // 
            // lblEndValue
            // 
            lblEndValue.AutoSize = true;
            lblEndValue.Location = new Point(334, 91);
            lblEndValue.Name = "lblEndValue";
            lblEndValue.Size = new Size(67, 15);
            lblEndValue.TabIndex = 3;
            lblEndValue.Text = "End Value $";
            // 
            // lblStartingValue
            // 
            lblStartingValue.AutoSize = true;
            lblStartingValue.Location = new Point(334, 61);
            lblStartingValue.Name = "lblStartingValue";
            lblStartingValue.Size = new Size(88, 15);
            lblStartingValue.TabIndex = 2;
            lblStartingValue.Text = "Starting Value $";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(334, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(30, 15);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title";
            // 
            // lbInventory
            // 
            lbInventory.FormattingEnabled = true;
            lbInventory.HorizontalExtent = 500;
            lbInventory.HorizontalScrollbar = true;
            lbInventory.Location = new Point(6, 16);
            lbInventory.Name = "lbInventory";
            lbInventory.Size = new Size(288, 319);
            lbInventory.TabIndex = 0;
            lbInventory.MouseDoubleClick += lbInventory_MouseDoubleClick;
            // 
            // tabSummary
            // 
            tabSummary.Controls.Add(lblCalcValue);
            tabSummary.Controls.Add(btnCalcValue);
            tabSummary.Location = new Point(4, 24);
            tabSummary.Name = "tabSummary";
            tabSummary.Padding = new Padding(3);
            tabSummary.Size = new Size(768, 398);
            tabSummary.TabIndex = 2;
            tabSummary.Text = "Summary";
            tabSummary.UseVisualStyleBackColor = true;
            // 
            // lblCalcValue
            // 
            lblCalcValue.AutoSize = true;
            lblCalcValue.Location = new Point(250, 152);
            lblCalcValue.Name = "lblCalcValue";
            lblCalcValue.Size = new Size(243, 15);
            lblCalcValue.TabIndex = 1;
            lblCalcValue.Text = "Click the button to calculate inventory value.";
            // 
            // btnCalcValue
            // 
            btnCalcValue.Font = new Font("Segoe UI", 15F);
            btnCalcValue.Location = new Point(205, 56);
            btnCalcValue.Name = "btnCalcValue";
            btnCalcValue.Size = new Size(329, 57);
            btnCalcValue.TabIndex = 0;
            btnCalcValue.Text = "Calculate Inventory Value";
            btnCalcValue.UseVisualStyleBackColor = true;
            btnCalcValue.Click += btnCalcValue_Click;
            // 
            // txbError
            // 
            txbError.AcceptsReturn = true;
            txbError.Location = new Point(331, 341);
            txbError.Name = "txbError";
            txbError.Size = new Size(371, 23);
            txbError.TabIndex = 19;
            txbError.Text = "Errors: None";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabHowTo.ResumeLayout(false);
            tabHowTo.PerformLayout();
            tabInventory.ResumeLayout(false);
            tabInventory.PerformLayout();
            tabSummary.ResumeLayout(false);
            tabSummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabHowTo;
        private Label lblHeader;
        private TabPage tabInventory;
        private TabPage tabSummary;
        private TextBox txbWelcome;
        private TextBox txbLifetime;
        private TextBox txbEndValue;
        private TextBox txbStartingValue;
        private TextBox txbTitle;
        private Label lblDateOut;
        private Label lblDateIn;
        private Label lblLifetime;
        private Label lblEndValue;
        private Label lblStartingValue;
        private Label lblTitle;
        private ListBox lbInventory;
        private Button btnAdd;
        private Button btnRemove;
        private DateTimePicker dtpDateOut;
        private DateTimePicker dtpDateIn;
        private RadioButton rbDoubleDeclining;
        private RadioButton rbStraightLine;
        private Label lblCalcValue;
        private Button btnCalcValue;
        private TextBox txbError;
    }
}
