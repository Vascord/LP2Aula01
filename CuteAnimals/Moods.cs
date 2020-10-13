using System;

namespace CuteAnimals
{
    [Flags]
    public enum Moods
    {
        Depressed = 1,
        Happy = 2,
        Grumpy = 4,
        Uninterested = 8
    }
}
