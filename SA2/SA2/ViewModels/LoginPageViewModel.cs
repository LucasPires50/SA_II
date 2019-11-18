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

        public LoginPageViewModel(Page pagina) : base(pagina)
        {
            
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

            return true;
        }

            private async void ExecuteLogarCommand()
        {
            IdentificacaoPage page = new IdentificacaoPage(Cliente);

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
