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
    public class DadosPessoaisViewModel : BaseViewModel
    {
        private string mensagemPessoais;
        public string MensagemPessoais
        {
            get { return mensagemPessoais; }
            set { SetProperty<string>(ref mensagemPessoais, value); }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { SetProperty<string>(ref _email, value); }
        }

        private string _confirmacao_email;
        public string Confirmacao_Email
        {
            get { return _confirmacao_email; }
            set { SetProperty<string>(ref _confirmacao_email, value); }
        }

        private string _nome_mae;
        public string Nome_Mae
        {
            get { return _nome_mae; }
            set { SetProperty<string>(ref _nome_mae, value); }
        }

        private string _profissao;
        public string Profissao
        {
            get { return _profissao; }
            set { SetProperty<string>(ref _profissao, value); }
        }
        public IList<ClienteModel> ClienteModel { get { return Profissao_Model_List.ClienteModel; } }


        ClienteModel selected_profissao;
        public ClienteModel Selected_profissao
        {
            get { return selected_profissao; }
            set
            {
                if (selected_profissao != value)
                {
                    selected_profissao = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _escolaridade;
        public string Escolaridade
        {
            get { return _escolaridade; }
            set { SetProperty<string>(ref _escolaridade, value); }
        }
        public IList<ClienteModel> clientemodels { get { return Escolaridade_Model_List.clientemodels; } }

        ClienteModel selected_escolaridade;
        public ClienteModel Selected_escolaridade
        {
            get { return selected_escolaridade; }
            set
            {
                if (selected_escolaridade != value)
                {
                    selected_escolaridade = value;
                    OnPropertyChanged();
                }
            }
        }


        private string _estado_civil;
        public string Estado_Civil
        {
            get { return _estado_civil; }
            set { SetProperty<string>(ref _estado_civil, value); }
        }
        public IList<ClienteModel> clienteModels { get { return Estado_Civil_Model_List.clienteModels; } }


        ClienteModel selected_estado_civil;
        public ClienteModel Selected_estado_civil
        {
            get { return selected_estado_civil; }
            set
            {
                if (selected_estado_civil != value)
                {
                    selected_estado_civil = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool Dados_Validados()
        {
            if (String.IsNullOrEmpty(Email))
            {
                _pagina.DisplayAlert("Atenção", "Preencha o campo Email", "Ok");
                return false;

            }

            if (String.IsNullOrEmpty(Confirmacao_Email))
            {
                _pagina.DisplayAlert("Atenção", "Preencha o campo Confirmacao Email", "Ok");
                return false;

            }

            if (Email != Confirmacao_Email)
            {
                _pagina.DisplayAlert("Atenção", "O e-mail e a confirmação do e-mail devem ser iguais", "Ok");
                return false;
            }


            if (String.IsNullOrEmpty(Nome_Mae))
            {
                _pagina.DisplayAlert("Atenção", "Preencha o campo Nome da Mãe", "Ok");
                return false;
            }

            /*if (String.IsNullOrEmpty(Profissao))
            {
                _pagina.DisplayAlert("Atenção", "Selecione sua profissão", "Ok");
                return false;
            }

            if (String.IsNullOrEmpty(Escolaridade))
            {
                _pagina.DisplayAlert("Atenção", "Selecione sua escolaridade", "Ok");
                return false;
            }

            if (String.IsNullOrEmpty(Estado_Civil))
            {
                _pagina.DisplayAlert("Atenção", "Selecione sue estado civil", "Ok");
                return false;
            }*/
            return true;
        }


        public ICommand ContinuarCommand { get; }

        public DadosPessoaisViewModel(Page pagina, ClienteModel cliente) : base(pagina)
        {
            MensagemPessoais = "Informe os seus dados pessoais";

            Cliente = cliente;

            Email = "";
            Confirmacao_Email = "";
            Nome_Mae = "";
            Profissao = "";
            Escolaridade = "";
            Estado_Civil = "";

            ContinuarCommand = new Command(ExecuteContinuarCommand);
            VoltarCommand = new Command(ExecuteVoltarCommand);

        }

        private async void ExecuteContinuarCommand()
        {

            ClienteModel cliente = new ClienteModel();

            cliente.Email_Model = Email;
            cliente.NomeDaMae_Model = Nome_Mae;
            cliente.Profissao_Model = Profissao;
            cliente.Escolaridade_Model = Escolaridade;
            cliente.Estado_Civil_Model = Estado_Civil;

            RendaPage page = new RendaPage(Cliente);

            if (Dados_Validados())
            {


                Email = "";
                Confirmacao_Email = "";
                Nome_Mae = "";
                Profissao = "";
                Escolaridade = "";
                Estado_Civil = "";
                await _navigation.PushModalAsync(page);
            }
        }

        public ICommand VoltarCommand { get; }
        private async void ExecuteVoltarCommand()
        {
            DocumentoPage page = new DocumentoPage(Cliente);
            await _navigation.PushModalAsync(page);
        }
    }
}