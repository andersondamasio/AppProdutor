using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.datacoper.appprodutor.Dto.Cotacao
{
    public class CotacaoDto
    {
        public int idProduto { get; set; }

        public String descricao { get; set; }

        public decimal valorCotacao { get; set; }

        public DateTime dataCotacao { get; set; }


        /*
         [ {
  "id" : 1,
  "idProduto" : 1,
  "descricao" : "Soja",
  "valorCotacao" : 60.00,
  "dataCotacao" : "2018-06-09T03:00:00Z",
  "empresaId" : 1,
  "empresaRazaoSocial" : "Cooperalfa"
}
         
         */

    }
}
