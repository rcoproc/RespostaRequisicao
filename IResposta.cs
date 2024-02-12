using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RespostaRequisicao
{
    public interface IResposta
    {
        public void Responde(Requisicao req, Conta conta);
        public IResposta OutraResposta { get; set; }
    }
}
