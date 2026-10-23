using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EasyNota_TP3
{
    internal class CsvService
    {
        private const string Cabecalho = "Id;Nome;Cpf;Telefone;Email;Cep;NumeroLogradouro;Complemento";

        public void SalvarPacientes(string caminhoArquivo, List<Paciente> pacientes)
        {
            using var writer = new StreamWriter(caminhoArquivo, false, Encoding.UTF8);

            writer.WriteLine(Cabecalho);

            foreach (var paciente in pacientes)
            {
                var linha = $"{paciente.Id};{paciente.Nome};{paciente.Cpf};{paciente.Telefone};{paciente.Email};{paciente.Cep};{paciente.NumeroLogradouro};{paciente.Complemento}";
                writer.WriteLine(linha);
            }


        }

        public List<Paciente> CarregarPacientes(string caminhoArquivo)
        {
            var pacientes = new List<Paciente>();

            if (!File.Exists(caminhoArquivo))
                return pacientes;

            using var reader = new StreamReader(caminhoArquivo, Encoding.UTF8);

            string? linha = reader.ReadLine();

            while ((linha = reader.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(linha))
                    continue;

                var partes = linha.Split(";");

                if (partes.Length >= 7)
                {
                    var paciente = new Paciente
                    {
                        Id = partes[0],
                        Nome = partes[1],
                        Cpf = partes[2],
                        Telefone = partes[3],
                        Email = partes[4],
                        Cep = partes[5],
                        NumeroLogradouro = partes[6],
                        Complemento = partes.Length > 7 ? partes[7] : string.Empty,
                    };

                    pacientes.Add(paciente);
                }
            }

            return pacientes;
        }
    }
}
