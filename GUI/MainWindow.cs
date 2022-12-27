using System.Windows.Forms;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;

namespace rpbd2.GUI
{
    public partial class MainWindow : Form
    {
        public IList<Cruise> cruises;
        public IList<Ship> ships;
        public IList<CrewMember> members;
        public IList<Charterer> charterers;

        public IList<GeneralCargoType> generalCargoTypes;
        public IList<Port> ports;
        public IList<Role> roles;
        public IList<ShipPurpose> shipPurposes;

        public CharterersApi charterersApi;
        public CrewMembersApi crewMembersApi;
        public ShipsApi shipsApi;
        public CruisesApi cruisesApi;
        public PortEntriesApi portEntriesApi;
        public PortsApi portsApi;
        public RolesApi rolesApi;
        public ShipPurposesApi shipPurposesApi;
        public GeneralCargoTypesApi generalCargoTypesApi;

        public MainWindow()
        {
            InitializeComponent();

            cruises = new List<Cruise>();
            ships = new List<Ship>();
            members = new List<CrewMember>();
            charterers = new List<Charterer>();
            generalCargoTypes = new List<GeneralCargoType>();
            ports = new List<Port>();
            roles = new List<Role>();
            shipPurposes = new List<ShipPurpose>();

            charterersApi = new CharterersApi();
            crewMembersApi = new CrewMembersApi();
            shipsApi = new ShipsApi();
            cruisesApi = new CruisesApi();
            portEntriesApi = new PortEntriesApi();
            portsApi = new PortsApi();
            rolesApi = new RolesApi();
            shipPurposesApi = new ShipPurposesApi();
            generalCargoTypesApi = new GeneralCargoTypesApi();

            LoadGeneralCargoTypes(true);
            LoadPorts(true);
            LoadRoles(true);
            LoadShipPurposes(true);
            LoadCharterers();
            LoadShips();
            LoadStaff();
            LoadCruises();
            miscComboBox.SelectedIndex = 0;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    LoadCruises();
                    break;
                case 1:
                    LoadShips();
                    break;
                case 2:
                    LoadStaff();
                    break;
                case 3:
                    LoadCharterers();
                    break;
                case 4:
                    LoadMisc();
                    break;
            }
        }

        private void LoadCruises()
        {
            cruisesGridView.Rows.Clear();
            if (cruises.Count == 0)
            {
                foreach (var cruise in cruisesApi.GetCruises())
                {
                    cruise.Portentries = portEntriesApi.GetPortEntriesByCruiseId(cruise.Id);
                    cruises.Add(cruise);
                }
            }
            foreach (var cruise in cruises)
            {
                cruisesGridView.Rows.Add(new object[] {
                            ports.Where(port => port.Id == cruise.Departureport).First().Name,
                            ports.Where(port => port.Id == cruise.Destinationport).First().Name,
                            ships.Where(ship => ship.Id == cruise.Ship).First().Name,
                            generalCargoTypes.Where(generalCargoType => generalCargoType.Id == cruise.Generalcargotype).First().Name,
                            charterers.Where(charterer => charterer.Id == cruise.Charterer).First().Name
                        });
            }
        }

        private void LoadShips()
        {
            shipsGridView.Rows.Clear();
            if (ships.Count == 0)
            {
                foreach (var ship in shipsApi.GetShips())
                {
                    ships.Add(ship);
                }
            }
            foreach (var ship in ships)
            {
                string currentCruiseString = "";
                try
                {
                    Cruise currentCruise = cruises.Where(cruise => cruise.Id == ship.Currentcruise).First();
                    Port departurePort = ports.Where(port => port.Id == currentCruise.Departureport).First();
                    Port destinationPort = ports.Where(port => port.Id == currentCruise.Destinationport).First();
                    currentCruiseString = departurePort.Name + " - " + destinationPort.Name;
                } catch {}
                shipsGridView.Rows.Add(new object[] {
                            ship.Name,
                            currentCruiseString,
                            ship.Carrycapacity,
                            ports.Where(port => port.Id == ship.Homeport).First().Name,
                            shipPurposes.Where(purpose => purpose.Id == ship.Purpose).First().Name,
                            ship.Location,
                            ship.Overhaulstartdate,
                        });
            }
        }

        private void LoadStaff()
        {
            staffGridView.Rows.Clear();
            if (members.Count == 0)
            {
                foreach (var crewMember in crewMembersApi.GetCrewMembers())
                {
                    members.Add(crewMember);
                }
            }
            foreach (var member in members)
            {
                staffGridView.Rows.Add(new object[] {
                            member.Firstname,
                            member.Lastname,
                            member.Patronymic,
                            member.Birthdate,
                            (member.Ship != null && member.Ship != 0 ? ships.Where(ship => ship.Id == member.Ship).First().Name : ""),
                            roles.Where(role => role.Id == member.Role).First().Name,
                            member.Experience,
                            member.Salary,
                        });
            }
        }

