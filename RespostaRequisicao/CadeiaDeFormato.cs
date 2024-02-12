using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RespostaRequisicao
{
    public class CadeiaDeFormato
    {
        public static void RespondeFormato(Requisicao requisicao,Conta conta)
        {

            RespostaEmCsv F1 = new RespostaEmCsv();
            RespostaEmPorcento F2 = new RespostaEmPorcento();
            RespostaEmXml F3 = new RespostaEmXml();
            RespostaEmJson F4 = new RespostaEmJson();
   
            F1.OutraResposta = F2;
            F2.OutraResposta = F3;
            F3.OutraResposta = F4;

            F1.Responde(requisicao, conta);

        }

    }
}
