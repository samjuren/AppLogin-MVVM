using LoginMVVM.Services;

namespace LoginMVVM
{
    public partial class App : Application
    {
        public App(IService service)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage(service));
        }
    }
}
