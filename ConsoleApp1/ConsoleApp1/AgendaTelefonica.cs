using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula230313SistemaAgendaTelefonica
{
    public class AgendaTelefonica
    {
        public List<Contato> listaAgenda;

        public AgendaTelefonica()
        {
            listaAgenda = new List<Contato>();
        }

        public void inserir(string nome, string numero)
        {
            listaAgenda.Add(new Contato(nome, numero));
        }

        public void remover(string nome)
        {
            Contato contato = listaAgenda.Find(c => c.Nome == nome);
            if (listaAgenda.Remove(Contato))
            {
                Console.WriteLine(nome + " foi removido de sua agenda.");
            }
            else
            {
                Console.WriteLine(nome + " não foi encontradx na sua agenda");
            }
        }

        public int tamanhoAgenda()
        {
            return listaAgenda.Count();
        }

        public String buscarNumero(string nome)
        {
            String numeroBuscado;

            if (listaAgenda.TryGetValue(nome, out numeroBuscado))
            {
                Console.WriteLine("O número de " + nome + " é: " + numeroBuscado);
            }
            else
            {
                Console.WriteLine(nome + " não foi encontradx na agenda.");
            }
            return numeroBuscado;
        }

        public void imprimirAgenda()
        {

            Console.WriteLine("\n--------------------------------");
            foreach (string chave in listaAgenda.Keys)
            {
                Console.WriteLine("Nome: " + chave);
                Console.WriteLine("Telefone: " + listaAgenda[chave]);
                Console.WriteLine("................");
            }
            Console.WriteLine("--------------------------------");
        }

    }
}
