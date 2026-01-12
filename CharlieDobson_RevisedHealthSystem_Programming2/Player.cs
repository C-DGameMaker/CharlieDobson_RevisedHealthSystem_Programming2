using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieDobson_RevisedHealthSystem_Programming2
{
    internal class Player
    {
        //Properties
        public String Name { get; set; }

        public Health PlayerHealth { get; private set; }
        public Health PlayerShield { get; private set; }

        //Constructor
        public Player(string name, int maxHealth, int maxShield)
        {
            Name = name;
            //Player Health
            //Player shield
        }

        //Methods
        public void TakeDamage(int damageAmount)
        {
            //Checks to see if Damage taken is below 0
            if (damageAmount < 0)
            {
                Console.Write("WARNING! A player cannot take negative damage.");
                damageAmount = 0;
            }


        }

        public string GetStatusString()
        {
            string status = "";
            if (PlayerHealth.CurrentHealth <= 0)
            {
                status = "Dead.";
            }
            return status;
        }

    }
}
