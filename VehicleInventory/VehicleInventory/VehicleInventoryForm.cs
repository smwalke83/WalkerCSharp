namespace VehicleInventory
{
    public partial class VehicleInventoryForm : Form
    {
        // list of vehicles that will be displayed in a list box
        private List<Vehicle> vehicles = new List<Vehicle>();
        public VehicleInventoryForm()
        {
            InitializeComponent();
        }

        // click event for the add button, creates a vehicle of the specified type and adds it to the vehicle list
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxType.Text == "Sedan")
            {
                Sedan sedan = new Sedan();
                sedan.LicensePlate = txbLicense.Text;
                sedan.VIN = txbVIN.Text;
                vehicles.Add(sedan);
                lbInventory.DataSource = null;
                lbInventory.DataSource = vehicles;
                txbResults.Text = "Successfully added sedan";
            }
            else if (cbxType.Text == "Truck")
            {
                Truck truck = new Truck(txbVIN.Text, txbLicense.Text);
                vehicles.Add(truck);
                lbInventory.DataSource = null;
                lbInventory.DataSource = vehicles;
                txbResults.Text = "Successfully added truck";
            }
        }

        // double click event for the list box, double clicking a list item prints its description to the summary text box
        private void lbInventory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Vehicle vehicle = (Vehicle)lbInventory.SelectedItem;
            txbSummary.Text = vehicle.GetDescription();
        }
    }
}
