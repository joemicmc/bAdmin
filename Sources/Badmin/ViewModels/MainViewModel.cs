namespace Badmin.ViewModels
{
	using CommunityToolkit.Mvvm.ComponentModel;

	public partial class MainViewModel : ObservableObject
	{
		[ObservableProperty]
		public partial string Title { get; set; } = "bAdmin";
	}
}
