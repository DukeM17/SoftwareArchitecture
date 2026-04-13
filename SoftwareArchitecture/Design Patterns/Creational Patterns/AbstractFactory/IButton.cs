namespace SoftwareArchitecture.Design_Patterns.Creational_Patterns.AbstractFactory
{
    public interface IButton
    {
        void Render();
        void OnClick();
    }

    public interface ICheckbox
    {
        void Render();
        bool IsChecked { get; }
    }
    public interface IDropdown
    {
        void Render();
        string SelectedValue { get; }
    }
}