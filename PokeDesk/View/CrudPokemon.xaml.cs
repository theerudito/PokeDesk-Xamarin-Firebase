using ALL.ViewModel.VMPokemon;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ALL.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CrudPokemon : ContentPage
    {

        public CrudPokemon()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new VMCrudPokemon(Navigation);
        }

    }
}