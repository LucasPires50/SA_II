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
    public class RendaViewModel : BaseViewModel
    {

        private string mensagemRenda;
        public string MensagemRenda
        {
            get { return mensagemRenda; }
            set { SetProperty<string>(ref mensagemRenda, value); }
        }

        private string _valor_da_renda;
        public string Valor_Da_Renda
        {
            get { return _valor_da_renda; }
            set { SetProperty<string>(ref _valor_da_renda, value); }
        }

        private string _valor_limite_desejado;
        public string Valor_Limite_Desejado
        {
            get { return _valor_limite_desejado; }
            set { SetProperty<string>(ref _valor_limite_desejado, value); }
        }

        private string _dia_vencimento_fatura;
        public string Dia_Vencimento_Fatura
        {
            get { return _dia_vencimento_fatura; }
            set { SetProperty<string>(ref _dia_vencimento_fatura, value); }
        }

        public IList<ClienteModel> ClienteModel { get { return Vencimento_Fatura_Model_List.ClienteModel; } }


        ClienteModel selected_vencimento;
        public ClienteModel Selected_vencimento
        {
            get { return selected_vencimento; }
            set
            {
                if (selected_vencimento != value)
                {
                    selected_vencimento = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool Dados_Validados()
        {
            if (string.IsNullOrEmpty(Valor_Da_Renda))
            {
                _pagina.DisplayAlert("Atenção", "Preencha o campo valor da renda", "OK");
                return false;

            }

            if (string.IsNullOrEmpty(Valor_Limite_Desejado))
            {
                _pagina.DisplayAlert("Atenção", "Preencha o campo limite desejado", "Ok");
                return false;

            }

            if (Selected_vencimento == null)
            {
                _pagina.DisplayAlert("Atenção", "Escolha uma data de vencimento", "Ok");
                return false;

            }

            return true;
        }

        public ICommand ContinuarCommand { get; }

        public RendaViewModel(Page pagina, ClienteModel cliente) : base(pagina)
        {

            MensagemRenda = "Informe seus dados financeiros";

            Cliente = cliente;

            Valor_Da_Renda = "";
            Valor_Limite_Desejado = "";
            Dia_Vencimento_Fatura = "";
            ContinuarCommand = new Command(ExecuteContinuarCommand);
            VoltarCommand = new Command(ExecuteVoltarCommand);
        }

        private async void ExecuteContinuarCommand()
        {
            ClienteModel cliente = new ClienteModel();

            cliente.Valor_Da_Renda_Model = Valor_Da_Renda;
            cliente.ValorLimite_Model = Valor_Limite_Desejado;
            cliente.Dia_Vencimento_Fatura_Model = Dia_Vencimento_Fatura;

            var page = new NavigationPage(new BiometriaPage(Cliente));

            if (Dados_Validados())
            {

                Valor_Da_Renda = "";
                Valor_Limite_Desejado = "";
                Dia_Vencimento_Fatura = "";
                await _navigation.PushModalAsync(page);
            }
        }

        public ICommand VoltarCommand { get; }
        private async void ExecuteVoltarCommand()
        {
            DadosPessoaisPage page = new DadosPessoaisPage(Cliente);
            await _navigation.PushModalAsync(page);
        }
    }
}