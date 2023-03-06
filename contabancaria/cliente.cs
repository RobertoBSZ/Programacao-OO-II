using System;

class Cliente{
    public string Cpf;
    public string Name;
    public double Saldo;
    
    public Cliente(){
        this.Cpf = "111.222.333-45";
        this.Name = "Roberto";
        this.Saldo = 1000;
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
    public double sacar (double a){
        return this.Saldo = Saldo - a;
    }
    
    public double depositar(double a){
        return this.Saldo = this.Saldo + a;
    }
    
    
}