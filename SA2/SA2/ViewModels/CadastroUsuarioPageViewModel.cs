using SA2.Models;
using SA2.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SA2.ViewModels
{
    public class CadastroUsuarioPageViewModel : BaseViewModel
    {

        private string mensagemInforme;
        public string MensagemInforme
        {
            get { return mensagemInforme; }
            set { SetProperty<string>(ref mensagemInforme, value); }
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

        private string _confirmacaoSenha;
        public string ConfirmacaoSenha
        {
            get { return _confirmacaoSenha; }
            set { SetProperty<string>(ref _confirmacaoSenha, value); }
        }

        public ICommand ContinuarCommand { get; }

        public CadastroUsuarioPageViewModel(Page pagina, ClienteModel cliente) : base(pagina)
        {
            Cliente = cliente;
            Cpf = "";
            Senha = "";
            ContinuarCommand = new Command(ExecuteContinuarCommand);
            VoltarCommand = new Command(ExecuteVoltarCommand);
        }
        private bool Dados_Validados()
        {
            if (String.IsNullOrEmpty(Cpf))
            {
                _pagina.DisplayAlert("Atenção", "Preencha o campo CPF","OK");
                return false;
                
            }

            if (String.IsNullOrEmpty(Senha))
            {
                _pagina.DisplayAlert("Atenção", "Você deve confirmar a senha", "Ok");
                return false;

            }

            if (Senha.Length < 4 || Senha.Length > 4)
            {
                _pagina.DisplayAlert("Atenção", "Senha deve ter 4 caracteres", "Ok");
                return false;

            }

            if (String.IsNullOrEmpty(ConfirmacaoSenha))
            {
                _pagina.DisplayAlert("Atenção", "A senha e a confirmação devem ser iguais", "Ok");
                return false;

            }
            
            if (Senha != ConfirmacaoSenha)
            {
                _pagina.DisplayAlert("Atenção", "A senha e a confirmação devem ser iguais", "Ok");
                return false;
            }

            return true;
        }
        private async void ExecuteContinuarCommand()
        {
            MensagemInforme = "Informe seu CPF e crie uma senha";

            ClienteModel cliente = new ClienteModel();

            cliente.CPF_Model = Cpf;
            cliente.Senha_Model = Senha;

            var page = new NavigationPage(new IdentificacaoPage(Cliente));

            if (Dados_Validados())
            {


                Cpf = "" ;
                Senha = "";
                ConfirmacaoSenha = "";
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
