using System;
using System.Globalization;

class Produto {
    public string Nome;
    public double Preco;
    public int Quantidade;
    
    public Produto() {
    }
    
    public Produto(string nome, double preco, int quantidade) {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }
    
    public Produto(string nome, double preco) {
        Nome = nome;
        Preco = preco;
        Quantidade = 10;
    }
    
    public double ValorTotal() {
        return Preco * Quantidade;
    }
    
    public override string ToString() {
        return Nome + ", R$" + Preco.ToString("F2", CultureInfo.InvariantCulture)
        + ", " + Quantidade + " unidades, Total: R$"
        + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
    }
}