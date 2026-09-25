namespace Badmin.Views
{
	using Badmin.ViewModels;

	public partial class TableView : ContentPage
	{
		public TableView(TableViewModel viewModel)
		{
			InitializeComponent();

			this.BindingContext = viewModel;
		}
	}
}