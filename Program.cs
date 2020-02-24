using System;
using System.Linq;

namespace practice
{
    public class practice 
    {
        static void Main(string[] args)
        {
            Fighter fighter1 = new Fighter ("Tom",5,5);
            Fighter fighter2 = new Fighter ("Jeff",5,5);
            Console.WriteLine(declareWinner(fighter1, fighter2, "Jeff"));
            Console.Read();
              
        }
        public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker) 
        {  
           
            var fighters = new [] { fighter1, fighter2 };
    
            var Attacker = fighters.Single(f => f.Name == firstAttacker);
            var Defender = fighters.Single(f => f.Name != firstAttacker);
            Defender.Health -= Attacker.DamagePerAttack;
            if(Defender.Health <= 0)
            {
            return Attacker.Name;
            }
            return declareWinner(fighter1, fighter2, Defender.Name);
        }
        public class Fighter {
            public string Name;
            public int Health, DamagePerAttack;
            public Fighter(string name, int health, int damagePerAttack) {
                this.Name = name;
                this.Health = health;
                this.DamagePerAttack = damagePerAttack;
            }
        }


    }
}
