using System;
using System.Collections.Generic;
using System.Text;

namespace EasyNota_TP3
{
    public class NotaFiscal
    {
        public string Id { get; set; } = string.Empty;
        public string PagamentoId { get; set; } = string.Empty;
        public string NumeroNota { get; set; } = string.Empty;
        public string DescricaoServico { get; set; } = string.Empty;
        public DateTime? DataEmissao { get; set; } = null;
        public string CaminhoArquivoPDF { get; set; } = string.Empty;
        public string StatusEmissao { get; set; } = string.Empty;


    }
}
