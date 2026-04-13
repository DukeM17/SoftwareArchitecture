namespace SoftwareArchitecture.Design_Patterns.Creational_Patterns.AbstractFactory
{
    internal class WindowsUIFactory : IUIFactory
    {
        public IButton CreateButton() => new WindowsButton();

        public ICheckbox CreateCheckbox() => new WindowsCheckbox();

        public IDropdown CreateDropdown() => new WindowsDropDown();
    }
}
