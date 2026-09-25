namespace Badmin.Views
{
	using Badmin.ViewModels;

	public partial class PlayersView : ContentPage
	{
		public PlayersView(PlayersViewModel viewModel)
		{
			InitializeComponent();

			this.BindingContext = viewModel;
		}
	}
}