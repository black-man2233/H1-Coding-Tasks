using BankSystem.Utilities;
using System;
using System.Windows;
using System.Windows.Input;
using static BankSystem.Utilities.RelayCommands;

namespace BankSystem.ViewModels
{
    class NavigationVM : ViewModelBase
    {
        private object _currentView = new UserProfileVM();
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand HomeCommand { get; set; }
        public ICommand ProfileCommand { get; set; }
        public ICommand CloseCommand { get; set; }

        private void Home(Object obj) => CurrentView = new HomeVM();
        private void Profile(Object obj) => CurrentView = new UserProfileVM();
        private void Close(Object obj)
        {
            if (obj is Window w)
                w.Close();
        }

        public NavigationVM()
        {
            HomeCommand = new RelayCommand(Home);
            ProfileCommand = new RelayCommand(Profile);
            CloseCommand = new RelayCommand(Close);


            //Startup Page
            this.CurrentView = new HomeVM();
        }
    }
}
