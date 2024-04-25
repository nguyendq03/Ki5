using AutomoblieLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomoblieLibrary.Respository
{
    public interface ICarRespository
    {
        IEnumerable<Car> GetCars();
        Car GetCarByID(int CarID);
        void InsertCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(int CarID);
    }
}
