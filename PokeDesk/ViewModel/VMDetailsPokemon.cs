using ALL.Model;
using ALL.View;
using MvvmGuia.VistaModelo;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PokeDesk.ViewModel
{
    public class VMDetailsPokemon : BaseViewModel
    {

        #region VARIABLES
        public Pokemon pokemonRecibe { get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMDetailsPokemon(INavigation navigation, Pokemon pokemon)
        {
            Navigation = navigation;
            pokemonRecibe = pokemon;
        }
        #endregion

        #region OBJETOS

        #endregion

        #region METODOS ASYNC
        public async Task goBackOtra()
        {
            await Navigation.PushAsync(new CrudPokemon());

        }
        #endregion

        #region METODOS SIMPLE
        public void go()
        {
        }
        #endregion


        #region COMANDOS
        public ICommand btnBack => new Command(async () => await goBackOtra());
        #endregion
    }
}
