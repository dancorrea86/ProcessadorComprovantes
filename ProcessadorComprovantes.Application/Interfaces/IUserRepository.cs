using ProcessadorComprovantes.Domain.Entities;

namespace ProcessadorComprovantes.Application.Interfaces
{
    public interface IUserRepository
    {
            void SaveUser(Usuario usuario);
    }
}
