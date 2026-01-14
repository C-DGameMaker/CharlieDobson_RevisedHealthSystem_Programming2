using System;

namespace CharlieDobson_RevisedHealthSystem_Programming2
{
    internal class Health
    {
        //Properties
        public int CurrentHealth { get;  private set; }
        public int MaxHealth { get; private set; }

        //Constructor
        public Health(int maxHealth)
        {
            MaxHealth = maxHealth;
            CurrentHealth = MaxHealth;
        }

        //Methods
        public void TakeDamage(int damageAmount)
        {
            //Checks to see if Damage taken is below 0
            if(damageAmount < 0)
            {
                Console.Write("WARNING! A player cannot take negative damage.");
                damageAmount = 0;
            }

            CurrentHealth -= damageAmount;

            if(CurrentHealth < 0)
            {
                CurrentHealth = 0;
            }
        }

        public void Heal(int healAmount)
        {
            //Checks to see if amount to be healed is below 0
            if (healAmount < 0)
            {
                Console.Write("WARNING! A player cannot heal a negative amount.");
                healAmount = 0;
            }

            //checks to see if amount heal + the current health will heal over the max health
            if(healAmount + CurrentHealth > MaxHealth)
            {
                CurrentHealth = MaxHealth;
            }
            else
            {
                CurrentHealth += healAmount;
            }

            
        }

        //Restore current Health to it's max
        public void Restore()
        {
            CurrentHealth = MaxHealth;
        }

    }
}
