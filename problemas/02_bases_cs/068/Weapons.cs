using System;

namespace WeaponSelector
{
    [Flags]
    public enum Weapons
    {
        None = 0,
        SilverBullet = 1,
        Garlic = 2,
        HolyWater = 4,
    }
}