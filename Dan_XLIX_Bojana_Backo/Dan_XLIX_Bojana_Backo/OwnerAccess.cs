using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Dan_XLIX_Bojana_Backo
{
    public class OwnerAccess
    {
        public static string fileOwnerAccess = @"..\..\OwnerAccess.txt";

        /// <summary>
        /// Function that write to file username and password for the owner
        /// </summary>
        public static void AddToFile()
        {
            try
            {
                File.Delete(fileOwnerAccess);
                var hash = SecurePasswordHasher.Hash("Vlasnik2020");
                using(StreamWriter sw = File.CreateText(fileOwnerAccess))
                {
                    sw.WriteLine("Vlasnik2020");
                    sw.WriteLine(hash);
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show($"The file was not found: '{e}'");
            }
            catch(IOException e)
            {
                MessageBox.Show($"The file could not be opened: '{e}'");
            }
        }
    }
}
