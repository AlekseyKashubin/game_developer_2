// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Gamers Let's Battle");





Attack water = new Attack("Water Blast", 27);
Attack ice = new Attack("Freeze", 19);
Attack fire = new Attack("Fire Ball", 20);


List<Attack> Attacks= new List<Attack>();
Attacks.Add(water);
Attacks.Add(ice);
Attacks.Add(fire);

Enemy troll = new Enemy("Frost Troll");
Enemy giant = new Enemy("White Giant");


List<Attack> EnemyAttacks= new List<Attack>()
{
    water,
    ice,
    fire
};

troll.AttackList = EnemyAttacks; 

// Console.WriteLine(troll.RandomAttack().Name);


//1.Create instances of the Melee, Ranged, and Magic Caster classes
Magic harry = new Magic("Harry Potter");
Melee conan = new Melee("Conan");
Ranged robin = new Ranged("Robin Hood"); 


//2.Perform the Kick Attack from your Melee class character on your Ranged character
conan.PerformAttack(robin, conan.AttackList[1]);

//3.Perform the Rage method from your Melee class character on your Magic Caster character
conan.Rage(harry);

//4.Perform the Shoot an Arrow Attack from your Ranged character on your Melee character
robin.PerformAttack(conan, robin.AttackList[0]);

//5.Have your Ranged character perform the Dash method
robin.Dash();

//6.Perform another Shoot an Arrow Attack from your Ranged character
robin.PerformAttack(conan, robin.AttackList[0]);

//7.Perform a Fireball Attack from your Magic Caster on your Melee characte
harry.PerformAttack(conan, harry.AttackList[0]);

//8.Have the Magic Caster perform the Heal method on the Ranged character
harry.Heal(robin);

//9.Have the Magic Caster perform the Heal method on themselves
harry.Heal(harry);
