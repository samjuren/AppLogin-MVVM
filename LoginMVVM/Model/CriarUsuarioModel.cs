using SQLite;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LoginMVVM.Model
{
    [Table("CriarUsuario")]
    public class CriarUsuarioModel : INotifyPropertyChanged
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

        private string? nomeCompleto;
        [NotNull, MaxLength(100)]
        public string? NomeCompleto
        {
            get { return nomeCompleto; }
            set
            {
                nomeCompleto = value;
                OnPropertyChanged();
            }
        }

        private int? idade;
        [NotNull, MaxLength(100)]
        public int? Idade
        {
            get { return idade; }
            set
            {
                idade = value;
                OnPropertyChanged();
            }
        }


        private string? cpf;
        [NotNull, MaxLength(100)]
        public string? CPF
        {
            get { return cpf; }
            set
            {
                cpf = value;
                OnPropertyChanged();
            }
        }

        private string? rg;
        [NotNull, MaxLength(100)]
        public string? RG
        {
            get { return rg; }
            set
            {
                rg = value;
                OnPropertyChanged();
            }
        }

        private LoginModel? logins;
        [NotNull, MaxLength(100)]
        public LoginModel? Logins
        {
            get { return logins; }
            set
            {
                logins = value;
                OnPropertyChanged();
            }
        }
    }
}
