using System;
using System.Collections.Generic;
using System.Text;

namespace SA2.Models
{
    class Escolaridade_Model_List
    {

        public static IList<ClienteModel> clientemodels { get; private set; }

        static Escolaridade_Model_List()
        {
            clientemodels = new List<ClienteModel>();


            clientemodels.Add(new ClienteModel
            {
                Escolaridade_Model = "Ensino Fundamental Incompleto"
            });

            clientemodels.Add(new ClienteModel
            {
                Escolaridade_Model = "Ensino Fundamental"
            });
            clientemodels.Add(new ClienteModel
            {
                Escolaridade_Model = "Ensino Médio Incompleto"
            });
            clientemodels.Add(new ClienteModel
            {
                Escolaridade_Model = "Ensino Médio"
            });
            clientemodels.Add(new ClienteModel
            {
                Escolaridade_Model = "Ensino Superior Incompleto"
            });
            clientemodels.Add(new ClienteModel
            {
                Escolaridade_Model = "Ensino Superior"
            });
        }

    }
}
