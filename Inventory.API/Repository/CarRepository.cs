
using Inventory.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Inventory.API.Repository
{
    public class CarRepository : ICarRepository
    { 
        public bool CarExists(int id)
        {
            using (var context = new CarDbContext())
            {
                return context.Cars.Any(e => e.Id == id);
            }
        }

        private double CalculateCurrentValue(Car car)
        {
            string year = DateTime.Parse(DateTime.Now.ToString()).Year.ToString();
            int yearDiff=Convert.ToInt32(year)-Convert.ToInt32(car.Year);
            double depPercentage = yearDiff * 5;
            return (car.PurchasedAmount) - ((car.PurchasedAmount) * (depPercentage / 100));
        }
        public async Task DeleteCar(int carId)
        {
            using (var context = new CarDbContext())
            {
                var carObject = context.Cars.FirstOrDefault(x => x.Id == carId);
                if (carObject != null)
                {
                    context.Cars.Remove(carObject);
                    await context.SaveChangesAsync();
                }
            }
        }

        public async Task<Car> GetCarById(int carId)
        {
            using (var context = new CarDbContext())
            {
                return await context.Cars.SingleOrDefaultAsync(x => x.Id == carId);
            }
        }

        public async Task<List<Car>> GetCars()
        {
            using (var context = new CarDbContext())
            {
                List<Car> list = await context.Cars.ToListAsync();
                return list;
            }
        }

        public async Task SaveCar(Car car)
        {
            car.CurrentValue = CalculateCurrentValue(car);
            using (var context = new CarDbContext())
            {
                context.Cars.Add(car);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateCar(int carId,Car car)
        {
            car.CurrentValue = CalculateCurrentValue(car);
            
            using (var context = new CarDbContext())
            {
                Car upDateEntity = await context.Cars.FirstOrDefaultAsync(x=> x.Id == carId);
                upDateEntity = car;

                context.Entry(upDateEntity).State = EntityState.Modified;
                //context.Update(context.Cars);
                await context.SaveChangesAsync();
            }
        }
    }
}
