namespace Badmin.ViewModels
{
	using CommunityToolkit.Mvvm.ComponentModel;
	using CommunityToolkit.Mvvm.Input;

	public partial class EditPlayerViewModel : ObservableObject
	{
		[RelayCommand]
		private async Task NavigateBack()
		{
			await Shell.Current.GoToAsync($"..");
		}
	}
}
