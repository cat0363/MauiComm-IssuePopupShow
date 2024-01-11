using CommunityToolkit.Maui.Views;

namespace MauiComm_IssuePopupShow;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

    ~Page1()
    {
        IDispatcherTimer timer;
        timer = Dispatcher.CreateTimer();
        timer.Interval = new TimeSpan(0, 0, 0, 0, 30000);
        timer.Tick += (s, e) =>
        {
            timer.Stop();

            MainThread.BeginInvokeOnMainThread(() =>
            {
                try
                {
                    TestPopup tp = new TestPopup();
                    this.ShowPopupAsync(tp);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message + ex.StackTrace);
                }
            });
        };
        timer.Start();
    }

    void btnBack_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}