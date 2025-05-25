using EmpleadosApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmpleadosApp.Repositories
{
    public interface IEmpleadoRepository
    {
        Task<List<Empleado>> GetAllAsync();
        Task<Empleado> GetByIdAsync(int id);
        Task<Empleado> CreateAsync(Empleado empleado);
        Task UpdateAsync(Empleado empleado);
        Task DeleteAsync(int id);
        Task<int> GetActiveCountAsync();
        Task<int> GetInactiveCountAsync();
    }
}