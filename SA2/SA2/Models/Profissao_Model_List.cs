using System;
using System.Collections.Generic;
using System.Text;

namespace SA2.Models
{
    class Profissao_Model_List
    {

        public static IList<ClienteModel> ClienteModel { get; private set; }

        static Profissao_Model_List()
        {
            ClienteModel = new List<ClienteModel>();


            ClienteModel.Add(new ClienteModel
            {
                Profissao_Model = "Progamador c# Junior"
            });

            ClienteModel.Add(new ClienteModel
            {
                Profissao_Model = "Programador Java Senior"
            });
            ClienteModel.Add(new ClienteModel
            {
                Profissao_Model = "DBA - Administrador de banco de dados"
            });
        }
    }
}
