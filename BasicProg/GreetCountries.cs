using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProg
{
    public static class GreetCountries
    {
        public static void Countries()
        {
            // Declarando o arquivo como uma variavel para try-catch
            string arquivo = @"C:\Users\msira\Desktop\VersãoFinal\ProgBasic1\countries.txt";

            // Criando uma lista para salvar o texto do arquivo inicial 
            List<string> lista = new List<string>();

            try
            {
                // StreamReader para leitura do arquivo
                using (StreamReader reader = new StreamReader(arquivo))
                {
                    string texto;
                    while ((texto = reader.ReadLine()) != null)
                    {
                        // imprime cada item
                        Console.WriteLine(texto);
                            
                        // Adiciona cada linha do texto a lista criada 
                        lista.Add((string)texto);

                    }
                }

                // Criando a variável data com formato apropriado
                string data = DateTime.Now.ToString("yyyy-MMM-dd");
                    //  “Year-MonthName-Day”
                    // Countries 2008-Apr-08.
                
                // StreamWriter para escrever um novo arquivo de texto utilizando a lista salva
                // nome do arquivo leva a data criada
                using (StreamWriter writer = new StreamWriter(@"C:\Users\msira\Desktop\VersãoFinal\ProgBasic1\Countries " + data + ".txt"))
                {
                    foreach (string texto in lista)
                    {
                        writer.WriteLine($"Saludos hasta " + texto);
                    }
                }
            }catch (FileNotFoundException) // Caso o arquivo não seja encontrado
            {
                Console.WriteLine("O Arquivo não pode ser encontrado!");
            }
            catch (Exception ex) // Exceção geral
            {
                Console.WriteLine("Error! " + ex.Message);
            }

                
                   
                
            
           


        }


    }
}
