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
    public partial class EditCharterer : Form
    {
        MainWindow mainWindow;
        Entities.Charterer? charterer;

        public EditCharterer(MainWindow mainWindow, Entities.Charterer? charterer)
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
                phoneNumberTextBox.Text = charterer.PhoneNumber;
                faxTextBox.Text = charterer.Fax;
                emailTextBox.Text = charterer.Email;
                bankNameTextBox.Text = charterer.BankName;
                bankCityTextBox.Text = charterer.BankCity;
                tinTextBox.Text = charterer.BankTIN;
                accountNumberTextBox.Text = charterer.BankAccountNumber;
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (charterer == null)
            {
                mainWindow.charterers.Add(new Entities.Charterer());
                charterer = mainWindow.charterers.LastOrDefault();
            }
            charterer.Name = nameTextBox.Text;
            charterer.Address = addressTextBox.Text;
            charterer.PhoneNumber = phoneNumberTextBox.Text;
            charterer.Fax = faxTextBox.Text;
            charterer.Email = emailTextBox.Text;
            charterer.BankName = bankNameTextBox.Text;
            charterer.BankCity = bankCityTextBox.Text;
            charterer.BankTIN = tinTextBox.Text;
            charterer.BankAccountNumber = accountNumberTextBox.Text;

            DB.getInstance().FlushAsync();

            Close();
        }
    }
}
