namespace AbstractFactoryDesignPatternInCSharp
{
    /// <summary>
    /// The 'AbstractFactory' interface.
    /// </summary>
    interface IMobilePhone
    {
        ISmartPhone GetSmartPhone();
        INormalPhone GetNormalPhone();
    }
}
