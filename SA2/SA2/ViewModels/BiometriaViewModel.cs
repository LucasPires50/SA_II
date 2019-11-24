using Plugin.Media;
using SA2.Models;
using SA2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SA2.ViewModels
{
    public class BiometriaViewModel : BaseViewModel
    {
        private string mensagemDigitalizar;
        public string MensagemDigitalizar
        {
            get { return mensagemDigitalizar; }
            set { SetProperty<string>(ref mensagemDigitalizar, value); }
        }

        private ImageSource _selfie;
        public ImageSource Selfie
        {
            get { return _selfie; }
            set { SetProperty<ImageSource>(ref _selfie, value); }
        }

        private ImageSource _rg_ou_cnh;
        public ImageSource Rg_Ou_CNH
        {
            get { return _rg_ou_cnh; }
            set { SetProperty<ImageSource>(ref _rg_ou_cnh, value); }
        }

        private ImageSource _comprovante_residencia;
        public ImageSource Comprovante_Residencia
        {
            get { return _comprovante_residencia; }
            set { SetProperty<ImageSource>(ref _comprovante_residencia, value); }
        }

        private ImageSource _valor_da_renda;
        public ImageSource Valor_Da_Renda
        {
            get { return _valor_da_renda; }
            set { SetProperty<ImageSource>(ref _valor_da_renda, value); }
        }

        public ICommand ContinuarCommand { get; }

        public ICommand TirarFoto_Selfie { get; }

        public ICommand TirarFotoRG_CNH { get; }

        public ICommand TirarFotoComprovante_Residencia { get; }

        public ICommand TirarFotoValor_Da_Renda { get; }
        public BiometriaViewModel(Page pagina, ClienteModel cliente) : base(pagina)
        {
            MensagemDigitalizar = "Vamos digitalizar seus documentos";

            Cliente = cliente;

            Selfie = null;
            Rg_Ou_CNH = null;
            Comprovante_Residencia = null;
            Valor_Da_Renda = null;
            ContinuarCommand = new Command(ExecuteContinuarCommand);
            VoltarCommand = new Command(ExecuteVoltarCommand);
            TirarFoto_Selfie = new Command(ExecuteTirarFoto_Selfie);
            TirarFotoRG_CNH = new Command(ExecuteTirarFotoRG_CNH);
            TirarFotoComprovante_Residencia = new Command(ExecuteTirarFoto_Comp_Residencia);
            TirarFotoValor_Da_Renda = new Command(ExecuteTirarFotoValor_Da_Renda);

        }

        private bool Dados_Validados()
        {
            if (Selfie == null)
            {
                _pagina.DisplayAlert("Atenção", "Campo Selfie,  está sem foto", "OK");
                return false;

            }

            if (Rg_Ou_CNH == null)
            {
                _pagina.DisplayAlert("Atenção", "Campo RG/CPF, está sem foto", "Ok");
                return false;

            }

            if (Comprovante_Residencia == null)
            {
                _pagina.DisplayAlert("Atenção", "Campo comprovante de residencia, está sem foto", "Ok");
                return false;

            }
            if (Valor_Da_Renda == null)
            {
                _pagina.DisplayAlert("Atenção", "Campo valor da renda, está sem foto", "Ok");
                return false;

            }

            return true;
        }

        private async void ExecuteContinuarCommand()
        {
            ClienteModel cliente = new ClienteModel();


            var page = new NavigationPage(new ConcluidoPage(Cliente));

            if (Dados_Validados())
            {

                cliente.Selfie_Model = Selfie;
                cliente.Rg_Ou_CNH_Model = Rg_Ou_CNH;
                cliente.Comprovante_Residencia_Model = Comprovante_Residencia;
                cliente.Valor_Renda_Model = Valor_Da_Renda;
                await _navigation.PushModalAsync(page);
            }

        }
        public ICommand VoltarCommand { get; }
        private async void ExecuteVoltarCommand()
        {
            RendaPage page = new RendaPage(Cliente);
            await _navigation.PushModalAsync(page);
        }

        
        private async void ExecuteTirarFoto_Selfie()
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

            Selfie = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                return stream;
            });
        }

        private async void ExecuteTirarFotoRG_CNH()
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

            Rg_Ou_CNH = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                return stream;
            });
        }

        private async void ExecuteTirarFoto_Comp_Residencia()
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

            Comprovante_Residencia = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                return stream;
            });
        }

        private async void ExecuteTirarFotoValor_Da_Renda()
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

            Valor_Da_Renda = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                return stream;
            });
        }
    }
}