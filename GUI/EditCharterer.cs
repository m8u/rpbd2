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
    public partial class EditCharterer : Form
    {
        MainWindow mainWindow;
        Charterer? charterer;

        public EditCharterer(MainWindow mainWindow, Charterer? charterer)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
            this.charterer = charterer;
            if (charterer == null)
            {
                Text = "New charterer";
                applyButton.Text = "Create";
            } else
            {
                nameTextBox.Text = charterer.Name;
                addressTextBox.Text = charterer.Address;
                phoneNumberTextBox.Text = charterer.Phonenumber;
                faxTextBox.Text = charterer.Fax;
                emailTextBox.Text = charterer.Email;
                bankNameTextBox.Text = charterer.Bankname;
                bankCityTextBox.Text = charterer.Bankcity;
                tinTextBox.Text = charterer.Tin;
                accountNumberTextBox.Text = charterer.Bankaccount;
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (charterer == null)
            {
                mainWindow.charterers.Add(new Charterer());
                charterer = mainWindow.charterers.LastOrDefault();
            }
            charterer.Name = nameTextBox.Text;
            charterer.Address = addressTextBox.Text;
            charterer.Phonenumber = phoneNumberTextBox.Text;
            charterer.Fax = faxTextBox.Text;
            charterer.Email = emailTextBox.Text;
            charterer.Bankname = bankNameTextBox.Text;
            charterer.Bankcity = bankCityTextBox.Text;
            charterer.Tin = tinTextBox.Text;
            charterer.Bankaccount = accountNumberTextBox.Text;

            mainWindow.charterersApi.AddOrUpdateCharterer(charterer);

            Close();
        }
    }
}
