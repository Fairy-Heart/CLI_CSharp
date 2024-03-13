using System.Management;
using System.Runtime.InteropServices;

namespace command 
{

    public class InfoSystem 
    {      
        public void SysName()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("System Name : ", Console.ForegroundColor);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(Environment.MachineName + "\n", Console.ForegroundColor);
            Console.ResetColor();
        }

        public void SysBits()
        {
            if(Environment.Is64BitProcess == true) 
            {   Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("System Operating Type : ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("64-bit\n");
                Console.ResetColor();
            } else 
            {   
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("System Operating Type : ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("32-bit\n");
                Console.ResetColor();
            }
        }

        public void Processor()
        {
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                ManagementObjectSearcher Processor = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
                foreach (ManagementObject Processors in Processor.Get())
                {   
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("System Processor : ");
                    Console.ResetColor();
                    
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(Processors["Name"] + "\n");
                    Console.ResetColor();
                }
            }
        }
      
        public void MemoryInfo() 
        {
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                ObjectQuery Object = new("SELECT * FROM Win32_OperatingSystem");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(Object);
                ManagementObjectCollection results = searcher.Get();

                foreach(ManagementObject result in results)
                {
                    ulong VisibleMemory = Convert.ToUInt64(result["TotalVisibleMemorySize"]);
                    string FormatVisibleMemory = string.Format("{0:n0}", VisibleMemory);
                    
                    ulong FreePhysicalMemory = Convert.ToUInt64(result["FreePhysicalMemory"]);
                    string FormayPhysicalMemory = string.Format("{0:n0}",FreePhysicalMemory);

                    ulong TotalVirtualMemorySize = Convert.ToUInt64(result["TotalVirtualMemorySize"]);
                    string FormatVirtualMemorySize = string.Format("{0:n0}", TotalVirtualMemorySize);
                    

                    ulong FreeVirtualMemorySize = Convert.ToUInt64(result["FreeVirtualMemory"]);
                    string FormatFreeVirtualMemorySize = string.Format("{0:n0}", FreeVirtualMemorySize);


                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Total Visible Memory : ");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(FormatVisibleMemory + " KiB\n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Total Physical Memory : ");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(FormayPhysicalMemory + " KiB" +"\n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Total Virtual Memory : ");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(FormatVirtualMemorySize + " KiB" + "\n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Free Virtual Memory : ");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(FormatFreeVirtualMemorySize + " KiB" + "\n");
                    Console.ResetColor();
                    
                }
            }
        }
    }

    public class SystemInfomation {
        public void SystemInfo() {
            InfoSystem ObjectSystem = new InfoSystem();
            ObjectSystem.SysName();
            ObjectSystem.SysBits();
            ObjectSystem.Processor();
            ObjectSystem.MemoryInfo();
        }
    }
}

