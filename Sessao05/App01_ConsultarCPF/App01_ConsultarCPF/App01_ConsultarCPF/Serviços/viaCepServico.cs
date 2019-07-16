using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App01_ConsultarCPF.Serviços.Modelo;
using Newtonsoft.Json;

namespace App01_ConsultarCPF.Serviços
{
    public class viaCepServico
    {
        private static string EnderecoURL = "http://viacep.com.br/ws/{0}/json";

        public static Endereco BuscarEnderecoviaCep(string cep)
        {
            string NovoEnderecoURL = string.Format(EnderecoURL, cep);
            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(NovoEnderecoURL);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(conteudo);

            if (end.cep == null) return null;
            return end;
        }
    }

}
