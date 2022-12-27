using IO.Swagger.Model;

namespace rpbd2.GUI
{
    public partial class EditShip : Form
    {
        MainWindow mainWindow;
        Ship ship;

        public EditShip(MainWindow mainWindow, Ship ship)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
            this.ship = ship;

            foreach (var port in mainWindow.ports)
                homeportComboBox.Items.Add(port.Name);
            foreach (var purpose in mainWindow.shipPurposes)
                purposeComboBox.Items.Add(purpose.Name);
            foreach (var member in mainWindow.members)
                memberComboBox.Items.Add(member.Firstname[0] + ". " + member.Patronymic[0] + ". " + member.Lastname);

            if (ship == null)
            {
                Text = "New ship";
                applyButton.Text = "Create";
            }
            else
            {
                nameTextBox.Text = ship.Name;
                carryCapacityNumeric.Value = (decimal)ship.Carrycapacity;
                homeportComboBox.SelectedIndex = mainWindow.ports.IndexOf(mainWindow.ports.Where(port => port.Id == ship.Homeport).First());
                purposeComboBox.SelectedIndex = mainWindow.shipPurposes.IndexOf(mainWindow.shipPurposes.Where(purpose => purpose.Id == ship.Purpose).First());
                overhaulStartDatePicker.Value = DateTime.Parse(ship.Overhaulstartdate);
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (ship == null)
            {
                mainWindow.ships.Add(new Ship());
                ship = mainWindow.ships.LastOrDefault();
            }
            ship.Name = nameTextBox.Text;
            ship.Carrycapacity = (float)carryCapacityNumeric.Value;
            ship.Homeport = mainWindow.ports[homeportComboBox.SelectedIndex].Id;
            ship.Purpose = mainWindow.shipPurposes[purposeComboBox.SelectedIndex].Id;
            ship.Overhaulstartdate = overhaulStartDatePicker.Value.ToShortDateString();
            
            foreach (var member in mainWindow.members.Where(_member => _member.Ship == ship.Id))
            {
                member.Ship = 0;
                mainWindow.crewMembersApi.AddOrUpdateCrewMember(member);
            }

            for (int i = 0; i < crewGridView.RowCount - 1; i++)
            {
                CrewMember member = mainWindow.members.Where(member => member.Id == (Int64)crewGridView.Rows[i].Cells[0].Value).FirstOrDefault();
                member.Ship = ship.Id;
                mainWindow.crewMembersApi.AddOrUpdateCrewMember(member);
            }

            mainWindow.shipsApi.AddOrUpdateShip(ship);

            Close();
        }

        private void crewGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            crewGridView.Rows[e.RowIndex].Cells[0].Value = mainWindow.members[e.RowIndex].Id;
        }
    }
}
