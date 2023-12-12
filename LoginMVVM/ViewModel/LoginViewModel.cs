using LoginMVVM.Model;
using LoginMVVM.Services;
using LoginMVVM.View.Login;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace LoginMVVM.ViewModel
{
    public partial class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public LoginModel _loginModel;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        //Ação do botão
        public ICommand BtnCriarUsuario { get; set; }
        public ICommand BtnEntrar { get; set; }

        public LoginViewModel(IService service)
        {
            BtnCriarUsuario = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushModalAsync(new CriarUsuario(service));
            });

            BtnEntrar = new Command(async () =>
            {
                if (service.ChecarLogin(_loginModel.Login, _loginModel.Senha) == null)
                {
                    await App.Current.MainPage.DisplayAlert("Alerta!", "Login ou Senha inválidos", "OK");
                }
                else
                {
                    //await Application.Current.MainPage.Navigation.PushModalAsync(new CriarUsuario());
                }
            });
        }
    }
}
