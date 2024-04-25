using AutomoblieLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomoblieLibrary.Respository
{
    public class CarRespository : ICarRespository
    {
        public IEnumerable<Car> GetCars() => CarDAO.Instance.GetCarList();
        public Car GetCarByID(int CarID) => CarDAO.Instance.GetCarByID(CarID);
        public void InsertCar(Car car) => CarDAO.Instance.AddNew(car);
        public void UpdateCar(Car car) => CarDAO.Instance.Update(car);
        public void DeleteCar(int CarID) => CarDAO.Instance.Remove(CarID);
    }
}
