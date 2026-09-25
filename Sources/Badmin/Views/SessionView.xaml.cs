namespace Badmin.Views
{
	using Badmin.ViewModels;

	public partial class SessionView : ContentPage
	{
		public SessionView(SessionViewModel viewModel)
		{
			InitializeComponent();

			this.BindingContext = viewModel;
		}
	}
}