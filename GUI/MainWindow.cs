using System.Windows.Forms;

namespace rpbd2.GUI
{
    public partial class MainWindow : Form
    {
        public IList<Entities.Cruise> cruises;
        public IList<Entities.Ship> ships;
        public IList<Entities.CrewMember> members;
        public IList<Entities.Charterer> charterers;

        public IList<Entities.Role> roles;

        public MainWindow()
        {
            InitializeComponent();

            charterers = new List<Entities.Charterer>();
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    cruisesGridView.Rows.Clear();
                    foreach (var item in DB.getInstance().GetAll("Cruise"))
                    {
                        Entities.Cruise cruise = (Entities.Cruise)item;
                        cruises.Add(cruise);
                        cruisesGridView.Rows.Add(new object[] {
                            cruise.Ship.Name,
                            cruise.GeneralCargoType.Name,
                            cruise.DeparturePort.Name,
                            cruise.DestinationPort.Name,
                            cruise.Charterer.Name
                        });
                    }
                    break;
                case 1:
                    shipsGridView.Rows.Clear();
                    foreach (var item in DB.getInstance().GetAll("Ship"))
                    {
                        Entities.Ship ship = (Entities.Ship)item;
                        ships.Add(ship);
                        shipsGridView.Rows.Add(new object[] {
                            ship.Name,
                            ship.CarryCapacity,
                            ship.Homeport.Name,
                            ship.Purpose.Name,
                            ship.Location,
                            ship.OverhaulStartDate,
                            ship.CurrentCruise.DeparturePort.Name + " - " + ship.CurrentCruise.DestinationPort.Name,
                        });
                    }
                    break;
                case 2:
                    staffGridView.Rows.Clear();
                    foreach (var item in DB.getInstance().GetAll("CrewMember"))
                    {
                        Entities.CrewMember member = (Entities.CrewMember)item;
                        members.Add(member);
                        _ = staffGridView.Rows.Add(new object[] {
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
                    break;
                case 3:
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
                    break;
            }
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

        private void editCrewMember_FormClosed(object? sender, FormClosedEventArgs e)
        {
            tabControl1_SelectedIndexChanged(null, null);
        }
    }
}