using Inventory.API.Models;

namespace Inventory.API.Repository
{
    public interface ICarRepository
    {
        /// <summary>
        /// Get all the cars 
        /// </summary>
        /// <returns></returns>
        Task<List<Car>> GetCars();
        /// <summary>
        /// Get the car details with given car id
        /// </summary>
        /// <param name="carId"></param>
        /// <returns></returns>
        Task<Car> GetCarById(int carId);
        /// <summary>
        /// Add new car
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        Task SaveCar(Car car);
        /// <summary>
        /// Update existing car details
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        Task UpdateCar(int carId,Car car);
        /// <summary>
        /// Delete car with given card id
        /// </summary>
        /// <param name="carId"></param>
        /// <returns></returns>
        Task DeleteCar(int carId);

        bool CarExists(int id);


    }
}
