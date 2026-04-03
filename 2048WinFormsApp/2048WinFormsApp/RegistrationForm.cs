using _2048ClassLibrary;

namespace _2048WinFormsApp
{
    public partial class RegistrationForm : Form
    {
        public User User;
        private string userName;
        public RegistrationForm()
        {
            InitializeComponent();
        }
        private bool RegistrateUser()
        {
            if (!InputValidator.CheckNameIsValid(userName, out string lastNameErrorMessage))
            {
                errorLabel.Text = lastNameErrorMessage;
                errorLabel.Visible = true;
                return false;
            }
            var normalizedName = InputValidator.NormalizeName(userName);
            if (!ConfirmName(normalizedName))
            {
                return false;
            }
            User = new User(normalizedName);
            return true;
        }
        private bool ConfirmName(string userName)
        {
            DialogResult result = MessageBox.Show
                (
                $"Вы ввели {userName}. Подтверждаешь ввод?",
                "Подтверждение ввода",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            return result == DialogResult.Yes;
        }
        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            userName = userNameTextBox.Text;
            if (!InputValidator.CheckNameIsValid(userName, out string errorMessage))
            {
                errorLabel.Text = errorMessage;
                errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Visible = false;
            }
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!RegistrateUser())
            {
                return;
            }
            Close();
        }
    }
}
