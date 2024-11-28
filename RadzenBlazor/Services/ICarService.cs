using RadzenBlazor.Domains;
using RadzenBlazor.Models;

namespace RadzenBlazor.Services
{
    public interface ICarService
    {
        Task AddCarAsync(CarEntity car);
        Task DeleteCarAsync(int id);
        Task<IEnumerable<CarEntity>> GetAllAsync();
        Task<CarEntity> GetByIdAsync(int id);
        IEnumerable<Car> GetCars();
        Task UpdateCarAsync(CarEntity car);
    }
}
