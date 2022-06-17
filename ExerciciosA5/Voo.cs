
namespace ExerciciosA5
{
    //2. Escreva uma classe em que cada objeto representa um vôo que acontece 
    //    em determinada data e em determinado horário. 
    //    Cada vôo possui no máximo 100 passageiros, e a classe permite controlar a ocupação das vagas.
    //
    //2.2 A classe deve ter os seguintes métodos:
    //
    //2.2.1 Ocupar Vaga: ocupa determinada cadeira do vôo, cujo número é recebido como parâmetro,
    //                   e retorna verdadeiro se a cadeira ainda não estiver ocupada(operação foi
    //                   bem sucedida) e falso caso contrário
    //2.2.2 Vagas Livres: retorna o número de cadeiras vagas disponíveis(não ocupadas) no vôo;
    //2.2.3 Cadeira Livre: Retorna o número da próxima cadeira livre;
    //2.2.4 Ocupa:  ocupa determinada cadeira do vôo, cujo número é recebido como parâmetro.
    //              Caso a cadeira esteja ocupada exibe uma mensagem, caso esteja vazia,
    //              reserva e exibe uma mensagem de confirmação;
    //2.2.5 Ver horário: Imprime a data e o horário do vôo.
    //OBSERVACAO: JUNTEI OS ITENS 2.2.1 E 2.2.4 no mesmo método, pois ambos tinham caracteristicas em comum.
    internal class Voo
    {
        public string destino = "";
        public string data = "";
        public string horario = "";
        public string[] assentos = new string[100];
        public bool OcuparVaga(int Assento, string NomePassageiro) 
        {
           
            bool sucesso = false;
            if (assentos[Assento - 1] == null)
            {
                assentos[Assento - 1] = NomePassageiro;
                sucesso = true;
                Console.WriteLine($"Assento {Assento} reservado para o passageiro {NomePassageiro}.");
            }
            else
            {
                sucesso = false;
                Console.WriteLine($"ATENCAO: Assento {Assento} JÁ OCUPADO por outro passageiro [{assentos[Assento - 1]}].");
            }
            return sucesso;
                
        }

        public int VagasLivres() 
        {
            int vagasLivres = 0;
            foreach(string lugar in assentos)
            {
                if (lugar == null)
                {
                    vagasLivres++;
                }
            }
            return vagasLivres;
        }

        public int CadeiraLivre() 
        {
            int proximoLugarLivre = 0;
  
            for (int i = 0; i < assentos.Length; i++)
            {
                if (assentos[i] == null)
                {
                    proximoLugarLivre = i + 1;
                    i = assentos.Length;
                }
            }
            return proximoLugarLivre;
        }

        public void VerHorario()
        {
            Console.WriteLine($"Destino: {destino}");
            Console.WriteLine($"Data: {data}");
            Console.WriteLine($"Horário: {horario}");

        }
    }
}
