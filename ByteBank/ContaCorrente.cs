namespace ByteBank
{
    public class ContaCorrente
    {
        public string Titular { get; set; }
        public int Conta { get; set; }
        public int Agencia { get; set; }
        public double Saldo { get; set; }
        
        public double Taxa { get; set; } = 2;

        public ContaCorrente()
        {
            
        }
        
        public ContaCorrente(string titular, int conta, int agencia, double saldo)
        {
            Titular = titular;
            Conta = conta;
            Agencia = agencia;
            Saldo = saldo = 5;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor + Taxa;
        }

        public override string ToString()
        {
            return "Titular: " + Titular + ", " +
                   "Agência: " + Agencia + ", " +
                   "Conta Corrente: " + Conta + ", " +
                   "Saldo: R$ " + Saldo;
        }
    }
}