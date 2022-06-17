namespace ExerciciosA5
{
    internal class Program
    {

        static void Main(string[] args)
        {
            A5E1AlunoMatriculado();
            A5E2Voo();
            A5E3Calculadora();

        }

        static void A5E1AlunoMatriculado()
        {
            AlunoMatriculado aluno = new AlunoMatriculado();
            double media;
            double notaProvaFinal;

            Console.WriteLine("========================================");
            Console.WriteLine("           ALUNOS MATRICULADOS          ");
            Console.WriteLine("========================================");
            Console.WriteLine();

            Console.Write("Digite o nome do aluno: ");
            aluno.nome = Console.ReadLine();

            Console.Write("Digite a matricula/disciplina do aluno: ");
            aluno.matricula = Console.ReadLine();

            Console.Write("Digite a nota da 1a. prova: ");
            aluno.notaProva1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota da 2a. prova: ");
            aluno.notaProva2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota do trabalho: ");
            aluno.notaTrabalho = double.Parse(Console.ReadLine());

            Console.WriteLine();

            media = aluno.CalcularMedia();

            Console.WriteLine($"Média atual: {media}");

            notaProvaFinal = aluno.CalcularNotaProvaFinal();

            Console.WriteLine();
            Console.WriteLine($"[ A nota de corte é 7. ]");
            Console.WriteLine();
            Console.WriteLine($"{aluno.nome} precisa tirar {notaProvaFinal} na prova final para ser aprovado");

            Console.WriteLine();
            Console.WriteLine();
        }

        static void A5E2Voo()
        {

            bool ocupouAssento = false;
            bool outroAssento = true;
            int assento = -1;         
            int operacao = 0;

            Voo voo = new Voo();

            Console.WriteLine("========================================");
            Console.WriteLine("                  VÔO                   ");
            Console.WriteLine("========================================");
            Console.WriteLine();

            Console.Write("Escreva o destino: ");
            voo.destino = Console.ReadLine();

            Console.Write("Escreva a data: ");
            voo.data = Console.ReadLine();

            Console.Write("Escreva o horário: ");
            voo.horario = Console.ReadLine();

            do
            {
                Console.WriteLine();
                Console.WriteLine("*****************************************************************");
                Console.WriteLine("* Escolha a operação?                                           *");
                Console.WriteLine("* 1 - Reservar um Assento.                                      *");
                Console.WriteLine("* 2 - Saber a disponibilidade de vagas.                         *");
                Console.WriteLine("* 3 - Saber qual a próxima cadeira livre.                       *");
                Console.WriteLine("* 4 - Ver as informações do vôo.                                *");
                Console.WriteLine("* 5 - Sair.                                                     *");
                Console.WriteLine("*****************************************************************");
                Console.WriteLine();
                Console.Write("Digite a operação: ");
                operacao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (operacao)
                {
                    case 1:
                        ocupouAssento = false;
                        outroAssento = true;
                        do
                        {
                            string nomePassageiro = "";
                            while (!ocupouAssento && outroAssento)
                            {

                                Console.Write("Escreva o numero o assento [de 1 a 100]: ");
                                assento = int.Parse(Console.ReadLine());

                                if (nomePassageiro != "")
                                {
                                    Console.Write($"Mesmo passageiro [{nomePassageiro}] [S/N]: ");
                                    if (Console.ReadLine() == "N")
                                    {
                                        Console.Write("Escreva o nome do passageiro: ");
                                        nomePassageiro = Console.ReadLine();
                                    }
                                }
                                else
                                {
                                    Console.Write("Escreva o nome do passageiro: ");
                                    nomePassageiro = Console.ReadLine();
                                }

                                Console.WriteLine();
                                ocupouAssento = voo.OcuparVaga(assento, nomePassageiro);
                                Console.WriteLine();

                                if (!ocupouAssento)
                                {
                                    Console.Write("Deseja escolher outro assento? [S/N]: ");
                                    outroAssento = (Console.ReadLine() == "S") ? true : false;
                                }
                                else
                                {
                                    outroAssento = false;
                                }


                            }

                            Console.Write("Deseja fazer outra reserva? [S/N] ");
                            outroAssento = (Console.ReadLine() == "S") ? true : false;
                            ocupouAssento = false;

                        } while (outroAssento);

                        break;

                    case 2:

                        Console.WriteLine("=================================================================");
                        Console.WriteLine($"Existem {voo.VagasLivres()} vagas livres nesse vôo.");
                        Console.WriteLine("=================================================================");
                        break;

                    case 3:

                        Console.WriteLine("=================================================================");
                        Console.WriteLine($"Próxima cadeira livre: {voo.CadeiraLivre()}.");
                        Console.WriteLine("=================================================================");
                        break;

                    case 4:

                        Console.WriteLine("=====================");
                        Console.WriteLine($"    DADOS DO VOO    ");
                        Console.WriteLine("=====================");
                        voo.VerHorario();
                        Console.WriteLine("=====================");
                        break;
                    case 5:
                        break;
                    default:
                        break;
                }

            } while (operacao != 5);
            /*Console.WriteLine();
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Reservar um Assento.");
            Console.WriteLine("2 - Saber a disponibilidade de vagas.");
            Console.WriteLine("3 - Saber qual a próxima cadeira livre.");
            Console.WriteLine("4 - Ver as informações do vôo.");
            Console.WriteLine("5 - Sair.");
            
            Console.WriteLine();
            Console.Write("Digite a operação: ");
            operacao = int.Parse(Console.ReadLine());
            Console.WriteLine();*/




        }

        static void A5E3Calculadora()
        {
            int primeiroNumero = 0;
            int segundoNumero = 0;
            int operacao = 0;
            Calculadora calculadora = new Calculadora();



            while (operacao != 5)
            {
                Console.WriteLine();
                Console.WriteLine("*****************************************");
                Console.WriteLine("* Escolha a operação?                   *");
                Console.WriteLine("* 1 - Multiplicação.                    *");
                Console.WriteLine("* 2 - Divisão.                          *");
                Console.WriteLine("* 3 - Subtração.                        *");
                Console.WriteLine("* 4 - Soma.                             *");
                Console.WriteLine("* 5 - Sair.                             *");
                Console.WriteLine("*****************************************");
                Console.WriteLine();
                Console.Write("Digite a operação: ");
                operacao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (operacao != 5)
                {
                    Console.Write("Digite o 1o. numero: ");
                    primeiroNumero = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Console.Write("Digite o 2o. numero: ");
                    segundoNumero = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }

                switch (operacao)
                {
                    case 1:
                        Console.WriteLine($"O resultado da Multiplicação é {calculadora.Multiplicacao(primeiroNumero, segundoNumero)}.");
                        break;
                    case 2:
                        Console.WriteLine($"O resultado da Divisão é {calculadora.Divisao(primeiroNumero, segundoNumero)}.");
                        break;
                    case 3:
                        Console.WriteLine($"O resultado da Subtração é {calculadora.Subtracao(primeiroNumero, segundoNumero)}.");
                        break;
                    case 4:
                        Console.WriteLine($"O resultado da Soma é {calculadora.Soma(primeiroNumero, segundoNumero)}.");
                        break;
                    case 5:
                        break;
                }
            }


        }


    }
}