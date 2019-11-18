﻿using SA2.Models;
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
        private double _valor_da_renda;
        public double Valor_Da_Renda
        {
            get { return _valor_da_renda; }
            set { SetProperty<double>(ref _valor_da_renda, value); }
        }

        private double _valor_limite_desejado;
        public double Valor_Limite_Desejado
        {
            get { return _valor_limite_desejado; }
            set { SetProperty<double>(ref _valor_limite_desejado, value); }
        }

        private double _dia_vencimento_fatura;
        public double Dia_Vencimento_Fatura
        {
            get { return _dia_vencimento_fatura; }
            set { SetProperty<double>(ref _dia_vencimento_fatura, value); }
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

        public ICommand ContinuarCommand { get; }

        public RendaViewModel(Page pagina, ClienteModel cliente) : base(pagina)
        {
            Cliente = cliente;

            Valor_Da_Renda = 0;
            Valor_Limite_Desejado = 0;
            Dia_Vencimento_Fatura = 0;
            ContinuarCommand = new Command(ExecuteContinuarCommand);
            VoltarCommand = new Command(ExecuteVoltarCommand);
        }

        private async void ExecuteContinuarCommand()
        {
            ClienteModel cliente = new ClienteModel();

            cliente.Valor_Da_Renda_Model = Valor_Da_Renda;
            cliente.ValorLimite_Model = Valor_Limite_Desejado;
            cliente.Dia_Vencimento_Fatura_Model = Dia_Vencimento_Fatura;

            BiometriaPage page = new BiometriaPage(Cliente);
            await _navigation.PushModalAsync(page);
        }

        public ICommand VoltarCommand { get; }
        private async void ExecuteVoltarCommand()
        {
            DadosPessoaisPage page = new DadosPessoaisPage(Cliente);
            await _navigation.PushModalAsync(page);
        }
    }
}