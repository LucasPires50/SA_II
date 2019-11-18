using System;
using System.Collections.Generic;
using System.Text;

namespace SA2.Models
{
    public static class UF_Model_List
    {
        public static IList<ClienteModel> ClienteModel { get; private set; }

       static UF_Model_List()
        {
            ClienteModel = new List<ClienteModel>();

            ClienteModel.Add(new ClienteModel
            {
                UF_Model = "AC",
                Uf_Model = "AC"
            }) ;

            ClienteModel.Add(new ClienteModel
            {
                UF_Model = "AL",
                Uf_Model = "AL"
            });
            ClienteModel.Add(new ClienteModel
            {
                UF_Model = "AP",
                Uf_Model = "AP"
            });
            ClienteModel.Add(new ClienteModel
            {
                UF_Model = "AM",
                Uf_Model = "AM"
            });
            ClienteModel.Add(new ClienteModel
            {
                UF_Model = "BA",
                Uf_Model = "BA"
            });
            ClienteModel.Add(new ClienteModel
            {
                UF_Model = "CE",
                Uf_Model = "CE"
            });
            ClienteModel.Add(new ClienteModel
            {
                UF_Model = "DF",
                Uf_Model = "DF"
            });
            ClienteModel.Add(new ClienteModel
            {
                UF_Model = "ES",
                Uf_Model = "ES"
            });
            ClienteModel.Add(new ClienteModel
            {
                UF_Model = "GO",
                Uf_Model = "GO"
            });
            ClienteModel.Add(new ClienteModel
            {
                UF_Model = "MA",
                Uf_Model = "MA"
            });
            ClienteModel.Add(new ClienteModel
            {
                UF_Model = "MT",
                Uf_Model = "MT"
            });
            ClienteModel.Add(new ClienteModel
            {
                UF_Model = "MS",
                Uf_Model = "MS"
            });
            ClienteModel.Add(new ClienteModel
            {
                UF_Model = "MG",
                Uf_Model = "MG"
            });
            ClienteModel.Add(new ClienteModel
            {
                UF_Model = "PA",
                Uf_Model = "PA"
            });
            ClienteModel.Add(new ClienteModel
            {
                UF_Model = "PB",
                Uf_Model = "PB"
            });
            ClienteModel.Add(new ClienteModel
            {
                UF_Model = "PR",
                Uf_Model = "PR"
            });
            ClienteModel.Add(new ClienteModel
            {
                UF_Model = "PE",
                Uf_Model = "PE"
            });
            ClienteModel.Add(new ClienteModel
            {
                UF_Model = "PI",
                Uf_Model = "PI"
            });
            ClienteModel.Add(new ClienteModel
            {
                UF_Model = "RJ",
                Uf_Model = "RJ"
            });

            ClienteModel.Add(new ClienteModel
            {
                UF_Model = "RS",
                Uf_Model = "RS"
            });
			ClienteModel.Add(new ClienteModel
            {
                UF_Model = "RO",
                Uf_Model = "RO"
            });
			ClienteModel.Add(new ClienteModel
            {
                UF_Model = "RR",
                Uf_Model = "RR"
            });
			ClienteModel.Add(new ClienteModel
            {
                UF_Model = "SC",
                Uf_Model = "SC"
            });
			ClienteModel.Add(new ClienteModel
            {
                UF_Model = "SP",
                Uf_Model = "SP"
            });
			ClienteModel.Add(new ClienteModel
            {
                UF_Model = "SE",
                Uf_Model = "SE"
            });
			ClienteModel.Add(new ClienteModel
            {
                UF_Model = "TO",
                Uf_Model = "TO"
            });

        }
    }
}
