using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SA2.Models
{
    public class ClienteModel
    {
        // Cadastro Usuário
        public string CPF_Model { get; set; }
        public string Senha_Model { get; set; }

        //Identificação 
        public string Nome_Model { get; set; }
        public DateTime DataNascimento_Model { get; set; }
        public string Sexo_Model { get; set; }
        public string Telefone_Celular_Model { get; set; }

        //Endereço
        public string CEP_Model { get; set; }
        public string Logradouro_Model { get; set; }
        public string Bairro_Model { get; set; }
        public string Cidade_Model { get; set; }
        public string UF_Model { get; set; }
        public string Numero_Model { get; set; }
        public string Complemento_Model { get; set; }

        //Documentação
        public string RG_Model { get; set; }
        public string CNH_Model { get; set; }
        public string OrgaoEmissor_Model { get; set; }
        public string Uf_Model { get; set; }
        public DateTime Data_Emissao_Model { get; set; }

        //Dados Pessoais
        public string Email_Model { get; set; }
        public string NomeDaMae_Model { get; set; }
        public string Profissao_Model { get; set; }

        public string Escolaridade_Model { get; set; }
        public string Estado_Civil_Model { get; set; }

        // Renda
        public double Valor_Da_Renda_Model { get; set; }
        public double ValorLimite_Model { get; set; }

        public double Dia_Vencimento_Fatura_Model { get; set; }

        // Biometria
        public ImageSource Selfie_Model { get; set; }
        public ImageSource Rg_Ou_CNH_Model { get; set; }
        public ImageSource Comprovante_Residencia_Model { get; set; }
        public ImageSource Valor_Renda_Model { get; set; }
    }
}

