namespace MauiComm_IssuePopupShow
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void btnNext_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }

        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);
            GC.Collect();
        }
    }
}
