namespace Exercício_de_fixação {
    class Funcionario {
        public int id {get; set;}
        public string nome {get; set;}
        public double salario {get; private set;}

        public Funcionario(int id, string nome, double salario) {
            this.id = id;
            this.nome = nome;
            this.salario = salario;
        }

        public void increaseSalary(double porcentagem) {
            this.salario += salario * porcentagem / 100;
        }
    }
}