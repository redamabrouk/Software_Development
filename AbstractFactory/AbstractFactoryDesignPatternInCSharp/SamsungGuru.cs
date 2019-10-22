﻿namespace AbstractFactoryDesignPatternInCSharp
{
    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    class SamsungGuru : INormalPhone
    {
        public string GetModelDetails()
        {
            return "Model: Samsung Guru\nRAM: NA\nCamera: NA\n";
        }
    }
}
