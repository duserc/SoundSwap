using System;
using System.Management;

public class StartupManager
{
    public static void SetStartupStatus(string appName, bool isEnabled)
    {
        string query = $"SELECT * FROM Win32_StartupCommand WHERE Name = '{appName}'";
        using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
        {
            foreach (ManagementObject startupEntry in searcher.Get())
            {
                // Modify the startup entry's Status property (0 = Disabled, 1 = Enabled)
                startupEntry.SetPropertyValue("Status", isEnabled ? 1 : 0);
                startupEntry.Put(); // Save the changes

                // Optionally, you can execute the startup entry immediately (if enabled)
                if (isEnabled)
                {
                    startupEntry.InvokeMethod("DoCall");
                }
            }
        }
    }
}
