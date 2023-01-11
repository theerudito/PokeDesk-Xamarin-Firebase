using ALL.Data;
using ALL.Model;
using ALL.View;
using ALL.View.Pokemon;
using MvvmGuia.VistaModelo;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ALL.ViewModel.VMPokemon
{
    public class VMAddPokemon : BaseViewModel
    {

        #region VARIABLES
        string _TextNombre;
        string _TextColorFondo;
        string _TextNumPokemon;
        string _TextIcono;
        string _TextPower;
        string _TextColorPoder;

        #endregion

        #region CONSTRUCTOR
        public VMAddPokemon(INavigation navigation)
        {
            Navigation = navigation;
        }

        #endregion

        #region OBJETOS
        public string TextNombre
        {
            get { return _TextNombre; }
            set { SetValue(ref _TextNombre, value); }
        }
        public string TextColorFondo
        {
            get { return _TextColorFondo; }
            set { SetValue(ref _TextColorFondo, value); }
        }
        public string TextNumPokemon
        {
            get { return _TextNumPokemon; }
            set { SetValue(ref _TextNumPokemon, value); }
        }
        public string TextIcono
        {
            get { return _TextIcono; }
            set { SetValue(ref _TextIcono, value); }
        }
        public string TextPower
        {
            get { return _TextPower; }
            set { SetValue(ref _TextPower, value); }
        }

        public string TextColorPoder
        {
            get { return _TextColorPoder; }
            set { SetValue(ref _TextColorPoder, value); }
        }


        #endregion

        #region METODOS ASYNC
        public async Task Volver()
        {
            await Navigation.PushAsync(new CrudPokemon());
        }

        public async Task Insert()
        {
            var function = new DataFirebase();

            var parametros = new Pokemon();
            parametros.Nombre = TextNombre;
            parametros.ColorFondo = TextColorFondo;
            parametros.NPokemon = TextNumPokemon;
            parametros.Icono = TextIcono;
            parametros.Poder = TextPower;
            parametros.ColorPoder = TextColorPoder;


            await function.InsertPokemon(parametros);
            await Volver();
        }
        #endregion



        #region COMANDOS
        public ICommand btnBack => new Command(async () => await Volver());
        public ICommand addNewPokemon => new Command(async () => await Insert());
        #endregion
    }
}
