using LoginMVVM.Services;
using LoginMVVM.ViewModel;

namespace LoginMVVM.View.Login;

public partial class CriarUsuario : ContentPage
{
	private readonly IService _service;
	public CriarUsuario(IService service)
	{
		InitializeComponent();
		_service = service;
		BindingContext = new CriarUsuarioViewModel(_service);
	}
}