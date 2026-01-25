using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ProcessadorComprovantes.Domain.Entities;

namespace ProcessadorComprovantes.Application.Interfaces
{
    public interface IComprovanteRepository
    {
        Task<Comprovante> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<IEnumerable<Comprovante>> GetAllAsync(CancellationToken cancellationToken = default);
        Task AddAsync(Comprovante comprovante, CancellationToken cancellationToken = default);
        Task UpdateAsync(Comprovante comprovante, CancellationToken cancellationToken = default);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
