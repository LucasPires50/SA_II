using System;
using System.Collections.Generic;
using System.Text;

namespace SA2.Models
{
    class Estado_Civil_Model_List
    {

        public static IList<ClienteModel> clienteModels { get; private set; }

        static Estado_Civil_Model_List()
        {
            clienteModels = new List<ClienteModel>();


            clienteModels.Add(new ClienteModel
            {
                Estado_Civil_Model = "Solteiro (a)"
            });

            clienteModels.Add(new ClienteModel
            {
                Estado_Civil_Model = "Casado (a)"
            });
            clienteModels.Add(new ClienteModel
            {
                Estado_Civil_Model = "Divorsiado (a)"
            });
            clienteModels.Add(new ClienteModel
            {
                Estado_Civil_Model = "Viúvo (a)"
            });
        }


    }
}
