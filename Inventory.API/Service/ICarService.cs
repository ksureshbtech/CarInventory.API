using Inventory.API.Models;

namespace Inventory.API.Service
{
    public interface ICarService
    {
        /// <summary>
        /// Get all the car
        /// </summary>
        /// <returns></returns>
        List<Car> GetAll();
        /// <summary>
        /// Get the car with given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Car GetCarById(int id);
        /// <summary>
        /// Create new car
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        Car SaveCar(Car car);
        /// <summary>
        /// Delete the car 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteCar(int id);
    }
}
