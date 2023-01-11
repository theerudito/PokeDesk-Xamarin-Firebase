using ALL.Model;
using PokeDesk.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PokeDesk.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPokemon : ContentPage
    {
        public DetailsPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            BindingContext = new VMDetailsPokemon(Navigation, pokemon);
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}