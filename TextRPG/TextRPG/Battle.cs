using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Characters;

namespace TextRPG
{
    public static class Battle
    {
        public static bool StartBattle(List<BaseCharacter> characters)
        {
            BaseCharacter hero;
            List<BaseCharacter> enemy = new List<BaseCharacter>();
            foreach (BaseCharacter character in characters)
            {
                character.SetInitiative();
                if (character is Hero)
                {
                    hero = character;
                }
                else if (character is Enemy)
                {
                    enemy.Add(character);
                }
            }

        }
    }
}
