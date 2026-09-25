namespace Badmin.Views
{
	using Badmin.ViewModels;

	public partial class MainView : ContentPage
	{
		public MainView(MainViewModel viewModel)
		{
			InitializeComponent();
			this.BindingContext = viewModel;
		}
	}
}
