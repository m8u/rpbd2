using IO.Swagger.Model;

namespace rpbd2.GUI
{
    public partial class EditCrewMember : Form
    {
        MainWindow mainWindow;
        CrewMember? member;

        public EditCrewMember(MainWindow mainWindow, CrewMember? member)
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
                firstNameTextBox.Text = member.Firstname;
                lastNameTextBox.Text = member.Lastname;
                patronymicTextBox.Text = member.Patronymic;
                birthDatePicker.Value = DateTime.Parse(member.Birthdate);
                roleComboBox.SelectedIndex = mainWindow.roles.IndexOf(mainWindow.roles.Where(role => role.Id == member.Role).First());
                experienceNumeric.Value = (decimal)member.Experience;
                salaryNumeric.Value = (decimal)member.Salary;
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (member == null)
            {
                mainWindow.members.Add(new CrewMember());
                member = mainWindow.members.LastOrDefault();
            }
            member.Firstname = firstNameTextBox.Text;
            member.Lastname = lastNameTextBox.Text;
            member.Patronymic = patronymicTextBox.Text;
            member.Birthdate = birthDatePicker.Value.ToShortDateString();
            member.Role = mainWindow.roles[roleComboBox.SelectedIndex].Id;
            member.Experience = (int)experienceNumeric.Value;
            member.Salary = (int)salaryNumeric.Value;

            mainWindow.crewMembersApi.AddOrUpdateCrewMember(member);

            Close();
        }
    }
}
