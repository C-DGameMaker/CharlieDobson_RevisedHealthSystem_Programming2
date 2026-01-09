using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieDobson_RevisedHealthSystem_Programming2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a name for your Player: ");
            string name = Console.ReadLine();

            Player player = new Player(name: name, maxHealth: 100, maxShield: 50);
        }
    }
}
