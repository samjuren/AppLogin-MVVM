using LoginMVVM.Services;
using LoginMVVM.ViewModel;

namespace LoginMVVM
{
    public partial class MainPage : ContentPage
    {
        private readonly IService _service;
        public MainPage(IService service)
        {
            InitializeComponent();
            _service = service;
            BindingContext = new LoginViewModel(_service);
        }
    }
}
