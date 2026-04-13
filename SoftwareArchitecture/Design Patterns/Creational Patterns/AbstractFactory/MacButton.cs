namespace SoftwareArchitecture.Design_Patterns.Creational_Patterns.AbstractFactory
{
    public class MacButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering Mac button (●)");
        public void OnClick() => Console.WriteLine("Mac click event fired");
    }

    public class MacCheckbox : ICheckbox
    {
        public bool IsChecked { get; private set; }
        public void Render() => Console.WriteLine($"Rendering Mac checkbox ◉ {(IsChecked ? "on" : "off")}");
    }

    public class MacDropdown : IDropdown
    {
        public string SelectedValue { get; } = "Option 1";
        public void Render() => Console.WriteLine($"Rendering Mac dropdown ⌄ {SelectedValue}");
    }
}
