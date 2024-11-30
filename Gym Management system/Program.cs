using Gym_Management_system.Database;

namespace Gym_Management_system
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            LoginForm loginForm = new LoginForm();
            Application.Run(loginForm);

            if (loginForm.Auth)
            {
                Application.Run(new MainForm(loginForm.Username, loginForm.UserType, loginForm.UserId));
            }
            

        }
    }
}