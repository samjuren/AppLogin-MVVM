using SQLite;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LoginMVVM.Model
{
    [Table("Login")]
    public class LoginModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private int id;
        [PrimaryKey, AutoIncrement]
        public int Id 
        {
            get { return id; }
            set 
            {
                id = value;
                OnPropertyChanged();
            }
        }

        private string login;
        [NotNull, MaxLength(100)]
        public string? Login
        {
            get { return login; }
            set
            {
                login = value;
                OnPropertyChanged();
            }
        }
        private string senha;
        [NotNull, MaxLength(100)]
        public string? Senha
        {
            get { return senha; }
            set
            {
                senha = value;
                OnPropertyChanged();
            }
        }
    }
}