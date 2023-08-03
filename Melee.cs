public class Melee : Enemy
{
    public Melee(string name) : base(name)
    {
        Health = 120;
        AttackList = new List<Attack>()
        {
            new Attack("Punch", 20),
            new Attack("Kick", 15),
            new Attack("Tackle", 25)
        };
    }
    public void Rage(Enemy Target)
    {
        Attack rageAttack = this.RandomAttack();
        rageAttack.DamageAmount += 10;
        this.PerformAttack(Target, rageAttack);
        rageAttack.DamageAmount -= 10;

        Console.WriteLine($"{this.Name} used Rage {Target.Name} HP is now {Target.Health}");
    }
}

