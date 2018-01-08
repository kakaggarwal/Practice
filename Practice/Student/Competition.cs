using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Student
{
    class Competition
    {
        public static void FormTeams()
        {
            int totPlayers;
            int teams;
            int leftPlayers;

            Console.Write("Enter the total no. of players: ");
            totPlayers = Convert.ToInt32(Console.ReadLine());

            teams = totPlayers / 5;
            leftPlayers = totPlayers % 5;

            Console.WriteLine("No. of Teams: {0}\nLeft Players: {1}", teams, leftPlayers);
        }
    }
}
