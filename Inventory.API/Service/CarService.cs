using Inventory.API.Models;
using Inventory.API.Repository;

namespace Inventory.API.Service
{
    public class CarService:ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository) {

            _carRepository = carRepository;
        }

        public int DeleteCar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public Car GetCarById(int id)
        {
            throw new NotImplementedException();
        }

        public Car SaveCar(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
