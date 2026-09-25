namespace Badmin.Views
{
	using Badmin.ViewModels;

	public partial class EditPlayerView : ContentPage
	{
		public EditPlayerView(EditPlayerViewModel viewModel)
		{
			InitializeComponent();

			this.BindingContext = viewModel;
		}
	}
}