using System;


namespace Singletone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O Bahia está em campo e vai começar o jogo para a final do mundial de Clubes 2022 Bahia x Real Madrid!!! BBMP!!!!!");
            Ball ball1 = Ball.GetInstanceWithSingleton();
            ball1.Message("Galvão Bueno:Gilberto toca na bola e começa a partida, partiu Gilberto e da excelente toque para Rossi");
            
            
            Ball ball2 = Ball.GetInstanceWithSingleton();
            ball2.Message("Galvão Bueno:Rossi Recebe a Bola tenta driblar o zagueiro do Vitória que coloca a bola para lateral");

            Ball ball4 = Ball.GetInstanceWithoutSingleton();
            ball4.Message("Galvão Bueno:O Bandeirinha jogou mais uma bola em campo");

            Ball ball3 = Ball.GetInstanceWithSingleton();
            ball3.Message("Galvão Bueno:Nino Paraíba pega rapidamente a bola e toca pra Gilberto que faz o gol!!! Gollllllll do Baêaaaaa, BBMP!!!!!");

            Console.ReadKey();
        }
    }
}
