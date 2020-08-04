using Dan_XLIX_Bojana_Backo.Command;
using Dan_XLIX_Bojana_Backo.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Dan_XLIX_Bojana_Backo.ViewModel
{
    class AddManagerViewModel : ViewModelBase
    {
        AddManager addManager;
        Service service = new Service();

        public AddManagerViewModel(AddManager addManagerOpen)
        {
            addManager = addManagerOpen;
        }

        #region Properties
        private tblManager manager;
        public tblManager Manager
        {
            get
            {
                return manager;
            }
            set
            {
                manager = value;
                OnPropertyChanged("Manager");
            }
        }
        #endregion

        #region Commans
        private ICommand save;
        public ICommand Save
        {
            get
            {
                if (save == null)
                {
                    save = new RelayCommand(param => SaveExecute(), param => CanSaveExecute());
                }
                return save;
            }
        }
        private void SaveExecute()
        {
            try
            {
                LoginScreen login = new LoginScreen();
                service.AddManager(Manager);
                addManager.Close();
                login.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CanSaveExecute()
        {
            return true;
        }
        #endregion
    }
}
