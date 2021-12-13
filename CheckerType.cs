using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkers_game
{

    // тип хода
    public enum CheckerType
    {
        Free, // без значения
        P1_check, // игрок 1 пешка
        P1_king, // игрок 1 король
        P2_check, // игрок 2 пешка
        P2_king //игрок 2 король

    }
}