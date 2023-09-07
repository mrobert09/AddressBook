namespace AddressBookUI
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

            // Initialize the connections
            AddressBookLibrary.GlobalConfig.InitializeConnections(true);

            Application.Run(new EditEntryForm());
        }
    }
}