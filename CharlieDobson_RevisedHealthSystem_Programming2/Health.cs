using System;

namespace CharlieDobson_RevisedHealthSystem_Programming2
{
    internal class Health
    {
        //Properties
        int CurrentHealth { get; set; }
        int MaxHealth { get; set; }

        //Constructor
        public Health(int maxHealth)
        {
            MaxHealth = maxHealth;
            CurrentHealth = MaxHealth;
        }

        //Methods
        public void TakeDamage(int damageAmount)
        {
            if(damageAmount < 0)
            {
                Console.Write("WARNING! A player cannot take negative damage.");
                damageAmount = 0;
            }

            CurrentHealth -= damageAmount;
        }

        public void Heal(int healAmount)
        {
            if (healAmount < 0)
            {
                Console.Write("WARNING! A player cannot heal a negative amount.");
                healAmount = 0;
            }

            if(healAmount + CurrentHealth > MaxHealth)
            {
                CurrentHealth = MaxHealth;
            }
            else
            {
                CurrentHealth += healAmount;
            }

            
        }

        public void Restore()
        {
            CurrentHealth = MaxHealth;
        }

    }
}
