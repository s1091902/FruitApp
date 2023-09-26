namespace FruitApp
{
    public partial class MainPage : ContentPage
    {
        List<string> list = new List<string>() { "Apple", "Banana", "Orange", "Guava", "Peach" };

        public MainPage()
        {
            InitializeComponent();
            FruitListView.ItemsSource = list;
        }

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.PushModalAsync(new Page2());
        //}
        private void FruitListView_ItemSelected(object sender,SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            DisplayAlert("Slected", e.SelectedItem.ToString(), "OK");
            ((ListView)sender).ItemsSource = null;
        }


    }
}