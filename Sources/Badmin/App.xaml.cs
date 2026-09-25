namespace Badmin
{
	using Microsoft.Extensions.DependencyInjection;

	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
		}

		protected override Window CreateWindow(IActivationState activationState)
		{
			const int newHeight = 800;
			const int newWidth = 400;

			var newWindow = new Window(new AppShell())
			{
				Height = newHeight,
				Width = newWidth
			};

			return newWindow;
		}
	}
}