namespace TEMP;

public partial class second : ContentPage
{
	public second()
	{
		InitializeComponent();
	}

    private async void back_Clicked(object sender, EventArgs e)
    {
		await AppShell.Current.GoToAsync("..");
    }
}