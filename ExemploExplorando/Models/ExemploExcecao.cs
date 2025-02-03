using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class ExemploExcecao
    {
        // TRATAMENTO DE EXCEÇÃO UTILIZANDO MÉTODO EM CASCATA
        /*
            método 1 executa o método 2, que executa o 3, que executa o 4 que joga uma exceção chamada "Ocorreu uma exceção"
            O método 4 retorna ao 3, que retorna ao 2, que retorna ao 1 procurando se há um tratamento de exceção. (StackTrace)
            O tratamento está no bloco try/catch.
            Ao iniciar o "catch", é exibido a mensagem "Exceção tratada" + a mensagem da exceção.
        */
        public void Metodo1() {
             try {
                Metodo2();
            } catch(Exception ex) {
                Console.WriteLine("Exceção tratada." + ex.Message);
            }
        }

        public void Metodo2() {
            Metodo3();        
        }

        
        public void Metodo3() {

            Metodo4();

        }

        
        public void Metodo4() {
            throw new Exception("Ocorreu uma exceção!");
        }
        
    }

}