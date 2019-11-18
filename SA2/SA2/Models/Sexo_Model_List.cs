using System;
using System.Collections.Generic;
using System.Text;

namespace SA2.Models
{
    public static class Sexo_Model_List
    {

        public static IList<ClienteModel> ClienteModel { get; private set; }

        static Sexo_Model_List()
        {
            ClienteModel = new List<ClienteModel>();


            ClienteModel.Add(new ClienteModel
            {
                Sexo_Model = "Masculino"
            });

            ClienteModel.Add(new ClienteModel
            {
                Sexo_Model = "Feminino"
            });
            ClienteModel.Add(new ClienteModel
            {
                Sexo_Model = "Indefinido"
            });
        }

    }
}
