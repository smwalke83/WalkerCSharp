// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// Project: Depreciation Form
// File: Form1.cs

namespace WalkerP4
{
    public partial class Form1 : Form
    {
        
        // a list property that will contain the items in the list box
        List<DepreciationStraightLine> items = new List<DepreciationStraightLine>();
        public Form1()
        {
            InitializeComponent();
        }

        // method triggered when add button is clicked
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rbStraightLine.Checked)
            {
                // if the user chose straight line depreciation, the values in the form are populated into a DepreciationStraightLine object, which is added to he items list and displayed in the list box
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
                    txbError.Visible = false;
                }
                // if any errors are thrown due to user inputs, they will be displayed in the errors message box, which is otherwise not visible
                catch (Exception ex) 
                {
                    txbError.Visible = true;
                    txbError.Text = "Error: " + ex.Message;
                }
            }
            else if (rbDoubleDeclining.Checked)
            {
                // same as above, but for double declining depreciation
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
                    txbError.Visible = false;
                }
                catch (Exception ex) 
                {
                    txbError.Visible = true;
                    txbError.Text = "Errors: " + ex.Message;
                }
            }
        }

        // when remove is clicked, selected item is deleted from the list and list box
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbInventory.SelectedItem != null)
            {
                DepreciationStraightLine dep = (DepreciationStraightLine)lbInventory.SelectedItem;
                items.Remove(dep);
                lbInventory.DataSource = null;
                lbInventory.DataSource = items;
                txbError.Visible = false;
            }
        }

        // when a list item is double clicked, the object's properties are populated into the form text boxes
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
                txbError.Visible = false;
            }
        }

        // when calcvalue is clicked, the total for each item in the items list is added together and displayed to the user
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
