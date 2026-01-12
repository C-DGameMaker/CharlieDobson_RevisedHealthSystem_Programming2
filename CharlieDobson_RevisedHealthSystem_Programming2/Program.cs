using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieDobson_RevisedHealthSystem_Programming2
{
    internal class Program
    {
        public static Player player;

        public static Random rand;
        public static bool isDead;
        static void Main(string[] args)
        {
            Console.Write("Enter a name for your Player: ");
            string name = Console.ReadLine();

            player = new Player(name: name, maxHealth: 100, maxShield: 50);
            HUD();
            Console.ReadKey(true);

            while(isDead = false)
            {
                Console.WriteLine("Press 'D' to Damage, Press 'H' to Heal. Press 'R' to fully restore.");
                
            }
        }

        static void HUD()
        {
            Console.WriteLine($"Player Name: {player.Name}");
            Console.WriteLine($"Player Health: {player.PlayerHealth.CurrentHealth}/{player.PlayerHealth.MaxHealth}");
            Console.WriteLine($"Health Status: {player.GetStatusString()}");
            Console.WriteLine($"Player Shield: {player.PlayerShield.CurrentHealth}/{player.PlayerShield.MaxHealth}");

        }
    }
}
