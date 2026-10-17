using System;
using System.Collections.Generic;
using System.Text;

namespace EasyNota_TP3
{
    public class Pagamento
    {
        public string Id { get; set; } = string.Empty;
        public List<string> ConsultaIds { get; set; } = [];
        public DateOnly? DataRecebimento { get; set; } = null;
        public decimal ValorTotal { get; set; } = 0m;


    }
}
