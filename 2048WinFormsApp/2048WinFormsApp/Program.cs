namespace _2048WinFormsApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var registrationForm = new RegistrationForm();
            Application.Run(registrationForm);
            var user = registrationForm.User;
            Application.Run(new MainForm(user));
        }
    }
}