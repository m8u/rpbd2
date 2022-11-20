namespace rpbd2
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new GUI.MainWindow());
        }
    }
}