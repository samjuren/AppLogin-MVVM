using LoginMVVM.Model;

namespace LoginMVVM.Services
{
    public interface IService
    {
        Task InitializeAsync();
        Task<List<LoginModel>> GetLogins();
        Task<LoginModel> GetLoginById(int id);
        Task AddLogin(LoginModel login);
        Task ExcluirLogin(LoginModel login);
        Task AtualizarLogin(LoginModel login);
        Task<LoginModel> ChecarLogin(string Login, string Senha);

        // Criar Usuario
        Task AddUsuario(CriarUsuarioModel criarUsuario);
    }
}