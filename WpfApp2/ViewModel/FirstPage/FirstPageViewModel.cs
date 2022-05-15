namespace WpfApp2.ViewModel
{
    internal class FirstPageViewModel : ViewModelBase
    {
        public FirstPageViewModel()
        {
            
        }
        private int _anime;
        public int Anime
        {
            get => _anime; set => Set(ref _anime, value);
        }



    }
}
