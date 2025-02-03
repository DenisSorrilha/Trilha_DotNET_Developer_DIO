using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        //Propriedade Nome
        public string? Nome { get; set; }

        //Propriedade do tipo coleção (Lista de pessoas)
        public List<Pessoa>? Alunos { get; set; }

        //Método para adicionar alunos
        public void AdicionarAluno(Pessoa aluno) {
            Alunos.Add(aluno);
        }

        //Método para obter a quantidade de alunos matriculados        
        public int ObterQuantidadeDeAlunosMatriculados() {
            int quantidade = Alunos.Count;
            //Necessita utilizar o método Return, pois o método não foi instanciado como void.
            return quantidade;
        }

        //Método para remover os alunos
        public bool RemoverAluno(Pessoa aluno) {
            return Alunos.Remove(aluno);
            
        }
        
        //Método para listar os alunos
        public void ListarAlunos() { 

            //Imprime uma mensagem que são os alunos do curso X
            Console.WriteLine($"Alunos do curso de {Nome}");

            // for loop para listar todos os alunos da lista Alunos
            for (int count = 0; count < Alunos.Count; count++) {
                // Utilizando a interpolação de string ($"{nome da variável}")
                string texto = $"Nº {count + 1} - {Alunos[count].NomeCompleto}";
                
                Console.WriteLine(texto);
            } 
        }


    }
}