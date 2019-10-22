﻿namespace AbstractFactoryDesignPatternInCSharp
{
    /// <summary>
    /// The 'ConcreteFactory2' class.
    /// </summary>
    class Samsung : IMobilePhone
    {
        public ISmartPhone GetSmartPhone()
        {
            return new SamsungGalaxy();
        }

        public INormalPhone GetNormalPhone()
        {
            return new SamsungGuru();
        }
    }
}
