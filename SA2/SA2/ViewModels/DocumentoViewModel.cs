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
    public class DocumentoViewModel : BaseViewModel
    {
        private string mensagemDocumento;
        public string MensagemDocumento
        {
            get { return mensagemDocumento; }
            set { SetProperty<string>(ref mensagemDocumento, value); }
        }

        private string _rg;
        public string RG
        {
            get { return _rg; }
            set { SetProperty<string>(ref _rg, value); }
        }

        private string _cnh;
        public string CNH
        {
            get { return _cnh; }
            set { SetProperty<string>(ref _cnh, value); }
        }

        private string _orgao_emissor;
        public string Orgao_Emissor
        {
            get { return _orgao_emissor; }
            set { SetProperty<string>(ref _orgao_emissor, value); }
        }

        private string _uf;
        public string UF
        {
            get { return _uf; }
            set { SetProperty<string>(ref _uf, value);}

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

        private DateTime _data_emissao;
        public DateTime Data_Emissao
        {
            get { return _data_emissao; }
            set { SetProperty<DateTime>(ref _data_emissao, value); }
        }

        private bool Dados_Validados()
        {
            if (String.IsNullOrEmpty(RG))
            {
                _pagina.DisplayAlert("Atenção", "Preencha o campo do RG", "OK");
                return false;

            }

            if (String.IsNullOrEmpty(CNH))
            {
                _pagina.DisplayAlert("Atenção", "Preencha o campo do CNH", "Ok");
                return false;

            }

            if (String.IsNullOrEmpty(Orgao_Emissor))
            {
                _pagina.DisplayAlert("Atenção", "Preencha o campo Orgão Emissor", "Ok");
                return false;

            }
            /*if (String.IsNullOrEmpty(UF))
            {
                _pagina.DisplayAlert("Atenção", "Selecione a UF", "Ok");
                return false;
            }*/

            if (Data_Emissao >= DateTime.Now)
            {
                _pagina.DisplayAlert("Atenção", "Data superour a atual", "Ok");
                return false;
            }
            return true;
        }


        public ICommand ContinuarCommand { get; }

        public DocumentoViewModel(Page pagina, ClienteModel cliente) : base(pagina)
        {
            MensagemDocumento = "Informe os seus dados documentais";

            Cliente = cliente;

            RG = "";
            CNH = "";
            Orgao_Emissor = "";
            UF = "";
            Data_Emissao = DateTime.Now;
            ContinuarCommand = new Command(ExecuteContinuarCommand);
            VoltarCommand = new Command(ExecuteVoltarCommand);

        }

        private async void ExecuteContinuarCommand()
        {

            ClienteModel cliente = new ClienteModel();

            cliente.RG_Model = RG;
            cliente.CNH_Model = CNH;
            cliente.OrgaoEmissor_Model = Orgao_Emissor;
            cliente.Data_Emissao_Model = Data_Emissao;

            DadosPessoaisPage page = new DadosPessoaisPage(Cliente);


            if (Dados_Validados())
            {


                RG = "";
                CNH = "";
                Orgao_Emissor = "";
                UF = "";
                Data_Emissao = DateTime.Now;
                await _navigation.PushModalAsync(page);
            }
        }

        public ICommand VoltarCommand { get; }
        private async void ExecuteVoltarCommand()
        {
            EnderecoPage page = new EnderecoPage(Cliente);
            await _navigation.PushModalAsync(page);
        }
    }
}