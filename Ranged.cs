public class Ranged : Enemy
{
    public int DistanceField = 5;



    public Ranged(string name) : base(name)
    {
    


        AttackList = new List<Attack>()
        {
            new Attack("Shoot Arrow", 20),
            new Attack("Throw Knife", 15),
        };
    }

    public bool Distance(Enemy Target)
    {
        if (DistanceField >= 10)
        {
            return true;
        }
        else
        {
            return false;
        }
    }



    public void Dash()
    {
        DistanceField = 20;
        Console.WriteLine($"{this.Name} Dashed {DistanceField} feet away");
    }

    public void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if (!Distance(Target))
        {
            Console.WriteLine($"{this.Name} cant attack {Target.Name}, you are {DistanceField}ft away thats too close use Dash!!");
            return;
        }
        base.PerformAttack(Target, ChosenAttack);
    }

}
