using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShowCase.ViewModel
{
    public class InicioViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }

        public Command CamaraCommand { get; set; }
        public Command GpsCommand { get; set; }

        private bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy = false; }
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }

        public InicioViewModel()
        {
            //CamaraCommand = new Command(async () => await Guardar(), () => !IsBusy);
            //GpsCommand = new Command(async () => await Modificar(), () => !IsBusy);
        }
    }
}
