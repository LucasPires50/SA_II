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
    public class ConcluidoViewModel : BaseViewModel
    {
        private string mensagem;
        public string Mensagem_Concluido
        {
            get { return mensagem; }
            set { SetProperty<string>(ref mensagem, value); }
        }
        public ICommand ContinuarCommand { get; }

        public ConcluidoViewModel(Page pagina, ClienteModel cliente) : base(pagina)
        {
            Mensagem_Concluido = "Seu cadastro foi enviado, aguarde!";
            ContinuarCommand = new Command(ExecuteContinuarCommand);
            VoltarCommand = new Command(ExecuteVoltarCommand);
        }
        private async void ExecuteContinuarCommand()
        {
            //Abre a próxima página
            await _pagina.DisplayAlert("Faltou!", "Tais tolo? Implementa ae xtopo!", "Ok");
        }

        public ICommand VoltarCommand { get; }
        private async void ExecuteVoltarCommand()
        {
            LoginPage page = new LoginPage(Cliente);
            await _navigation.PushModalAsync(page);
        }
    }


}
