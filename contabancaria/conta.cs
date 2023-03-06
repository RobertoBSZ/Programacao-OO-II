using System;

class Conta{
    public string Cpf;
    public string Name;
    public double Saldo;
    
    public Conta(){
        this.Cpf = null;
        this.Name = null;
        this.Saldo = 0;
    }
    
    public string setCpf{
        get{
            return Cpf;
        }
        set{
            Cpf = value;
        }
    }
    
    public string setName{
        get{
            return Name;
        }
        set{
            Name = value;
        }
    }
    
    public double GetSaldo(){
        return this.Saldo;
    }
    
    public string GetCpf(){
        return this.Cpf;
    }
    
    public string GetName(){
        return this.Name;
    }
    public double Sacar (double a){
        return this.Saldo = Saldo - a;
    }
    
    public double Depositar(double a){
        return this.Saldo = this.Saldo + a;
    }
    
    
}