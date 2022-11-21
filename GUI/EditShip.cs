namespace rpbd2.GUI
{
    public partial class EditShip : Form
    {
        MainWindow mainWindow;
        Entities.Ship ship;

        public EditShip(MainWindow mainWindow, Entities.Ship ship)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
            this.ship = ship;

            foreach (var port in mainWindow.ports)
                homeportComboBox.Items.Add(port.Name);
            foreach (var purpose in mainWindow.shipPurposes)
                purposeComboBox.Items.Add(purpose.Name);
            foreach (var member in mainWindow.members)
                memberComboBox.Items.Add(member.FirstName[0] + ". " + member.Patronymic[0] + ". " + member.LastName);

            if (ship == null)
            {
                Text = "New ship";
                applyButton.Text = "Create";
            }
            else
            {
                nameTextBox.Text = ship.Name;
                carryCapacityNumeric.Value = (decimal)ship.CarryCapacity;
                homeportComboBox.SelectedIndex = mainWindow.ports.IndexOf(ship.Homeport);
                purposeComboBox.SelectedIndex = mainWindow.shipPurposes.IndexOf(ship.Purpose);
                overhaulStartDatePicker.Value = ship.OverhaulStartDate;
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (ship == null)
            {
                mainWindow.ships.Add(new Entities.Ship());
                ship = mainWindow.ships.LastOrDefault();
                DB.getInstance().Save(ship);
            }
            ship.Name = nameTextBox.Text;
            ship.CarryCapacity = (float)carryCapacityNumeric.Value;
            ship.Homeport = mainWindow.ports[homeportComboBox.SelectedIndex];
            ship.Purpose = mainWindow.shipPurposes[purposeComboBox.SelectedIndex];
            ship.OverhaulStartDate = overhaulStartDatePicker.Value;
            ship.Crew.Clear();
            for (int i = 0; i < crewGridView.RowCount-1; i++)
            {
                ship.Crew.Add(mainWindow.members.Where(member => member.Id == (int)crewGridView.Rows[i].Cells[0].Value).FirstOrDefault());
            }

            DB.getInstance().FlushAsync();

            Close();
        }

        private void crewGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            crewGridView.Rows[e.RowIndex].Cells[0].Value = mainWindow.members[e.RowIndex].Id;
        }
    }
}
