namespace Exercício_3 {
    class Aluno {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public void NotaFinal() {
            double media = Nota1 + Nota2 + Nota3;
            if (media >= 60) {
                System.Console.WriteLine("NOTA FINAL = " + media);
                System.Console.WriteLine("APROVADO");
            } else {
                System.Console.WriteLine("NOTA FINAL = " + media);
                System.Console.WriteLine("REPROVADO");
                System.Console.WriteLine("FALTARAM " + (60-media) + " PONTOS");
            }
        }
    }
}