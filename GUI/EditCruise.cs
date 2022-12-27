using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IO.Swagger.Model;

namespace rpbd2.GUI
{
    public partial class EditCruise : Form
    {
        public MainWindow mainWindow;
        Cruise cruise;

        public EditCruise(MainWindow mainWindow, Cruise cruise)
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
                shipComboBox.SelectedIndex = mainWindow.ships.IndexOf(mainWindow.ships.Where(ship => ship.Id == cruise.Ship).First());
                generalCargoTypeComboBox.SelectedIndex = mainWindow.generalCargoTypes.IndexOf(mainWindow.generalCargoTypes.Where(generalCargoType => generalCargoType.Id == cruise.Generalcargotype).First());
                departurePortComboBox.SelectedIndex = mainWindow.ports.IndexOf(mainWindow.ports.Where(port => port.Id == cruise.Departureport).First());
                destinationPortComboBox.SelectedIndex = mainWindow.ports.IndexOf(mainWindow.ports.Where(port => port.Id == cruise.Destinationport).First());
                chartererComboBox.SelectedIndex = mainWindow.charterers.IndexOf(mainWindow.charterers.Where(charterer => charterer.Id == cruise.Charterer).First());
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
                mainWindow.cruises.Add(new Cruise());
                cruise = mainWindow.cruises.LastOrDefault();
            }
            cruise.Ship = mainWindow.ships[shipComboBox.SelectedIndex].Id;
            cruise.Generalcargotype = mainWindow.generalCargoTypes[shipComboBox.SelectedIndex].Id;
            cruise.Departureport = mainWindow.ports[departurePortComboBox.SelectedIndex].Id;
            cruise.Destinationport = mainWindow.ports[destinationPortComboBox.SelectedIndex].Id;
            cruise.Charterer = mainWindow.charterers[chartererComboBox.SelectedIndex].Id;


            foreach (var portEntry in cruise.Portentries)
            {
                portEntry.Cruise = 0;
                mainWindow.portEntriesApi.AddOrUpdatePortEntry(portEntry);
            }
            cruise.Portentries.Clear();

            for (int i = 0; i < portEntriesGridView.RowCount; i++)
            {
                var portEntry = new PortEntry()
                {
                    Port = ((Port)portEntriesGridView.Rows[i].Cells[0].Value).Id,
                    Cruise = cruise.Id,
                    Destinationdateplanned = (DateTime)portEntriesGridView.Rows[i].Cells[1].Value,
                    Departuredateplanned = (DateTime)portEntriesGridView.Rows[i].Cells[2].Value,
                };
                cruise.Portentries.Add(portEntry);
                mainWindow.portEntriesApi.AddOrUpdatePortEntry(portEntry);
            }

            mainWindow.cruisesApi.AddOrUpdateCruise(cruise);

            Close();
        }
    }
}
