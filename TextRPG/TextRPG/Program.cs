using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Characters;

namespace TextRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Alod", ClassCharacter.Warrior, 1, 9, 14);
            Enemy goblin = new Enemy("Rar", ClassCharacter.Warrior, 1, 8, 11);

            Console.WriteLine($@"
                                Приветствую {hero.GetName}!
                                Добро пожаловать в этот огромный мир! Идя по дороге, ты встретился с гоблином {goblin.GetName}. Убей его!");
            Console.ReadKey();
            //Battle.StartBattle(new List<BaseCharacter>() { hero, goblin });
            hero.SetInitiative();
            Console.WriteLine($"Ваша инициатива {hero.GetInitiative}");
            Console.ReadKey();
            goblin.SetInitiative();
            Console.WriteLine($"Инициатива противника {goblin.GetInitiative}");
            Console.ReadKey();
            Console.WriteLine($"{((hero.GetInitiative >= goblin.GetInitiative) ? hero.GetName : goblin.GetName)} ходит первым!");
            Console.ReadKey();
            BaseCharacter init1;
            BaseCharacter init2;

            if (hero.GetInitiative >= goblin.GetInitiative)
            {
                init1 = hero;
                init2 = goblin;
            }
            else
            {
                init1 = goblin;
                init2 = hero;
            }

            while (init1.IsAlive && init2.IsAlive)
            {
                init1.TakeAction(init2);
                if (!init2.IsAlive) break;
                init2.TakeAction(init1);
            }
        }
    }
}
