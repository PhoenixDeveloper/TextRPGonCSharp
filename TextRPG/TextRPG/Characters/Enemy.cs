using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Characters
{
    public class Enemy: BaseCharacter
    {
        public Enemy(string name,
            ClassCharacter classCharacter,
            int levelCharacter,
            int hp,
            int classDeference) : base(name, classCharacter, levelCharacter, hp, classDeference)
        { }

        public override void TakeAction(BaseCharacter character)
        {
            Console.WriteLine($"Ходит {name}");
            Console.ReadKey();
            Console.WriteLine($"{name} пытается вас атаковать!");
            Console.ReadKey();
            int attack = CubesNumber.D20;
            if (character.Attack(attack))
            {
                int damage = CubesNumber.D4;
                character.SetDamage(damage);
                Console.WriteLine($"{name} наносит {character.GetName} {damage} урона");
                Console.ReadKey();
                Console.WriteLine(character.IsAlive ? $"У {character.GetName} осталось {character.GetHitPoint} HP" : $"{character.GetName} отдал душу Создателю");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"И у него ничего не выходит. КД {character.GetName}: {character.GetClassDeference}." +
                    $"Атака {name}: {attack}");
                Console.ReadKey();
            }
        }
    }
}
