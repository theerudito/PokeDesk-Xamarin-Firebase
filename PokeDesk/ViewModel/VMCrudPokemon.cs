using ALL.Data;
using ALL.Model;
using ALL.View.Pokemon;
using MvvmGuia.VistaModelo;
using PokeDesk.View;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System;

namespace ALL.ViewModel.VMPokemon
{
    public class VMCrudPokemon : BaseViewModel
    {

        #region VARIABLES
        ObservableCollection<Pokemon> _Lista_pokemons;
        //List<Pokemon> _Lista_pokemons;
        #endregion

        #region CONSTRUCTOR
        public VMCrudPokemon(INavigation navigation)
        {
            Navigation = navigation;
            Mostrar_Pokemons();
        }
        #endregion

        #region OBJETOS
        public ObservableCollection<Pokemon> Lista_pokemons
        {
            get { return _Lista_pokemons; }
            set
            {
                SetValue(ref _Lista_pokemons, value);
                OnpropertyChanged();
            }
        }
        //public List<Pokemon> Lista_pokemons
        //{
        //    get { return _Lista_pokemons; }
        //    set
        //    {
        //        SetValue(ref _Lista_pokemons, value);

        //    }
        //}

        #endregion

        #region METODOS ASYNC
        public async Task openAddPokemon()
        {
            await Navigation.PushAsync(new AddPokemon());
        }

        public async Task goDetailPokemon(Pokemon pokemon)
        {
            await Navigation.PushAsync(new DetailsPokemon(pokemon));
        }

        public async Task Mostrar_Pokemons()
        {
            var function = new DataFirebase();

            Lista_pokemons = await function.GetPokemons();
        }
        #endregion

        #region COMANDOS
        public ICommand btnGoADDPokemonCommand => new Command(async () => await openAddPokemon());
        public ICommand btnGoDetailPokemonCommand => new Command<Pokemon>(async (p) => await goDetailPokemon(p));
        #endregion
    }
}
