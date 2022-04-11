using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bancos> bancos = new List<Bancos>();

            
            string arquivoJson = File.ReadAllText(@"JSON_BANCO.txt");

            List<Bancos> banco = JsonSerializer.Deserialize<List<Bancos>>(arquivoJson);


            banco = banco.OrderBy(x => x.id).ToList();

            for(int i=0;i< banco.Count; i++)
            {
                Console.WriteLine("ID: " + banco[i].id);
                Console.WriteLine("Nome: " + banco[i].nome);
                Console.WriteLine("Código ISPB: " + banco[i].codigoIspb);
                Console.WriteLine("Código: " + banco[i].codigo);
                Console.WriteLine("Status: " + banco[i].status);
                Console.WriteLine("Convênio CNAB 240: " + banco[i].convenioCnab240);
                Console.WriteLine("Data de Cadastro: " + banco[i].dataCadastro);
                Console.WriteLine("Data de Alteração: " + banco[i].dataAlteracao);
                Console.WriteLine();

            }
        }
    }
}
