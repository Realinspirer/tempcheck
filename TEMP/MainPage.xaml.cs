namespace TEMP
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void go_Clicked(object sender, EventArgs e)
        {
            await AppShell.Current.GoToAsync(nameof(second));
        }
    }

}
