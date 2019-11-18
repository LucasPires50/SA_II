using System;
using System.Collections.Generic;
using System.Text;

namespace SA2.Models
{
   public static class Cidade_Model_List
    {
        public static IList<ClienteModel> clienteModels { get; private set; }

        static Cidade_Model_List()
        {
            clienteModels = new List<ClienteModel>();

            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Acre"
            });

            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Alagos",
            });
            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Amapá",
            });
            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Amazonas",
            });
            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Bahia",
            });
            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Ceará",
            });
            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Distrito Federal",
            });
            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Espírito Santo",
            });
            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Goiás",
            });
            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Maranhão",
            });
            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Mato Grosso",
            });
            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Mato Grosso do Sul",
            });
            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Minas Gerais",
            });
            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Pará",
            });
            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Paraíba",
            });
            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Paraná",
            });
            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Pernambuco",
            });
            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Piauí",
            });
            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Rio de Janeiro",
            });

            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Rio Grande do Sul",
            });
            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Rondônia",
            });
            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Roraima",
            });
            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Santa Catarina",
            });
            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "São Paulo",
            });
            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Sergipe",
            });
            clienteModels.Add(new ClienteModel
            {
                Cidade_Model = "Tocantins",
            });

        }
    }
}

