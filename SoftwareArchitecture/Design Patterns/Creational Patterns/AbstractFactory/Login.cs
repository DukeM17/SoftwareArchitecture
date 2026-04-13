namespace SoftwareArchitecture.Design_Patterns.Creational_Patterns.AbstractFactory
{
    public class Login
    {
        private readonly IButton _button;
        private readonly ICheckbox _checkbox;
        private readonly IDropdown _dropdown;

        public Login(IUIFactory factory)
        {
            _button = factory.CreateButton();
            _checkbox = factory.CreateCheckbox();
            _dropdown = factory.CreateDropdown();
        }

        public void RenderForm()
        {
            Console.WriteLine("-----Rendering Form--------");
            _button.Render();
            _checkbox.Render();
            _dropdown.Render();
        }
    }
}
