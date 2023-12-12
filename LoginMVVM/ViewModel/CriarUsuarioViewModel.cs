using LoginMVVM.Model;
using LoginMVVM.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace LoginMVVM.ViewModel
{
    public class CriarUsuarioViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private CriarUsuarioModel? _CriarUsuario;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ICommand BtnSalvar;

        public CriarUsuarioViewModel(IService _service)
        {
            BtnSalvar = new Command(async () =>
            {
                await _service.AddUsuario(_CriarUsuario);
            });
        }
    }
}
