using Inventory.API.Helpers;
using Inventory.API.Models;
using Inventory.API.Repository;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace Inventory.API.Service
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository) { 
            _carRepository = carRepository;        
        }
        public async Task DeleteCar(int carId)
        {
            if(!CarExist(carId))
            {
                throw new AppException((int)CarError.CarNotExists, "Car Not Found");
            }
            await _carRepository.DeleteCar(carId);
        }

        public async Task<Car> GetCarById(int carId)
        {
            if (!CarExist(carId))
            {
                throw new AppException((int)CarError.CarNotExists, "Car Not Found");
            }
            return await _carRepository.GetCarById(carId);
        }

        public async Task<List<Car>> GetCars()
        {
            return await _carRepository.GetCars();
        }

        public async Task SaveCar(Car car)
        {
            Validation(car);
            await _carRepository.SaveCar(car);
        }

        private void Validation(Car car)
        {
            if(string.IsNullOrEmpty(car.Year))
            {
                throw new AppException((int)CarError.CarYearCannotBeNullOrEmpty, "Car year cannot be null or empty");
            }
            if(string.IsNullOrEmpty(car.Make))
            {
                throw new AppException((int)CarError.CarMakeCannotBeNullOrEmpty, "Car make cannot be null or empty");
            }
            if (string.IsNullOrEmpty(car.Model))
            {
                throw new AppException((int)CarError.CarYearCannotBeNullOrEmpty, "Car Model cannot be null or empty");
            }
            if (car.PurchasedAmount==0)
            {
                throw new AppException((int)CarError.CarMakeCannotBeNullOrEmpty, "Car purchase amount cannot be zero");
            }
          
        }

        private bool CarExist(int carId)
        {
           return  _carRepository.CarExists(carId);
        }

        public async Task UpdateCar(int carId, Car car)
        {
            if(!CarExist(carId))
            {
                throw new AppException((int)CarError.CarNotExists, "Car Not Found");
            }
            Validation(car);
            await _carRepository.UpdateCar(carId,car);
        }
    }
}
