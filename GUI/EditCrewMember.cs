namespace rpbd2.GUI
{
    public partial class EditCrewMember : Form
    {
        MainWindow mainWindow;
        Entities.CrewMember? member;

        public EditCrewMember(MainWindow mainWindow, Entities.CrewMember? member)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
            this.member = member;

            foreach (var role in mainWindow.roles)
                roleComboBox.Items.Add(role.Name);

            if (member == null)
            {
                Text = "New member";
                applyButton.Text = "Create";
            }
            else
            {
                firstNameTextBox.Text = member.FirstName;
                lastNameTextBox.Text = member.LastName;
                patronymicTextBox.Text = member.Patronymic;
                birthDatePicker.Value = member.BirthDate;
                roleComboBox.SelectedIndex = mainWindow.roles.IndexOf(member.Role);
                experienceNumeric.Value = member.Experience;
                salaryNumeric.Value = member.Salary;
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (member == null)
            {
                mainWindow.members.Add(new Entities.CrewMember());
                member = mainWindow.members.LastOrDefault();
                DB.getInstance().Save(member);
            }
            member.FirstName = firstNameTextBox.Text;
            member.LastName = lastNameTextBox.Text;
            member.Patronymic = patronymicTextBox.Text;
            member.BirthDate = birthDatePicker.Value;
            member.Role = mainWindow.roles[roleComboBox.SelectedIndex];
            member.Experience = (int)experienceNumeric.Value;
            member.Salary = (int)salaryNumeric.Value;

            DB.getInstance().FlushAsync();

            Close();
        }
    }
}
