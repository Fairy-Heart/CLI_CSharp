using System;
using command;


namespace fav 
{
    public class MainApplication 
    {
        public static void Main(string[] args)
        {


            SystemInfomation SystemObject = new SystemInfomation();

            if(args.Length > 0)            
            {
                switch(args[0])
                {
                    case "--systeminfo":
                    SystemObject.SystemInfo();
                    break;

                }
            }
            
            if(args.Length == 0)
            {
               Console.WriteLine("Try fav --help to show all command");
            }
        }
    }
}