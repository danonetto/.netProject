using WorkouTracker.ViewModels;

namespace WorkouTracker.Views
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        private readonly MainViewModel ViewModel;
        public MainPage(MainViewModel mainViewModel)
        {
            InitializeComponent();
            BindingContext = mainViewModel;
            ViewModel = mainViewModel;
            LoadData();
        }

        private async Task LoadData()
        {
            await ViewModel.LoadExercisesAsync();
        }

  
    }
}
