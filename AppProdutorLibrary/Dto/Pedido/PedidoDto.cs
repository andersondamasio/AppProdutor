using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.datacoper.appprodutor.Dto.Pedido
{
    public class PedidoDto
    {
        public String data { get; set; }
        public int numeroPedido { get; set; }
        public decimal quantidade { get; set; }
        public int produto { get; set; }
        public decimal valorUnitario { get; set; }
        public decimal valorTotal { get; set; }
        public decimal quantidadeFaturada { get; set; }
        public decimal valorFatudaro { get; set; }
        public decimal valorAFaturar { get; set; }
        public decimal quantidadeAFaturar { get; set; }
        public String produtor { get; set; }
        public String status { get; set; }

    }
}
