namespace Badmin.ViewModels
{
	using CommunityToolkit.Mvvm.ComponentModel;

	public partial class TableViewModel : ObservableObject
	{
		[ObservableProperty]
		public partial string Title { get; set; } = "Table";
	}
}
