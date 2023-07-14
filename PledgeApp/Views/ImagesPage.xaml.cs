using System.Drawing;
namespace PledgeApp.Views;

public partial class ImagesPage : ContentPage
{
    Image image;
	public ImagesPage()
	{
		InitializeComponent();


    }

    private async void OpenCamera_Clicked(object sender, EventArgs e)
    {
        if (MediaPicker.Default.IsCaptureSupported)
        {
            FileResult photo = await MediaPicker.Default.CapturePhotoAsync();
            if (photo != null)
            {
                string localFilePath = Path.Combine(FileSystem.CacheDirectory, photo.FileName);

                using Stream sourceStream = await photo.OpenReadAsync();
                using FileStream localFileStream = File.OpenWrite(localFilePath);

                await sourceStream.CopyToAsync(localFileStream);
                TestImg.Source = ImageSource.FromFile(localFilePath);

            }
        }
    }

    private async void TwoClicked(object sender, EventArgs e)
    {
         
    }
}