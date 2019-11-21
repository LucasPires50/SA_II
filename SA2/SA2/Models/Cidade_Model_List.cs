using System;
using System.Collections.Generic;
using System.Text;

namespace SA2.Models
{
   public static class Cidade_Model_List
    {
        public static IList<ClienteModel> ClienteModels { get; private set; }

        static Cidade_Model_List()
        {
            ClienteModels = new List<ClienteModel>();

            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Acre"
            });

            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Alagos",
            });
            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Amapá",
            });
            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Amazonas",
            });
            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Bahia",
            });
            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Ceará",
            });
            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Distrito Federal",
            });
            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Espírito Santo",
            });
            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Goiás",
            });
            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Maranhão",
            });
            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Mato Grosso",
            });
            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Mato Grosso do Sul",
            });
            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Minas Gerais",
            });
            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Pará",
            });
            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Paraíba",
            });
            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Paraná",
            });
            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Pernambuco",
            });
            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Piauí",
            });
            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Rio de Janeiro",
            });

            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Rio Grande do Sul",
            });
            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Rondônia",
            });
            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Roraima",
            });
            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Santa Catarina",
            });
            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "São Paulo",
            });
            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Sergipe",
            });
            ClienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Tocantins",
            });

        }
    }
}