        private void LoadCharterers()
        {
            charterersGridView.Rows.Clear();
            if (charterers.Count == 0)
            {
                foreach (var charterer in this.charterersApi.GetCharterers())
                {
                    charterers.Add(charterer);
                }
            }
            foreach (var charterer in charterers)
            {
                charterersGridView.Rows.Add(new object[] {
                            charterer.Name,
                            charterer.Address,
                            charterer.Phonenumber,
                            charterer.Fax,
                            charterer.Email,
                            charterer.Bankname,
                            charterer.Bankcity,
                            charterer.Tin,
                            charterer.Bankaccount
                        });
            }
        }

        private void LoadMisc()
        {
            miscGridView.Rows.Clear();
            switch (miscComboBox.SelectedIndex)
            {
                default:
                case 0:
                    LoadGeneralCargoTypes(false);
                    break;
                case 1:
                    LoadPorts(false);
                    break;
                case 2:
                    LoadRoles(false);
                    break;
                case 3:
                    LoadShipPurposes(false);
                    break;
            }
        }

        private void LoadGeneralCargoTypes(bool initial)
        {
            if (initial)
            {
                foreach (var generalCargoType in generalCargoTypesApi.GetGeneralCargoTypes())
                {
                    generalCargoTypes.Add(generalCargoType);
                }
                return;
            }
            foreach (var generalCargoType in generalCargoTypes)
            {
                miscGridView.Rows.Add(new object[] {
                            generalCargoType.Name
                        });
            }
        }

        private void LoadPorts(bool initial)
        {
            if (initial)
            {
                foreach (var port in portsApi.GetPorts())
                {
                    ports.Add(port);
                }
                return;
            }
            foreach (var port in ports)
            {
                miscGridView.Rows.Add(new object[] {
                            port.Name
                        });
            }
        }

        private void LoadRoles(bool initial)
        {
            if (initial)
            {
                foreach (var role in rolesApi.GetRoles())
                {
                    roles.Add(role);
                }
                return;
            }
            foreach (var role in roles)
            {
                miscGridView.Rows.Add(new object[] {
                            role.Name
                        });
            }
        }

        private void LoadShipPurposes(bool initial)
        {
            if (initial)
            {
                foreach (var shipPurpose in shipPurposesApi.GetShipPurposes())
                {
                    shipPurposes.Add(shipPurpose);
                }
                return;
            }
            foreach (var shipPurpose in shipPurposes)
            {
                miscGridView.Rows.Add(new object[] {
                            shipPurpose.Name
                        });
            }
        }

        private void newChartererButton_Click(object sender, EventArgs e)
        {
            EditCharterer editChareterer = new EditCharterer(this, null);
            editChareterer.Show();
            editChareterer.FormClosed += editChareterer_FormClosed;
        }

        private void editChartererButton_Click(object sender, EventArgs e)
        {
            EditCharterer editChareterer = new EditCharterer(this, charterers[charterersGridView.SelectedRows[0].Index]);
            editChareterer.Show();
            editChareterer.FormClosed += editChareterer_FormClosed;
        }

        private void editChareterer_FormClosed(object? sender, FormClosedEventArgs e)
        {
            tabControl1_SelectedIndexChanged(null, null);
        }

