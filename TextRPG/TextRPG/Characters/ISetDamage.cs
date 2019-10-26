using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Characters
{
    interface ISetDamage
    {
        /// <summary>
        /// Метод реализующий получение урона
        /// </summary>
        /// <param name="damage">Количество урона</param>
        void SetDamage(int damage);

        /// <summary>
        /// Метод возвращающий попадание/промах по объекту
        /// </summary>
        /// <param name="attack"></param>
        bool Attack(int attack);
    }
}
