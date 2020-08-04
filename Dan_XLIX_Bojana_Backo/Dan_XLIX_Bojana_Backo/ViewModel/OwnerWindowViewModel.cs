﻿using Dan_XLIX_Bojana_Backo.Command;
using Dan_XLIX_Bojana_Backo.View;
using System;
using System.Windows;
using System.Windows.Input;

namespace Dan_XLIX_Bojana_Backo.ViewModel
{
    class OwnerWindowViewModel : ViewModelBase
    {
        OwnerWindow ownerWindow;

        public OwnerWindowViewModel(OwnerWindow ownerWindowOpen)
        {
            ownerWindow = ownerWindowOpen;
        }

        private ICommand addManager;
        public ICommand AaddManager
        {
            get
            {
                if (addManager == null)
                {
                    addManager = new RelayCommand(param => AddManagerExecute(), param => CanAddManagerExecute());
                }
                return addManager;
            }
        }
        private void AddManagerExecute()
        {
            try
            {
                AddManager addManager = new AddManager();
                ownerWindow.Close();
                addManager.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool CanAddManagerExecute()
        {
            return true;
        }
    }
}
