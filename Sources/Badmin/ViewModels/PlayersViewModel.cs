namespace Badmin.ViewModels
{
	using Badmin.Models;

	using CommunityToolkit.Mvvm.ComponentModel;
	using CommunityToolkit.Mvvm.Input;

	public partial class PlayersViewModel : ObservableObject
	{
		public PlayersViewModel()
		{
			this.Players = new List<Player>
			{
				new Player
				{
					Name = "Joe",
				},
				new Player
				{
					Name = "Leonie",
				},
			};
		}

		[ObservableProperty]
		public partial List<Player> Players { get; set; }

		[RelayCommand]
		private async Task NavgiateToPlayer()
		{
			await Shell.Current.GoToAsync($"player");
		}
	}
}
