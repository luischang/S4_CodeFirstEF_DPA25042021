using S4_CodeFirstEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace S4_CodeFirstEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new MundialFIFADBContext();

            //var player1 = new Player();
            //player1.FullName = "Cristiano Ronaldo";
            //player1.Dorsal = 7;

            ////Add Player
            //context.Player.Add(player1);
            //context.SaveChanges();

           
            //var player2 = new Player();
            //player2.FullName = "Lionel Messi";
            //player2.Dorsal = 10;

            //var player3 = new Player();
            //player3.FullName = "Paolo Guerrero";
            //player3.Dorsal = 9;

            //var player4 = new Player();
            //player4.FullName = "Francesco Totti";
            //player4.Dorsal = 11;

            //var playerList = new List<Player>();
            //playerList.Add(player2);
            //playerList.Add(player3);
            //playerList.Add(player4);


            ////Add Player
            //context.Player.AddRange(playerList);
            //context.SaveChanges();

            //Query by LINQ

            var searchPlayer = (from p in context.Player
                                where p.Dorsal == 10
                                select p).FirstOrDefault();

            Console.WriteLine("El jugador encontrado es: " + searchPlayer.FullName + " y tiene el dorsal " + searchPlayer.Dorsal);

            context.Player.Remove(searchPlayer);
            context.SaveChanges();

            //Query Lambda Expression
            var searchPlayerLambda = context.Player.Where(x => x.Dorsal == 11).FirstOrDefault();

            searchPlayerLambda.FullName = "Pedro Aquino";
            context.SaveChanges();



            Console.WriteLine("Hello World!");
        }
    }
}