        private void charterersGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var cells = charterersGridView.SelectedRows[0].Cells;
            chartererNameLabel.Text = (string)cells[0].Value;
            chartererAddressLabel.Text = (string)cells[1].Value;
            chartererPhoneNumberLabel.Text = (string)cells[2].Value;
            chartererFaxLabel.Text = (string)cells[3].Value;
            chartererEmailLabel.Text = (string)cells[4].Value;
            chartererBankNameLabel.Text = (string)cells[5].Value;
            chartererBankCityLabel.Text = (string)cells[6].Value;
            chartererTINLabel.Text = (string)cells[7].Value;
            chartererAccountNumberLabel.Text = (string)cells[8].Value;
        }

        private void removeChartererButton_Click(object sender, EventArgs e)
        {
            var index = charterersGridView.SelectedRows[0].Index;
            charterersApi.DeleteCharterer(charterers[index].Id);
            charterers.RemoveAt(index);

            tabControl1_SelectedIndexChanged(null, null);
        }

        private void newMemberButton_Click(object sender, EventArgs e)
        {
            EditCrewMember editCrewMember = new EditCrewMember(this, null);
            editCrewMember.Show();
            editCrewMember.FormClosed += editCrewMember_FormClosed;
        }

        private void editMemberButton_Click(object sender, EventArgs e)
        {
            EditCrewMember editCrewMember = new EditCrewMember(this, members[staffGridView.SelectedRows[0].Index]);
            editCrewMember.Show();
            editCrewMember.FormClosed += editCrewMember_FormClosed;
        }

        private void removeMemberButton_Click(object sender, EventArgs e)
        {
            var index = staffGridView.SelectedRows[0].Index;
            crewMembersApi.DeleteCrewMember(members[index].Id);
            members.RemoveAt(index);

            tabControl1_SelectedIndexChanged(null, null);
        }

        private void editCrewMember_FormClosed(object? sender, FormClosedEventArgs e)
        {
            tabControl1_SelectedIndexChanged(null, null);
        }

        private void staffGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var cells = staffGridView.SelectedRows[0].Cells;
            memberFirstNameLabel.Text = (string)cells[0].Value;
            memberLastNameLabel.Text = (string)cells[1].Value;
            memberPatronymicLabel.Text = (string)cells[2].Value;
            memberBirthDateLabel.Text = (string)cells[3].Value;
            memberShipLabel.Text = (string)cells[4].Value;
            memberRoleLabel.Text = (string)cells[5].Value;
            memberExperienceLabel.Text = cells[6].Value.ToString();
            memberSalaryLabel.Text = cells[7].Value.ToString();
        }

        private void miscComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMisc();
        }

        private void miscGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string newName = miscGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            switch (miscComboBox.SelectedIndex)
            {
                default:
                case 0:
                    if (e.RowIndex >= generalCargoTypes.Count)
                        generalCargoTypes.Add(new GeneralCargoType() { Name = newName });
                    else
                        generalCargoTypes[e.RowIndex].Name = newName;
                    generalCargoTypesApi.AddGeneralCargoType(generalCargoTypes.LastOrDefault());
                    break;
                case 1:
                    if (e.RowIndex >= ports.Count)
                        ports.Add(new Port() { Name = newName });
                    else
                        ports[e.RowIndex].Name = newName;
                    portsApi.AddPort(ports.LastOrDefault());
                    break;
                case 2:
                    if (e.RowIndex >= roles.Count)
                        roles.Add(new Role() { Name = newName });
                    else
                        roles[e.RowIndex].Name = newName;
                    rolesApi.AddRole(roles.LastOrDefault());
                    break;
                case 3:
                    if (e.RowIndex >= shipPurposes.Count)
                        shipPurposes.Add(new ShipPurpose() { Name = newName });
                    else
                        shipPurposes[e.RowIndex].Name = newName;
                    shipPurposesApi.AddShipPurpose(shipPurposes.LastOrDefault());
                    break;
            }

        }

        private void miscGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            int index = miscGridView.SelectedRows[0].Index;
            switch (miscComboBox.SelectedIndex)
            {
                case 0:
                    generalCargoTypesApi.DeleteGeneralCargoType(generalCargoTypes[index].Id);
                    generalCargoTypes.RemoveAt(index);
                    break;
                case 1:
                    portsApi.DeletePort(ports[index].Id);
                    ports.RemoveAt(index);
                    break;
                case 2:
                    rolesApi.DeleteRole(roles[index].Id);
                    roles.RemoveAt(index);
                    break;
                case 3:
                    shipPurposesApi.DeleteShipPurpose(shipPurposes[index].Id);
                    shipPurposes.RemoveAt(index);
                    break;
            }
        }

        private void newShipButton_Click(object sender, EventArgs e)
        {
            EditShip editShip = new EditShip(this, null);
            editShip.Show();
            editShip.FormClosed += editShip_FormClosed;
        }

        private void editShipButton_Click(object sender, EventArgs e)
        {
            EditShip editShip = new EditShip(this, ships[shipsGridView.SelectedRows[0].Index]);
            editShip.Show();
            editShip.FormClosed += editShip_FormClosed;
        }

        private void editShip_FormClosed(object? sender, FormClosedEventArgs e) {
            tabControl1_SelectedIndexChanged(null, null);
        }

        private void removeShipButton_Click(object sender, EventArgs e)
        {
            var index = shipsGridView.SelectedRows[0].Index;
            shipsApi.DeleteShip(ships[index].Id);
            ships.RemoveAt(index);

            tabControl1_SelectedIndexChanged(null, null);
        }

        private void shipsGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var cells = shipsGridView.SelectedRows[0].Cells;
            shipNameLabel.Text = (string)cells[0].Value;
            shipCruiseLabel.Text = (string)cells[1].Value;
            shipCarryCapacityLabel.Text = ((float)cells[2].Value).ToString();
            shipHomeportLabel.Text = (string)cells[3].Value;
            shipPurposeLabel.Text = (string)cells[4].Value;
            shipCrewLabel.Text = "";
            foreach (var member in members.Where(_member => _member.Ship == ships[shipsGridView.SelectedRows[0].Index].Id))
            {
                shipCrewLabel.Text += member.Firstname[0] + ". " + member.Patronymic[0] + ". " + member.Lastname + "\n";
            }
            shipLocationLabel.Text = cells[5].Value != null ? ((Point)cells[5].Value).ToString() : "";
            shipOverhaulStartDateLabel.Text = (string)cells[6].Value;
        }

        private void newCruiseButton_Click(object sender, EventArgs e)
        {
            EditCruise editCruise = new EditCruise(this, null);
            editCruise.Show();
            editCruise.FormClosed += editCruise_FormClosed;
        }

        private void editCruiseButton_Click(object sender, EventArgs e)
        {
            EditCruise editCruise = new EditCruise(this, cruises[cruisesGridView.SelectedRows[0].Index]);
            editCruise.Show();
            editCruise.FormClosed += editCruise_FormClosed;
        }

        private void editCruise_FormClosed(object? sender, FormClosedEventArgs e)
        {
            tabControl1_SelectedIndexChanged(null, null);
        }

        private void removeCruiseButton_Click(object sender, EventArgs e)
        {
            var index = cruisesGridView.SelectedRows[0].Index;
            cruisesApi.DeleteCruise(cruises[index].Id);
            cruises.RemoveAt(index);

            tabControl1_SelectedIndexChanged(null, null);
        }

        private void cruisesGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var cells = cruisesGridView.SelectedRows[0].Cells;
            cruiseDeparturePortLabel.Text = (string)cells[0].Value;
            cruiseDestinationPortLabel.Text = (string)cells[1].Value;
            cruiseShipLabel.Text = (string)cells[2].Value;
            cruiseGeneralCargoLabel.Text = (string)cells[3].Value;
            cruiseChartererLabel.Text = (string)cells[4].Value;
            routePointsGridView.Rows.Clear();
            for (var i = 0; i < cruises[cruisesGridView.SelectedRows[0].Index].Portentries.Count; i++) {
                var portEntry = cruises[cruisesGridView.SelectedRows[0].Index].Portentries[i];
                string status = "";
                if (portEntry.Destinationdateactual != null && portEntry.Departuredateactual == null)
                {
                    status = "Arrived";
                } else if (portEntry.Departuredateactual != null && 
                    i+1 < cruises[cruisesGridView.SelectedRows[0].Index].Portentries.Count &&
                    cruises[cruisesGridView.SelectedRows[0].Index].Portentries[i+1].Destinationdateactual == null)
                {
                    status = "Departed";
                }
                routePointsGridView.Rows.Add(new object[]
                {
                    status,
                    ports.Where(port => port.Id == portEntry.Port).First().Name,
                    portEntry.Destinationdateplanned,
                    portEntry.Destinationdateactual,
                    portEntry.Departuredateplanned,
                    portEntry.Departuredateactual,
                    portEntry.Destinationdelayreason,
                    portEntry.Departuredelayreason,
                });
            }
        }

        private void charterersSearchTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void updateRoutePointButton_Click(object sender, EventArgs e)
        {
            PortEntry portEntry = null;
            var i = 0;
            bool isDestination = false;
            for (; i < cruises[cruisesGridView.SelectedRows[0].Index].Portentries.Count; i++)
            {
                portEntry = cruises[cruisesGridView.SelectedRows[0].Index].Portentries[i];
                if ((portEntry.Destinationdateactual == null && portEntry.Departuredateactual == null) ||
                    (portEntry.Destinationdateactual != null && portEntry.Departuredateactual == null))
                {
                    break;
                }
                if (i+1 < cruises[cruisesGridView.SelectedRows[0].Index].Portentries.Count &&
                    cruises[cruisesGridView.SelectedRows[0].Index].Portentries[i+1].Destinationdateactual == null)
                {
                    isDestination = true;
                    portEntry = cruises[cruisesGridView.SelectedRows[0].Index].Portentries[i+1];
                    break;
                }
            }
            portEntry.Destinationdateactual = isDestination || portEntry.Destinationdateactual == null ?
                DateTime.Now : portEntry.Destinationdateactual;
            portEntry.Departuredateactual = !isDestination ?
                DateTime.Now : portEntry.Departuredateactual;

            portEntriesApi.AddOrUpdatePortEntry(portEntry);

            cruisesGridView_CellMouseClick(null, null);
        }
    }
}
