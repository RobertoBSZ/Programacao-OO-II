using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AgendaTelefonica{
    public List<Contato> listaAgenda;

    public AgendaTelefonica() { 
        listaAgenda = new List<Contato>();
    }

    public void inserir(string nome, string numero) {
        listaAgenda.Add(new Contato(nome, numero));
    }

    public void remover(string nome) {
        
        int numRemovidos = listaAgenda.RemoveAll(c => c.nome == nome);
        
        listaAgenda.RemoveAll(c => c.nome == nome);
        
        if (numRemovidos == 0){
            Console.WriteLine("O contato "+ nome +" não existe na agenda para ser excluído.");
            Console.WriteLine("--------------------------------");
        }else{
            Console.WriteLine(nome + " foi removido de sua agenda.");
        }
        
    }

    public string buscarNumero(string nome){
        foreach (Contato i in listaAgenda){
            if (i.nome == nome){
                Console.WriteLine("O número de " +nome+ " é: " + i.numero);
                return i.numero;
            }
        }
        return null;
    }

    public int tamanhoAgenda() {          
        return listaAgenda.Count();
    }
    
    public void imprimirAgenda() {
        Console.WriteLine("\n--------------------------------");
        foreach (Contato i in listaAgenda) {
            Console.WriteLine("Nome: " + i.nome);
            Console.WriteLine("Telefone: " + i.numero);
            Console.WriteLine("................");
        }
        Console.WriteLine("--------------------------------");
    }

}

