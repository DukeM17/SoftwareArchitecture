using SoftwareArchitecture.Design_Patterns.Creational_Patterns.AbstractFactory;

IUIFactory factory = Environment.OSVersion.Platform == PlatformID.Win32NT
    ? new WindowsUIFactory()
    : new MacUIFactory();

var loginForm = new Login(factory);
loginForm.RenderForm();