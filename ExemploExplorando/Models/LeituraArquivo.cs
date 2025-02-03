using System;

namespace ExemploExplorando.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try 
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            } catch(Exception ex) 
            {
                return (false, new string[0], 0);
            }
        }
    }
}