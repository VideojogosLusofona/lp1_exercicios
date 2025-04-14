using System;

namespace TrapAnalyzer
{
    [Flags]
    public enum PlayerGear
    {
        None = 0,
        Helmet = 1,
        Shield = 2,
        Boots = 4,
    }
}