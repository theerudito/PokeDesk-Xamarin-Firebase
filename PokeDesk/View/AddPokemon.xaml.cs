using ALL.ViewModel.VMPokemon;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ALL.View.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPokemon : ContentPage
    {
        public AddPokemon()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new VMAddPokemon(Navigation);
        }
    }
}