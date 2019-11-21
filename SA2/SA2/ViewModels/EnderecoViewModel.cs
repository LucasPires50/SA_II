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
    public class EnderecoViewModel : BaseViewModel
    {
        private string mensagemEndereco;
        public string MensagemEndereco
        {
            get { return mensagemEndereco; }
            set { SetProperty<string>(ref mensagemEndereco, value); }
        }

        private string mensagemEndereco2;
        public string MensagemEndereco2
        {
            get { return mensagemEndereco2; }
            set { SetProperty<string>(ref mensagemEndereco2, value); }
        }

        private string _cep;
        public string Cep
        {
            get { return _cep; }
            set { SetProperty<string>(ref _cep, value); }
        }

        private string _logradouro;
        public string Logradouro
        {
            get { return _logradouro; }
            set { SetProperty<string>(ref _logradouro, value); }
        }

        private string _bairro;
        public string Bairro
        {
            get { return _bairro; }
            set { SetProperty<string>(ref _bairro, value); }
        }

        private string _cidade;
        public string Cidade
        {
            get { return _cidade; }
            set { SetProperty<string>(ref _cidade, value); }
        }

        public IList<ClienteModel> clienteModels { get { return Cidade_Model_List.clienteModels; } }


        ClienteModel selected_cidade;
        public ClienteModel Selected_cidade
        {
            get { return selected_cidade; }
            set
            {
                if (selected_cidade != value)
                {
                    selected_cidade = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _uf;
        public string UF
        {
            get { return _uf; }
            set { SetProperty<string>(ref _uf, value); }
        }

        public IList<ClienteModel> ClienteModel { get { return UF_Model_List.ClienteModel; } }


        ClienteModel selected_UF;
        public ClienteModel Selected_UF
        {
            get { return selected_UF; }
            set
            {
                if (selected_UF != value)
                {
                    selected_UF = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _numero;
        public string Numero
        {
            get { return _numero; }
            set { SetProperty<string>(ref _numero, value); }
        }

        private string _complemento;
        public string Complemento
        {
            get { return _complemento; }
            set { SetProperty<string>(ref _complemento, value); }
        }

        private bool Dados_Validados()
        {
            if (String.IsNullOrEmpty(Cep))
            {
                _pagina.DisplayAlert("Atenção", "Preencha o campo CEP", "OK");
                return false;

            }

            if (String.IsNullOrEmpty(Logradouro))
            {
                _pagina.DisplayAlert("Atenção", "Preencha o campo Logradouro", "Ok");
                return false;

            }

            if (String.IsNullOrEmpty(Bairro))
            {
                _pagina.DisplayAlert("Atenção", "Preencha o campo Bairro", "Ok");
                return false;

            }
           /* if (String.IsNullOrEmpty(Cidade))
            {
                _pagina.DisplayAlert("Atenção", "Selecione sua cidade", "Ok");
                return false;
            }

            if (String.IsNullOrEmpty(UF))
            {
                _pagina.DisplayAlert("Atenção", "Selecione sua a UF", "Ok");
                return false;
            }*/

            if (String.IsNullOrEmpty(Numero))
            {
                _pagina.DisplayAlert("Atenção", "Preencha o campo número", "Ok");
               return false;
            }

            if (String.IsNullOrEmpty(Complemento))
            {
                _pagina.DisplayAlert("Atenção", "Preencha o campo complemento", "Ok");
                return false;
            }
            return true;
        }

        public ICommand ContinuarCommand { get; }
        public EnderecoViewModel(Page pagina, ClienteModel cliente) : base(pagina)
        {
            MensagemEndereco = "Informe seu endereço, isso nos";
            MensagemEndereco2 = "ajudará na análise de crédito";

            Cliente = cliente;

            Cep = "";
            Logradouro = "";
            Bairro = "";
            Cidade = "";
            UF = "";
            Numero = "";
            Complemento = "";
            ContinuarCommand = new Command(ExecuteContinuarCommand);
            VoltarCommand = new Command(ExecuteVoltarCommand);
        }

        private async void ExecuteContinuarCommand()
        {
            ClienteModel cliente = new ClienteModel();

            cliente.CEP_Model = Cep;
            cliente.Logradouro_Model = Logradouro;
            cliente.Bairro_Model = Bairro;
            cliente.Cidade_Model = Cidade;
            cliente.UF_Model = UF;
            cliente.Numero_Model = Numero;
            cliente.Complemento_Model = Complemento;

            var page = new NavigationPage(new DocumentoPage(Cliente));


            if (Dados_Validados())
            {


                Cep = "";
                Logradouro = "";
                Bairro = "";
                Cidade = "";
                UF = "";
                Numero = "";
                Complemento = "";
                await _navigation.PushModalAsync(page);
            }

        }

        public ICommand VoltarCommand { get; }
        private async void ExecuteVoltarCommand()
        {
            IdentificacaoPage page = new IdentificacaoPage(Cliente);
            await _navigation.PushModalAsync(page);
        }
    }
}