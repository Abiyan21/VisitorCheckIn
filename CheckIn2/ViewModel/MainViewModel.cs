using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VisitorCheckIn.Utility;
using VisitorCheckIn.View;

namespace VisitorCheckIn.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private RelayCommand _languageEN;
        private RelayCommand _languageDE;
        private RelayCommand _languageFR;


        public RelayCommand LanguageEN
        {
            get
            {
                return _languageEN;
            }
        }

        public RelayCommand LanguageDE
        {
            get { return _languageDE; }
        }

        public RelayCommand LanguageFR
        {
            get { return _languageFR; }
        }

        public MainViewModel()
        {
            _languageDE = new RelayCommand(param => Execute_LanguageDE(), param => CanExecute_LanguageDE());
            _languageFR = new RelayCommand(param => Execute_LanguageFR(), param => CanExecute_LanguageFR());
            _languageEN = new RelayCommand(param => Execute_LanguageEN(), param => CanExecute_LanguageEN());
        }

        private void Execute_LanguageEN()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("EN");
            changewindow();
        }

        private bool CanExecute_LanguageEN()  
        {
            return true;
        }

        private void Execute_LanguageDE()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("DE");
            changewindow();
        }

        private bool CanExecute_LanguageDE()
        {
            return true;
        }

        private void Execute_LanguageFR()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("FR");
            changewindow();
        }

        private bool CanExecute_LanguageFR()
        {
            return true;
        }

        private void changewindow()
        {
            foreach (Window item in Application.Current.Windows)
            {
                if (item.IsActive)
                {
                    InfoWindow infoW = new InfoWindow();
                    item.Close();
                    infoW.Show(); 
                }
            }

            

        }
    }
}
