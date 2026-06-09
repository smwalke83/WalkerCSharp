namespace WalkerP4
{
    public partial class Form1 : Form
    {
        List<DepreciationStraightLine> items = new List<DepreciationStraightLine>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rbStraightLine.Checked)
            {
                try
                {
                    DepreciationStraightLine dep = new DepreciationStraightLine();
                    dep.Title = txbTitle.Text;
                    dep.StartValue = decimal.Parse(txbStartingValue.Text);
                    dep.EndValue = decimal.Parse(txbEndValue.Text);
                    dep.Lifetime = int.Parse(txbLifetime.Text);
                    dep.DateAddedToINventory = dtpDateIn.Value;
                    dep.DateRemovedFromInventory = dtpDateOut.Value;
                    items.Add(dep);
                    lbInventory.DataSource = null;
                    lbInventory.DataSource = items;
                    txbError.Text = "Errors: None";
                }
                catch (Exception ex) 
                {
                    txbError.Text = "Error: " + ex.Message;
                }
            }
            else if (rbDoubleDeclining.Checked)
            {
                try
                {
                    DepreciationDoubleDeclining dep = new DepreciationDoubleDeclining();
                    dep.Title = txbTitle.Text;
                    dep.StartValue = decimal.Parse(txbStartingValue.Text);
                    dep.EndValue = decimal.Parse(txbEndValue.Text);
                    dep.Lifetime = int.Parse(txbLifetime.Text);
                    dep.DateAddedToINventory = dtpDateIn.Value;
                    dep.DateRemovedFromInventory = dtpDateOut.Value;
                    items.Add(dep);
                    lbInventory.DataSource = null;
                    lbInventory.DataSource = items;
                    txbError.Text = "Errors: None";
                }
                catch (Exception ex) 
                {
                    txbError.Text = "Errors: " + ex.Message;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbInventory.SelectedItem != null)
            {
                DepreciationStraightLine dep = (DepreciationStraightLine)lbInventory.SelectedItem;
                items.Remove(dep);
                lbInventory.DataSource = null;
                lbInventory.DataSource = items;
                txbError.Text = "Errors: None";
            }
        }

        private void lbInventory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbInventory.SelectedItem != null)
            {
                DepreciationStraightLine dep = (DepreciationStraightLine)lbInventory.SelectedItem;
                txbTitle.Text = dep.Title;
                txbStartingValue.Text = dep.StartValue.ToString();
                txbEndValue.Text = dep.EndValue.ToString();
                txbLifetime.Text = dep.Lifetime.ToString();
                dtpDateIn.Value = dep.DateAddedToINventory;
                dtpDateOut.Value = dep.DateRemovedFromInventory;
                txbError.Text = "Errors: None";
            }
        }

        private void btnCalcValue_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            foreach (DepreciationStraightLine item in items) 
            {
                total += item.SalvageValue;
            }
            lblCalcValue.Text = "The total value of your inventory is: $" + total.ToString("F2"); 
        }
    }
}
