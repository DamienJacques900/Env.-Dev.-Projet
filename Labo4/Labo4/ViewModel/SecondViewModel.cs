using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Labo4.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;

namespace Labo4.ViewModel
{
    public class SecondViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public Student SelectedStudent
        {
            get;
            set;
        }

        private INavigationService _navigatoinService;
        [PreferredConstructor]
        public SecondViewModel(INavigationService navigationService = null)
        {
            _navigatoinService = navigationService;
        }

        public void OnNavigatedTo(NavigationEventArgs e)
        {
            SelectedStudent = (Student)e.Parameter;
        }
    }
}
