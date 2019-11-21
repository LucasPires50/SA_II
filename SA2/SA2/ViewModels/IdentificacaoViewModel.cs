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
    public class IdentificacaoViewModel : BaseViewModel
    {

        DateTime dataNascimentoMinima = DateTime.Now.AddYears(-18);

        private string mensagemIdentificacao;
        public string MensagemIdentificacao
        {
            get { return mensagemIdentificacao; }
            set { SetProperty<string>(ref mensagemIdentificacao, value); }
        }

        private string mensagemIdentificacao2;
        public string MensagemIdentificacao2
        {
            get { return mensagemIdentificacao2; }
            set { SetProperty<string>(ref mensagemIdentificacao2, value); }
        }

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { SetProperty<string>(ref _nome, value); }
        }

        private DateTime _data_de_nascimento;
        public DateTime Data_De_Nascimento
        {
            get { return _data_de_nascimento; }
            set { _data_de_nascimento = value; }
        }


        private string _sexo;
        public string Sexo
        {
            get { return _sexo; }
            set { SetProperty<string>(ref _sexo, value); }
        }

        public IList<ClienteModel> ClienteModel { get { return Sexo_Model_List.ClienteModel; } }


        ClienteModel selected_sexo;
        public ClienteModel Selected_sexo
        {
            get { return selected_sexo; }
            set
            {
                if (selected_sexo != value)
                {
                    selected_sexo = value;
                    OnPropertyChanged();
                }
            }
        }


        private string _telefone_celular;
        public string Telefone_Celular
        {
            get { return _telefone_celular; }
            set { SetProperty<string>(ref _telefone_celular, value); }
        }

        private bool Dados_Validados()
        {
            if (String.IsNullOrEmpty(Nome))
            {
                _pagina.DisplayAlert("Atenção", "Preencha o campo nome", "OK");
                return false;

            }

            /*if (String.IsNullOrEmpty(Sexo))
            {
                _pagina.DisplayAlert("Atenção", "Escolha um opção", "Ok");
                return false;

            }*/

            if (String.IsNullOrEmpty(Telefone_Celular))
            {
                _pagina.DisplayAlert("Atenção", "Preencha o campo telefone", "Ok");
                return false;

            }
            if (Data_De_Nascimento == dataNascimentoMinima)
            {
                _pagina.DisplayAlert("Atenção","Tem que maior de idade","Ok");
                return false;
            }

            return true;
        }

        public ICommand ContinuarCommand { get; }
        public IdentificacaoViewModel(Page pagina, ClienteModel cliente) : base(pagina)
        {
            MensagemIdentificacao = "Queremos lhe conhecer melhor, por favor";
            MensagemIdentificacao2 = "informe os dados nos campos abaixo";

            Cliente = cliente;

            Nome = "";
            Sexo = "";
            Data_De_Nascimento = _data_de_nascimento.Date;
            Telefone_Celular = "";
            ContinuarCommand = new Command(ExecuteContinuarCommand);
            VoltarCommand = new Command(ExecuteVoltarCommand);
        }

        private async void ExecuteContinuarCommand()
        {
            ClienteModel cliente = new ClienteModel();

            var page = new NavigationPage(new EnderecoPage(Cliente));

            cliente.Nome_Model = Nome;
            cliente.Sexo_Model = Sexo;
            cliente.DataNascimento_Model = Data_De_Nascimento;
            cliente.Telefone_Celular_Model = Telefone_Celular;



            if (Dados_Validados())
            {


                Nome = "";
                Sexo = "";
                Data_De_Nascimento = _data_de_nascimento.Date;
                Telefone_Celular = "";
                await _navigation.PushModalAsync(page);
            }

        }

        public ICommand VoltarCommand { get; }
        private async void ExecuteVoltarCommand()
        {
            CadastroUsuarioPage page = new CadastroUsuarioPage(Cliente);
            await _navigation.PushModalAsync(page);
        }


    }
}
