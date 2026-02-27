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
            CurrentHealth -= damageAmount;
        }

        public void Heal(int healAmount)
        {
            CurrentHealth += healAmount;
        }

        //Restore current Health to it's max
        public void Restore()
        {
            CurrentHealth = MaxHealth;
        }

    }
}
