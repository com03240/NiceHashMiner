using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace CheckDependenciesMaster
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var listOfBaits = new List<string> { "CheckDependencies2015.exe", "CheckDependencies2017.exe", "CheckDependencies2019.exe" };
                foreach(var bait in listOfBaits)
                {
                    using(var pr = new Process())
                    {
                        pr.StartInfo = new ProcessStartInfo
                        {
                            UseShellExecute = false,
                            CreateNoWindow = true,
                            FileName = bait

                        };

                        pr.Start();
                        pr.WaitForExit();
                    }
                }                
            }
            catch (Exception se)
            {
                Console.WriteLine($"Exception: {se.Message}");
            }
        }

    }
}
