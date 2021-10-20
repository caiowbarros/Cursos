namespace Exercício_de_fixação {
    class Conta {
        private int _numero;
        public string Nome;
        public double Saldo;

        public Conta(int numero, string nome) {
            _numero = numero;
            Nome = nome;
            Saldo = 0;
        }

        public Conta(int numero, string nome, double saldoInicial) {
            _numero = numero;
            Nome = nome;
            Saldo = saldoInicial;
        }

        public void alterarNome(string novoNome) {
            Nome = novoNome;
            System.Console.WriteLine("Nome alterado para: " + Nome);
        }

        public void sacar(double valor) {
            Saldo -= valor + 5;
            System.Console.WriteLine("Saque realizado com sucesso!");
            System.Console.WriteLine("Seu saldo atual é: $ " + Saldo);
        }

        public void depositar(double valor) {
            Saldo += valor;
            System.Console.WriteLine("Depósito realizado com sucesso!");
            System.Console.WriteLine("Seu saldo atual é: $ " + Saldo);
        }
    }
}