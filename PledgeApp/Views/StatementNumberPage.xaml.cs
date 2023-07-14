namespace PledgeApp.Views;

public partial class StatementNumberPage : ContentPage
{
	public StatementNumberPage()
	{
		InitializeComponent();
	}

    private async void OpenImagesPage_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ImagesPage));

        //await Shell.Current.GoToAsync($"{nameof(ImagesPage)}?{nameof(ImagesPage.ItemId)}={note.Filename}");
    }
}