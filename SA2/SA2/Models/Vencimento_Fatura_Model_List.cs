using System;
using System.Collections.Generic;
using System.Text;

namespace SA2.Models
{
    class Vencimento_Fatura_Model_List
    {

        public static IList<ClienteModel> ClienteModel { get; private set; }

        static Vencimento_Fatura_Model_List()
        {
            ClienteModel = new List<ClienteModel>();


            ClienteModel.Add(new ClienteModel
            {
                Dia_Vencimento_Fatura_Model = 05
            });

            ClienteModel.Add(new ClienteModel
            {
                Dia_Vencimento_Fatura_Model = 10
            });
            ClienteModel.Add(new ClienteModel
            {
                Dia_Vencimento_Fatura_Model = 15
            });
            ClienteModel.Add(new ClienteModel
            {
                Dia_Vencimento_Fatura_Model = 20
            });
            ClienteModel.Add(new ClienteModel
            {
                Dia_Vencimento_Fatura_Model = 25
            });
        }

    }
}
