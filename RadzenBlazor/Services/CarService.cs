using RadzenBlazor.Domains;
using RadzenBlazor.Infrastructure;
using RadzenBlazor.Models;

namespace RadzenBlazor.Services
{
    public class CarService: ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public async Task<IEnumerable<CarEntity>> GetAllAsync()
        {
            return await _carRepository.GetAllAsync();
        }
        public  IEnumerable<Car> GetCars()
        {
            return  _carRepository.GetCars();
        }
        public async Task<CarEntity> GetByIdAsync(int id)
        {
            return await _carRepository.GetByIdAsync(id);
        }
        public async Task UpdateCarAsync(CarEntity car)
        {
            await _carRepository.UpdateAsync(car);
        }
        public async Task AddCarAsync(CarEntity car)
        {
            await _carRepository.AddAsync(car);
        }
        public async Task DeleteCarAsync(int id)
        {
            await _carRepository.DeleteAsync(id);
        }
    }
}
