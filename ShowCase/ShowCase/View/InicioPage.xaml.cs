using ShowCase.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShowCase.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicioPage : ContentPage
    {
        InicioViewModel Contexto = new InicioViewModel();

        public InicioPage()
        {
            InitializeComponent();
            BindingContext = Contexto;
        }
    }
}
