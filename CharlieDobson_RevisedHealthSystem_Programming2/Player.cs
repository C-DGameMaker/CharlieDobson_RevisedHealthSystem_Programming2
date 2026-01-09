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

        String Name { get; set; }

        Health PlayerHealth { get; set; }
        Health PlayerShield { get; set; }

        //Constructor
        public Player(string name, int maxHealth, int maxShield)
        {
            Name = name;
            //PlayerHealth = maxHealth;
            //PlayerShield = maxShield;
        }

        //Methods
        public void TakeDamage(int damageAmount)
        {

        }

        public string GetStatusString()
        {
            string status;
            if(PlayerHealth <= 0)
            {
                status = "Dead.";
            }
            return status;
        }

    }
}
