using SA2.Models;
using SA2.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SA2.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {

        private string mensagemDesBank;
        public string MensagemDesBank
        {
            get { return mensagemDesBank; }
            set { SetProperty<string>(ref mensagemDesBank, value); }
        }

        private string mensagemDados;
        public string MensagemDados
        {
            get { return mensagemDados; }
            set { SetProperty<string>(ref mensagemDados, value); }
        }

        private string _cpf;
        public string Cpf
        {
            get { return _cpf; }
            set { SetProperty<string>(ref _cpf, value); }
        }

        private string _senha;
        public string Senha
        {
            get { return _senha; }
            set { SetProperty<string>(ref _senha, value); }
        }

        public ICommand LogarCommand { get; }

        public LoginPageViewModel(Page pagina, ClienteModel cliente) : base(pagina)
        {

            MensagemDesBank = "DesBank";
            MensagemDados = "Insira seus dados";

            Cpf = "";
            Senha = "";
            LogarCommand = new Command(ExecuteLogarCommand);
            VoltarCommand = new Command(ExecuteVoltarCommand);
        }

        private bool Dados_Validados()
        {
            if (String.IsNullOrEmpty(Cpf))
            {
                _pagina.DisplayAlert("Atenção", "Preencha o campo CPF", "OK");
                return false;

            }

            if (String.IsNullOrEmpty(Senha))
            {
                _pagina.DisplayAlert("Atenção", "Você deve confirmar a senha", "Ok");
                return false;

            }

            if (Senha.Length < 4)
            {
                _pagina.DisplayAlert("Atenção", "Senha deve ter 4 caracteres", "Ok");
                return false;

            }

            return true;
        }

            private async void ExecuteLogarCommand()
        {
            ConcluidoPage page = new ConcluidoPage(Cliente);

            if (Dados_Validados())
            {
                Cpf = "";
                Senha = "";
                await _navigation.PushModalAsync(page);
            }
        }

        public ICommand VoltarCommand { get; }
        private async void ExecuteVoltarCommand()
        {
            MainPage page = new MainPage();
            await _navigation.PushModalAsync(page);
        }
    }
}
