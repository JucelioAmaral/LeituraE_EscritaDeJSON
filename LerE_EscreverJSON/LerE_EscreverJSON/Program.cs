using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace LerE_EscreverJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://ronnioliveira.wordpress.com/2016/11/05/como-ler-e-escrever-json-em-c/
            //https://stackoverflow.com/questions/16921652/how-to-write-a-json-file-in-c
            ReadAndWriteJsonFile();
        }

        public static void ReadAndWriteJsonFile()
        {
            try
            {
                var arquivoExterno = File.ReadAllText(@"E:\APLICAÇÕES E CURSOS\APPS GENÉRICOS\_LerE_EscreverJSON\Files\Source\arquivoJson.json");
                var arquivoLido = JsonConvert.SerializeObject(arquivoExterno, Formatting.Indented);
                List<Empresa> empresas = JsonConvert.DeserializeObject<List<Empresa>>(arquivoExterno);

                //Exibe no console a leitura do arquivo JSON
                Console.WriteLine("  ==  Resultado da leitura do arquivo JSON  == ");
                Console.WriteLine("");
                foreach (Empresa empresa in empresas)
                {
                    foreach (Funcionario func in empresa.Funcionarios)
                    {
                        Console.WriteLine(String.Format("{0} : {1} : {2}: {3}: {4}", empresa.Id, empresa.Nome, func.Id, func.Nome, func.Idade));
                    }
                }

                //Faz a leitura e escrita do arquivo JSON
                Console.WriteLine("");
                Console.WriteLine("  ==  Leitura e escrita do arquivo JSON  == ");
                Console.WriteLine("...");
                List<Empresa> empresasSerialized = new List<Empresa>();

                foreach (Empresa emp in empresas)
                {
                    empresasSerialized.Add(emp);
                }
                string jsonSerialize = JsonConvert.SerializeObject(empresasSerialized);
                File.WriteAllText(@"E:\APLICAÇÕES E CURSOS\APPS GENÉRICOS\_LerE_EscreverJSON\Files\Destiny\teste.json", jsonSerialize);
                Console.WriteLine("  ==  Leitura e escrita do arquivo JSON  finalizada== ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
