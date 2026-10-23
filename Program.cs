namespace EasyNota_TP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto EasyNota");

            string caminhoArquivo = "paciente_teste.csv";

            var csvService = new CsvService();

            var pacientesOriginais = new List<Paciente>
        {
            new Paciente
            {
                Id = "1",
                Nome = "Ana Souza",
                Cpf = "111.222.333-44",
                Telefone = "(11) 98888-7777",
                Email = "ana@email.com",
                Cep = "01001-000",
                NumeroLogradouro = "100",
                Complemento = "Apto 21"
            },
            new Paciente
            {
                Id = "2",
                Nome = "Carlos Lima",
                Cpf = "555.666.777-88",
                Telefone = "(11) 97777-6666",
                Email = "carlos@email.com",
                Cep = "01002-000",
                NumeroLogradouro = "250",
                Complemento = ""
            }
        };

            Console.WriteLine("Gravando pacientes no arquivo csv");
            csvService.SalvarPacientes(caminhoArquivo, pacientesOriginais);
            Console.WriteLine($"Arquivo '{caminhoArquivo}' gerado com sucesso!\n");

            Console.WriteLine("Lendo pacientes do arquivo CSV...");
            var pacientesLidos = csvService.CarregarPacientes(caminhoArquivo);

            foreach (var p in pacientesLidos)
            {
                Console.WriteLine($"[ID: {p.Id}] Nome: {p.Nome} | CPF: {p.Cpf} | Telefone: {p.Telefone} | Email: {p.Email} | Cep: {p.Cep} | NumeroLogradouro: { p.NumeroLogradouro} | Complemento: " + (string.IsNullOrEmpty(p.Complemento) ? "(Nenhum)" : p.Complemento));
            }
            Console.WriteLine("\nTeste concluído com sucesso!");
        }
    }
}
