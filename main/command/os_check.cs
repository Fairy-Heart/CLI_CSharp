using System.Runtime.InteropServices;

namespace os_check 
{
    public class os_checked
    {
        public static bool Sys_Check()
        {
            // bool isWindows = 
            // bool isMacOs = RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
            // bool isLinux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
            // bool isBDS = RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD);

            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Your System is : ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" [WINDOWS]\n");
                Console.ResetColor();
                return true;
            } else if(RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Your System is : ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" [MAC OS]\n");
                Console.ResetColor();
                return true;
            } else if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Your System is : ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" [LINUX]\n");
                Console.ResetColor();
                return true;
            } else if(RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD)) {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Your System is : ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" [FREE BSD]\n");
                Console.ResetColor();
                return true;
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Your System Is : Undefine Operating System\n");
                Console.ResetColor();
            }
            return false;
        }
    }
}