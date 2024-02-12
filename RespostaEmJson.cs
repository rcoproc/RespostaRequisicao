using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RespostaRequisicao
{
    public class RespostaEmJson : IResposta
    {
        public IResposta? OutraResposta { get; set; }

        public RespostaEmJson(IResposta outraResposta)
        {
            this.OutraResposta = outraResposta;
        }
        public RespostaEmJson()
        {
            this.OutraResposta = null; // Não recebia proxima resposta
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.JSON)
            {
                Console.WriteLine(conta.ToString());
            }
            else if(OutraResposta != null)
            {
                OutraResposta.Responde(req, conta);
            }
            else
                Console.WriteLine("*** Formato de resposta não encontrado! ***");
        }
    }
}
