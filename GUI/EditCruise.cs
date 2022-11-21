using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpbd2.GUI
{
    public partial class EditCruise : Form
    {
        public MainWindow mainWindow;
        Entities.Cruise cruise;

        public EditCruise(MainWindow mainWindow, Entities.Cruise cruise)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
            this.cruise = cruise;

            foreach (var ship in mainWindow.ships)
                shipComboBox.Items.Add(ship.Name);
            foreach (var generalCargoType in mainWindow.generalCargoTypes)
                generalCargoTypeComboBox.Items.Add(generalCargoType.Name);
            foreach (var charterer in mainWindow.charterers)
                chartererComboBox.Items.Add(charterer.Name);
            foreach (var port in mainWindow.ports)
            {
                departurePortComboBox.Items.Add(port.Name);
                destinationPortComboBox.Items.Add(port.Name);
            }

            if (cruise == null)
            {
                Text = "New cruise";
                applyButton.Text = "Create";
            }
            else
            {
                shipComboBox.SelectedIndex = mainWindow.ships.IndexOf(cruise.Ship);
                generalCargoTypeComboBox.SelectedIndex = mainWindow.generalCargoTypes.IndexOf(cruise.GeneralCargoType);
                departurePortComboBox.SelectedIndex = mainWindow.ports.IndexOf(cruise.DeparturePort);
                destinationPortComboBox.SelectedIndex = mainWindow.ports.IndexOf(cruise.DestinationPort);
                chartererComboBox.SelectedIndex = mainWindow.charterers.IndexOf(cruise.Charterer);
            }
        }

        private void addPortEntryButton_Click(object sender, EventArgs e)
        {
            EditPortEntry editPortEntry = new EditPortEntry(this);
            editPortEntry.Show();
            editPortEntry.FormClosed += editPortEntry_FormClosed;
        }

        private void editPortEntry_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (cruise == null)
            {
                mainWindow.cruises.Add(new Entities.Cruise());
                cruise = mainWindow.cruises.LastOrDefault();
                DB.getInstance().Save(cruise);
            }
            cruise.Ship = mainWindow.ships[shipComboBox.SelectedIndex];
            cruise.GeneralCargoType = mainWindow.generalCargoTypes[shipComboBox.SelectedIndex];
            cruise.DeparturePort = mainWindow.ports[departurePortComboBox.SelectedIndex];
            cruise.DestinationPort = mainWindow.ports[destinationPortComboBox.SelectedIndex];
            cruise.Charterer = mainWindow.charterers[chartererComboBox.SelectedIndex];

            var db = DB.getInstance();
            foreach (var portEntry in cruise.PortEntries)
                db.Delete(portEntry);
            cruise.PortEntries.Clear();
            for (int i = 0; i < portEntriesGridView.RowCount; i++)
            {
                cruise.PortEntries.Add(new Entities.PortEntry()
                {
                    Port = (Entities.Port)portEntriesGridView.Rows[i].Cells[0].Value,
                    DestinationPlanned = (DateTime)portEntriesGridView.Rows[i].Cells[1].Value,
                    DeparturePlanned = (DateTime)portEntriesGridView.Rows[i].Cells[2].Value,
                });
            }

            DB.getInstance().FlushAsync();

            Close();
        }
    }
}
