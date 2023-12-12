using LoginMVVM.Model;
using SQLite;

namespace LoginMVVM.Services
{
    public class Service : IService
    {
        private SQLiteAsyncConnection _connection;

        public async Task InitializeAsync()
        {
            await SetUpDb();
        }

        private async Task SetUpDb()
        {
            if (_connection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BancoLoginMVVM.db3");

                _connection = new SQLiteAsyncConnection(dbPath);
                await _connection.CreateTableAsync<LoginModel>();
            }
        }
        public async Task AddLogin(LoginModel login)
        {
            await _connection.InsertAsync(login);
        }

        public async Task AtualizarLogin(LoginModel login)
        {
            await _connection.UpdateAsync(login);
        }

        public async Task ExcluirLogin(LoginModel login)
        {
            await _connection.DeleteAsync(login);
        }

        public async Task<LoginModel> GetLoginById(int id)
        {
            return await _connection.Table<LoginModel>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<LoginModel>> GetLogins()
        {
           return await _connection.Table<LoginModel>().ToListAsync();
        }

        public async Task<LoginModel> ChecarLogin(string Login, string Senha)
        {
             return await _connection.Table<LoginModel>().FirstOrDefaultAsync(x => x.Login == Login && x.Senha == Senha);
        }

        public async Task AddUsuario(CriarUsuarioModel criarUsuario)
        {
            await _connection.InsertAsync(criarUsuario);
        }
    }
}
