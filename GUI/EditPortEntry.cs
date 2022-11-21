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
    public partial class EditPortEntry : Form
    {
        EditCruise editCruiseWindow;

        public EditPortEntry(EditCruise editCruiseWindow)
        {
            InitializeComponent();

            this.editCruiseWindow = editCruiseWindow;

            foreach (var port in editCruiseWindow.mainWindow.ports)
                portComboBox.Items.Add(port.Name);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            editCruiseWindow.portEntriesGridView.Rows.Add(new object[]
            {
                editCruiseWindow.mainWindow.ports[portComboBox.SelectedIndex],
                destinationPicker.Value,
                departurePicker.Value
            });
        }
    }
}
