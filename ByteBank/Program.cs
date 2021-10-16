using System;
using System.Collections.Generic;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c1 = new ContaCorrente("Glória", 8364, 866487, 1000.0);
            ContaCorrente c2 = new ContaCorrente("Heidson", 0760, 176347, 500.0);
            ContaCorrente c3 = new ContaCorrente("José", 0760, 175557, 0);
            
            c2.Depositar(500.0);
            c2.Sacar(400.0);
            c3.Sacar(3);
            
            Console.WriteLine("O saldo atualizado em conta é: " + c2);
            Console.WriteLine("O saldo atualizado em conta é: " + c3);

        }
    }
}