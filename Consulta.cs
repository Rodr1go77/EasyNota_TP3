using System;
using System.Collections.Generic;
using System.Text;

namespace EasyNota_TP3
{
    public class Consulta
    {
        public string Id { get; set; } = string.Empty;
        public string PacienteId { get; set; } = string.Empty;
        public DateOnly? DataConsulta { get; set; } = null;
        public decimal Valor { get; set; } = 0m;
        public string Status { get; set; } = string.Empty;



    }
}
