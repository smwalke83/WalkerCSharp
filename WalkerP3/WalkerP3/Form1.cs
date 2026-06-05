namespace WalkerP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // When the logo checkbock is checked or unchecked, toggles visibility of the number of colors options
        private void cbxHasLogo_CheckedChanged(object sender, EventArgs e)
        {
            lblNumberOfColors.Visible = !lblNumberOfColors.Visible;
            txbNumberOfColors.Visible = !txbNumberOfColors.Visible;
        }

        // When the submit button is clicked, a logo order item object is created and the values are applied to it, then the results are displayed.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            LogoOrderItem newItem = new LogoOrderItem(cbxHasLogo.Checked, txbTextToEngrave.Text);
            if (rbtnUSB.Checked)
            {
                newItem.ItemType = "usb drive";
            }
            else if (rbtnMug.Checked)
            {
                newItem.ItemType = "mug";
            }
            else if (rbtnPen.Checked)
            {
                newItem.ItemType = "pen";
            }
            try
            {
                newItem.NumColors = int.Parse(txbNumberOfColors.Text);
                newItem.NumItems = int.Parse(txbNumberOfItems.Text);
                newItem.ItemID = int.Parse(txbOrderNumber.Text);
                txbResults.Text = newItem.GetOrderSummary();
            }
            catch (Exception ex)
            {
                txbResults.Text = "Error: " + ex.Message;
            }

        }

        // when the clear button is clicked, all form values are reset to default
        private void btnClear_Click(object sender, EventArgs e)
        {
            txbOrderNumber.Text = "0";
            txbNumberOfItems.Text = "0";
            txbTextToEngrave.Text = "Hello, World";
            txbNumberOfColors.Text = "0";
            txbResults.Text = "Click Submit for results.";
            cbxHasLogo.Checked = false;
        }
    }
}
