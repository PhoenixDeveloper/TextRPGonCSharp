using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG;

namespace TextRPG.Characters
{
    public abstract class BaseCharacter: ISetDamage
    {
        protected string name;
        protected ClassCharacter classCharacter;
        protected int levelCharacter;
        protected int hp;
        protected int classDeference;
        protected int initiative;

        public BaseCharacter(string name,
            ClassCharacter classCharacter,
            int levelCharacter,
            int hp,
            int classDeference)
        {
            this.name = name;
            this.classCharacter = classCharacter;
            this.levelCharacter = levelCharacter;
            this.hp = hp;
            this.classDeference = classDeference;
        }

        #region Свойства доступа к параметрам
        /// <summary>
        /// Получить имя персонажа
        /// </summary>
        public string GetName
        {
            get { return name; }
        }

        /// <summary>
        /// Получить класс персонажа
        /// </summary>
        public ClassCharacter GetClass
        {
            get { return classCharacter; }
        }

        /// <summary>
        /// Получить уровень персонажа
        /// </summary>
        public int GetLevel
        {
            get { return levelCharacter; }
        }

        /// <summary>
        /// Получить количество очков здоровья персонажа
        /// </summary>
        public int GetHitPoint
        {
            get { return hp; }
        }

        /// <summary>
        /// Получить класс защиты персонажа
        /// </summary>
        public int GetClassDeference
        {
            get { return classDeference; }
        }

        /// <summary>
        /// Получить текущее значение инициативы персонажа
        /// </summary>
        public int GetInitiative
        {
            get { return initiative; }
        }
        #endregion

        public void SetDamage(int damage)
        {
            if (hp - damage < 0)
            {
                hp = 0;
            }
            else
            {
                hp -= damage;
            }
        }

        /// <summary>
        /// Получить жив ли персонаж
        /// </summary>
        public bool IsAlive
        {
            get { return hp > 0; }
        }

        public bool Attack(int attack)
        {
            return attack >= classDeference;
        }

        /// <summary>
        /// Бросок кубика на инициативу
        /// </summary>
        public void SetInitiative()
        {
            initiative = CubesNumber.D20;
        }

        /// <summary>
        /// Действия в бою
        /// </summary>
        /// <param name="character">Персонаж против которого совершать действия</param>
        public abstract void TakeAction(BaseCharacter character);
    }
}
