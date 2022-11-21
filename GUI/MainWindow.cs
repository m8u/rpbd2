using System.Windows.Forms;

namespace rpbd2.GUI
{
    public partial class MainWindow : Form
    {
        public IList<Entities.Cruise> cruises;
        public IList<Entities.Ship> ships;
        public IList<Entities.CrewMember> members;
        public IList<Entities.Charterer> charterers;

        public IList<Entities.GeneralCargoType> generalCargoTypes;
        public IList<Entities.Port> ports;
        public IList<Entities.Role> roles;
        public IList<Entities.ShipPurpose> shipPurposes;

        public MainWindow()
        {
            InitializeComponent();

            cruises = new List<Entities.Cruise>();
            ships = new List<Entities.Ship>();
            members = new List<Entities.CrewMember>();
            charterers = new List<Entities.Charterer>();
            generalCargoTypes = new List<Entities.GeneralCargoType>();
            ports = new List<Entities.Port>();
            roles = new List<Entities.Role>();
            shipPurposes = new List<Entities.ShipPurpose>();

            LoadCharterers();
            LoadStaff();
            LoadShips();
            LoadCruises();
            LoadGeneralCargoTypes(true);
            LoadPorts(true);
            LoadRoles(true);
            LoadShipPurposes(true);
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
                foreach (var item in DB.getInstance().GetAll("Cruise"))
                {
                    Entities.Cruise cruise = (Entities.Cruise)item;
                    cruises.Add(cruise);
                }
            }
            foreach (var cruise in cruises)
            {
                cruisesGridView.Rows.Add(new object[] {
                            cruise.Ship.Name,
                            cruise.GeneralCargoType.Name,
                            cruise.DeparturePort.Name,
                            cruise.DestinationPort.Name,
                            cruise.Charterer.Name
                        });
            }
        }

        private void LoadShips()
        {
            shipsGridView.Rows.Clear();
            if (ships.Count == 0)
            {
                foreach (var item in DB.getInstance().GetAll("Ship"))
                {
                    Entities.Ship ship = (Entities.Ship)item;
                    ships.Add(ship);
                }
            }
            foreach (var ship in ships)
            {
                shipsGridView.Rows.Add(new object[] {
                            ship.Name,
                            ship.CurrentCruise != null ?
                                ship.CurrentCruise.DeparturePort.Name + " - " + ship.CurrentCruise.DestinationPort.Name
                                : "-",
                            ship.CarryCapacity,
                            ship.Homeport.Name,
                            ship.Purpose.Name,
                            ship.Location,
                            ship.OverhaulStartDate,
                        });
            }
        }

        private void LoadStaff()
        {
            staffGridView.Rows.Clear();
            if (members.Count == 0)
            {
                foreach (var item in DB.getInstance().GetAll("CrewMember"))
                {
                    Entities.CrewMember member = (Entities.CrewMember)item;
                    members.Add(member);
                }
            }
            foreach (var member in members)
            {
                staffGridView.Rows.Add(new object[] {
                            member.FirstName,
                            member.LastName,
                            member.Patronymic,
                            member.BirthDate,
                            member.Role.Name,
                            member.Experience,
                            member.Salary,
                            (member.CurrentShip != null ? member.CurrentShip.Name : "")
                        });
            }
        }

        private void LoadCharterers()
        {
            charterersGridView.Rows.Clear();
            if (charterers.Count == 0)
            {
                foreach (var item in DB.getInstance().GetAll("Charterer"))
                {
                    Entities.Charterer charterer = (Entities.Charterer)item;
                    charterers.Add(charterer);
                }
            }
            foreach (var charterer in charterers)
            {
                charterersGridView.Rows.Add(new object[] {
                            charterer.Name,
                            charterer.Address,
                            charterer.PhoneNumber,
                            charterer.Fax,
                            charterer.Email,
                            charterer.BankName,
                            charterer.BankCity,
                            charterer.BankTIN,
                            charterer.BankAccountNumber
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
                foreach (var item in DB.getInstance().GetAll("GeneralCargoType"))
                {
                    Entities.GeneralCargoType generalCargoType = (Entities.GeneralCargoType)item;
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
                foreach (var item in DB.getInstance().GetAll("Port"))
                {
                    Entities.Port port = (Entities.Port)item;
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
                foreach (var item in DB.getInstance().GetAll("Role"))
                {
                    Entities.Role role = (Entities.Role)item;
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
                foreach (var item in DB.getInstance().GetAll("ShipPurpose"))
                {
                    Entities.ShipPurpose shipPurpose = (Entities.ShipPurpose)item;
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
            DB.getInstance().Delete(charterers[index]);
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
            DB.getInstance().Delete(members[index]);
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
            memberBirthDateLabel.Text = ((DateTime)cells[3].Value).ToString();
            memberRoleLabel.Text = (string)cells[4].Value;
            memberExperienceLabel.Text = ((int)cells[5].Value).ToString();
            memberSalaryLabel.Text = ((int)cells[6].Value).ToString();
            memberShipLabel.Text = !cells[7].Value.Equals("") ? ((Entities.Ship)cells[7].Value).Name : "-";
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
                        generalCargoTypes.Add(new Entities.GeneralCargoType() { Name = newName });
                    else
                        generalCargoTypes[e.RowIndex].Name = newName;
                    DB.getInstance().Save(generalCargoTypes.LastOrDefault());
                    break;
                case 1:
                    if (e.RowIndex >= ports.Count)
                        ports.Add(new Entities.Port() { Name = newName });
                    else
                        ports[e.RowIndex].Name = newName;
                    DB.getInstance().Save(ports.LastOrDefault());
                    break;
                case 2:
                    if (e.RowIndex >= roles.Count)
                        roles.Add(new Entities.Role() { Name = newName });
                    else
                        roles[e.RowIndex].Name = newName;
                    DB.getInstance().Save(roles.LastOrDefault());
                    break;
                case 3:
                    if (e.RowIndex >= shipPurposes.Count)
                        shipPurposes.Add(new Entities.ShipPurpose() { Name = newName });
                    else
                        shipPurposes[e.RowIndex].Name = newName;
                    DB.getInstance().Save(shipPurposes.LastOrDefault());
                    break;
            }

        }

        private void miscGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            DB.getInstance().Delete(generalCargoTypes[e.Row.Index]);
            generalCargoTypes.RemoveAt(e.Row.Index);
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
            DB.getInstance().Delete(ships[index]);
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
            foreach (var member in ships[shipsGridView.SelectedRows[0].Index].Crew)
            {
                shipCrewLabel.Text += member.FirstName[0] + ". " + member.Patronymic[0] + ". " + member.LastName + "\n";
            }
            shipLocationLabel.Text = ((Point)cells[5].Value).ToString();
            shipOverhaulStartDateLabel.Text = ((DateTime)cells[6].Value).ToString();
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
            DB.getInstance().Delete(cruises[index]);
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
            foreach (var portEntry in cruises[cruisesGridView.SelectedRows[0].Index].PortEntries)
                routePointsGridView.Rows.Add(new object[]
                {
                    "",
                    portEntry.Port.Name,
                    portEntry.DestinationPlanned,
                    portEntry.DestinationActual,
                    portEntry.DeparturePlanned,
                    portEntry.DepartureActual,
                    portEntry.DestinationDelayReason,
                    portEntry.DepartureDelayReason,

                });
        }
    }
}
