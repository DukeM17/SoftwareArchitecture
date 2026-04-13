namespace SoftwareArchitecture.Design_Patterns.Creational_Patterns.AbstractFactory
{
    internal class MacUIFactory : IUIFactory
    {
        public IButton CreateButton() => new MacButton();
        public ICheckbox CreateCheckbox() => new MacCheckbox();
        public IDropdown CreateDropdown() => new MacDropdown();
    }
}
