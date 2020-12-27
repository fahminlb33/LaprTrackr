using LaprTrackr.Views;
using Xamarin.Forms;

namespace LaprTrackr
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(RecordDetailPage), typeof(RecordDetailPage));
            Routing.RegisterRoute(nameof(RecordAddPage), typeof(RecordAddPage));
            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
        }

    }
}
