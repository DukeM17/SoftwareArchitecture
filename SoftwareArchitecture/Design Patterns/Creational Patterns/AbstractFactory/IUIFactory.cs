namespace SoftwareArchitecture.Design_Patterns.Creational_Patterns.AbstractFactory
{
    public interface IUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
        IDropdown CreateDropdown();
    }
}
