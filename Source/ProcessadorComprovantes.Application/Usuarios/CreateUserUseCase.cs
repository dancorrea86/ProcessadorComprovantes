using ProcessadorComprovantes.Application.Interfaces;
using ProcessadorComprovantes.Domain.Entities;

namespace ProcessadorComprovantes.Application.Usuarios
{
    public class CreateUserUseCase
    {

        private readonly IUserRepository _repositorio;

        public CreateUserUseCase(IUserRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public List<Usuario> GetUsers()
        {
            List<Usuario> users = _repositorio.GetUsers();
            return users;
        }

        public void Executar(string nome, string pasta)
        {
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(pasta))
            {
                throw new ArgumentException("Por favor, preencha todos os campos.");
            }

            Usuario usuario = new Usuario(nome, pasta);

            _repositorio.SaveUser(usuario);
        }
    }
}
