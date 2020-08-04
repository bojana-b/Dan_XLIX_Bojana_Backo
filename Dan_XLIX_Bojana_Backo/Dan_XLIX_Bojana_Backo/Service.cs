using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_XLIX_Bojana_Backo
{
    class Service
    {
        /// <summary>
        /// Method that add manager to database
        /// </summary>
        /// <param name="manager"></param>
        public void AddManager(tblManager manager)
        {
            try
            {
                using (HotelDBEntities context = new HotelDBEntities())
                {
                    tblManager newManager = new tblManager();
                    newManager.Name = manager.Name;
                    newManager.Surname = manager.Surname;
                    newManager.DateOfBirth = DateTime.Now;
                    newManager.Email = manager.Email;
                    newManager.Username = manager.Username;
                    newManager.Password = manager.Password;
                    newManager.Floor = manager.Floor;
                    newManager.Experience = manager.Experience;
                    newManager.Qualifications = manager.Qualifications;

                    context.tblManagers.Add(newManager);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
            }
        }
    }
}
