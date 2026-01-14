using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CharlieDobson_RevisedHealthSystem_Programming2
{
    internal class Program
    {
        //statics based off of different classes
        public static Player player;
        public static Random random = new Random();

        //Static based off of bools
        public static bool isDead;
        static bool correctKeyPress;

        //Static based off keyboard input
        static ConsoleKeyInfo input = default;
        static void Main(string[] args)
        {
            Console.Write("Enter a name for your Player: ");
            string name = Console.ReadLine();

            player = new Player(name: name, maxHealth: 100, maxShield: 50);
            Console.WriteLine(" ");
            HUD();
            Console.ReadKey(true);
            isDead = false;

            while(isDead == false)
            {
                
                correctKeyPress = false;
                input = default;
                while(correctKeyPress == false)
                {
                    Console.Clear();
                    HUD();
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~\n");
                    Console.WriteLine("Press 'D' to Damage, Press 'H' to Heal. Press 'R' to fully restore.");
                    input = Console.ReadKey(true);
                    

                    if(input.Key == ConsoleKey.D)
                    {
                        Console.Clear();
                        Damage();
                        correctKeyPress = true;
                    }
                    else if (input.Key == ConsoleKey.H)
                    {
                        Console.Clear();
                        Heal();
                        correctKeyPress = true;
                    }
                    else if (input.Key == ConsoleKey.R)
                    {
                        Console.Clear();
                        Restore();
                        correctKeyPress = true;
                    }
                    else
                    {
                        Console.Write("PLEASE INPUT CORRECT KEY!");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }

                    
                }

                if (player.PlayerHealth.CurrentHealth == 0)
                {
                    isDead = true;
                }


            }

            Console.WriteLine("YOU DIED! Press any key to end the program.");
            Console.ReadKey(true);
            Console.Clear();
        }

        static void HUD()
        {
            Console.WriteLine($"Player Name: {player.Name}");
            Console.WriteLine($"Player Health: {player.PlayerHealth.CurrentHealth}/{player.PlayerHealth.MaxHealth}");
            Console.WriteLine($"Health Status: {player.GetStatusString()}");
            Console.WriteLine($"Player Shield: {player.PlayerShield.CurrentHealth}/{player.PlayerShield.MaxHealth}");

        }

        //Runs take damage in the player class
        static void Damage()
        {
            int damageAmount = random.Next(1, 21);
            player.TakeDamage(damageAmount);

        }
         
        //Runs heal on the player health, not the shield
        static void Heal()
        {
            int healAmount = random.Next(1, 21);
            player.PlayerHealth.Heal(healAmount);
        }
        
        //Restores Health and shield to max
        static void Restore()
        {
            player.PlayerShield.Restore();
            player.PlayerHealth.Restore();
        }

    }
}
