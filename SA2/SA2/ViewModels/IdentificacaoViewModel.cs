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

        public ICommand ContinuarCommand { get; }
        public IdentificacaoViewModel(Page pagina, ClienteModel cliente) : base(pagina)
        {
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

            cliente.Nome_Model = Nome;
            cliente.Sexo_Model = Sexo;
            cliente.DataNascimento_Model = Data_De_Nascimento;
            cliente.Telefone_Celular_Model = Telefone_Celular;

            EnderecoPage page = new EnderecoPage(Cliente);
            await _navigation.PushModalAsync(page);
        }

        public ICommand VoltarCommand { get; }
        private async void ExecuteVoltarCommand()
        {
            CadastroUsuarioPage page = new CadastroUsuarioPage(Cliente);
            await _navigation.PushModalAsync(page);
        }


    }
}
