using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula230313SistemaAgendaTelefonica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgendaTelefonica agenda = new AgendaTelefonica();

            agenda.imprimirAgenda();

            agenda.inserir("João", "111111");
            agenda.inserir("Pedro", "222222");
            agenda.inserir("Marcos", "333333");
            agenda.inserir("Matheus", "444444");
            agenda.inserir("Maria", "555555");

            agenda.imprimirAgenda();
            Console.WriteLine("\n\nO tamanho é: " + agenda.tamanhoAgenda());

            agenda.remover("Maria");

            agenda.imprimirAgenda();
            Console.WriteLine("\n\nO tamanho é: " + agenda.tamanhoAgenda());



        }
    }
}
