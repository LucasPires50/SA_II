using Plugin.Media;
using SA2.Models;
using SA2.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SA2.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private string mensagem;
        public string Mensagem
        {
            get { return mensagem; }
            set { SetProperty<string>(ref mensagem, value); }
        }

        private string mensagemDesBank;
        public string MensagemDesBank
        {
            get { return mensagemDesBank; }
            set { SetProperty<string>(ref mensagemDesBank, value); }
        }

        private ImageSource _foto;
        public ImageSource Foto
        {
            get { return _foto; }
            set { SetProperty<ImageSource>(ref _foto, value); }
        }

        public ICommand EntrarCommand { get; }
        public ICommand CadastrarCommand { get; }

        public ICommand ContinuarCommand { get; }

        public ICommand VoltarCommand { get; }

        public ICommand TirarFoto { get; }
        public MainPageViewModel(Page pagina) : base(pagina)
        {

            Mensagem = "Bem Vindo!";
            MensagemDesBank = "DesBank";

            EntrarCommand = new Command(ExecuteEntrarCommand);
            CadastrarCommand = new Command(ExecuteCadastrarCommand);
            ContinuarCommand = new Command(ExecuteContinuarCommand);
            VoltarCommand = new Command(ExecuteVoltarCommand);
            TirarFoto = new Command(ExecuteTirarFoto);

        }

        private async void ExecuteTirarFoto()
        {

                await CrossMedia.Current.Initialize();

                if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                {
                await _pagina.DisplayAlert("No Camera", ":( No camera available.", "OK");
                    return;
                }

                var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
                {
                    Directory = "Sample",
                    Name = "test.jpg"
                });

                if (file == null)
                    return;

                await _pagina.DisplayAlert("File Location", file.Path, "OK");

                Foto = ImageSource.FromStream(() =>
                {
                    var stream = file.GetStream();
                    return stream;
                });
            

        }
       
        private async void ExecuteEntrarCommand()
        {
            LoginPage page = new LoginPage(Cliente);
            await _navigation.PushModalAsync(page);
        }

        private async void ExecuteCadastrarCommand()
        {
            CadastroUsuarioPage page = new CadastroUsuarioPage(Cliente);
            await _navigation.PushModalAsync(page);
        }

        private async void ExecuteContinuarCommand()
        {
            IdentificacaoPage page = new IdentificacaoPage(Cliente);
            await _navigation.PushModalAsync(page);
        }

        private async void ExecuteVoltarCommand()
        {
            ConcluidoPage page = new ConcluidoPage(Cliente);
            await _navigation.PushModalAsync(page);
        }
    }
}
