namespace SoftwareArchitecture.Design_Patterns.Creational_Patterns.AbstractFactory
{
    public class WindowsButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering Windows button [▓▓▓]");
        public void OnClick() => Console.WriteLine("Windows click event fired");
    }

    public class WindowsCheckbox : ICheckbox
    {
        public bool IsChecked { get; private set; }
        public void Render() => Console.WriteLine($"Rendering Windows checkbox [{(IsChecked ? "X" : " ")}]");
    }

    public class WindowsDropDown : IDropdown
    {
        public string SelectedValue { get; } = "Option 1";
        public void Render() => Console.WriteLine($"Rendering Windows dropdown ▼ {SelectedValue}");
    }
}
