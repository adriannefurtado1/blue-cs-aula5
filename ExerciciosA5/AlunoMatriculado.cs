

namespace ExerciciosA5
{
    // 1.	Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina.
    //
    // 1.1  Cada objeto dessa classe deve guardar os seguintes dados do aluno: 
    //      matrícula, nome, 2 notas de prova e 1 nota de trabalho.
    //
    // 1.2  Escreva os seguintes métodos para esta classe:
    // 1.2.1	Calcular média: calcula e exibe a média final do aluno com base em suas notas;
    // 1.2.2	Calculo nota final: calcula quanto o aluno precisa tirar na prova final para ser aprovado.

    internal class AlunoMatriculado
    {
        public string matricula = "";
        public string nome = "";
        public double notaProva1 = 0;
        public double notaProva2 = 0;
        public double notaTrabalho = 0;

        public double CalcularMedia()
        {
            return (notaProva1 + notaProva2 + notaTrabalho) / 4;
        }

        public double CalcularNotaProvaFinal()
        {
            double notaCorte = 7;
            double qtdNotas = 4;

            return (notaCorte*qtdNotas - (notaProva1 + notaProva2 + notaTrabalho));
        }
    }
}
