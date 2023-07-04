using System.Diagnostics;
using System.Security.Principal;

namespace MainForm;

public static class RequestAdministrator
{
    public static bool request = false;
}
internal static class Program
{
    static bool IsAdministrator()
    {
        var identity = WindowsIdentity.GetCurrent();
        var principal = new WindowsPrincipal(identity);

        return principal.IsInRole(WindowsBuiltInRole.Administrator);
    }
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
        AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);

        if (args.Length > 0 && args[0] == "admin")
        {
            RequestAdministrator.request = true;
        }
        else if (IsAdministrator() == false)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName, "admin");
            startInfo.UseShellExecute = true;
            startInfo.Verb = "runas";
            System.Diagnostics.Process.Start(startInfo);
            return; // Exit the current process without launching the application
        }

        RequestAdministrator.request = false;
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new SoundSwapMainForm());
    }

}