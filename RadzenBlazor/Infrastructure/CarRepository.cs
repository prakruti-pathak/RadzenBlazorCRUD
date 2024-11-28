using Microsoft.EntityFrameworkCore;
using RadzenBlazor.Domains;
using RadzenBlazor.Models;

namespace RadzenBlazor.Infrastructure
{
    public class CarRepository: ICarRepository
    {
        public readonly CarDbContext _context;
        public CarRepository(CarDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CarEntity>> GetAllAsync()
        {
            return await _context.Cars.ToListAsync();
        }
        public async Task<CarEntity?> GetByIdAsync(int id)
        {
            return await _context.Cars.FindAsync(id);
        }
        public async Task AddAsync(CarEntity car)
        {
            await _context.Cars.AddAsync(car);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(CarEntity car)
        {
             _context.Cars.Update(car);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car != null)
            {
                _context.Cars.Remove(car);
                await _context.SaveChangesAsync();
            }
        }
        public IEnumerable<Car> GetCars()
        {
            return new List<Car>
            {
                new Car (  "Toyota", "Camry", 2020,80000,"Gosaline","Orange" ),
                new Car ( "Honda", "Civic", 2019,50000,"Gosaline","Orange" ),
                new Car (  "Ford", "Mustang",  2021,70000,"Gosaline","Orange"),
                new Car ( "Chevrolet" ,"Malibu",  2018 ,80000,"Gosaline","Orange"),
                new Car ( "Nissan", "Altima", 2022 ,60000,"Gosaline","Orange"),
                new Car (  "Toyota", "Camry", 2020,80000,"Gosaline","Orange" ),
                new Car ( "Honda", "Civic", 2019,50000,"Gosaline","Orange" ),
                new Car (  "Ford", "Mustang",  2021,70000,"Gosaline","Orange"),
                new Car ( "Chevrolet" ,"Malibu",  2018 ,80000,"Gosaline","Orange"),
                new Car ( "Nissan", "Altima", 2022 ,60000,"Gosaline","Orange"),
                new Car (  "Toyota", "Camry", 2020,80000,"Gosaline","Orange" ),
                new Car ( "Honda", "Civic", 2019,50000,"Gosaline","Orange" ),
                new Car (  "Ford", "Mustang",  2021,70000,"Gosaline","Orange"),
                new Car ( "Chevrolet" ,"Malibu",  2018 ,80000,"Gosaline","Orange"),
                new Car ( "Nissan", "Altima", 2022 ,60000,"Gosaline","Orange"),
                new Car (  "Toyota", "Camry", 2020,80000,"Gosaline","Orange" ),
                new Car ( "Honda", "Civic", 2019,50000,"Gosaline","Orange" ),
                new Car (  "Ford", "Mustang",  2021,70000,"Gosaline","Orange"),
                new Car ( "Chevrolet" ,"Malibu",  2018 ,80000,"Gosaline","Orange"),
                new Car ( "Nissan", "Altima", 2022 ,60000,"Gosaline","Orange"),
            };
        }
    }
}
