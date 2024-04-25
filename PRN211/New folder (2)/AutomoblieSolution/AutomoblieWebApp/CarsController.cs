using AutomoblieLibrary.DataAccess;
using AutomoblieLibrary.Respository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomoblieWebApp
{
    public class CarsController : Controller
    {
        ICarRespository carRespository = null;
        public CarsController() => carRespository = new CarRespository();   
        // GET: CarsController
        public ActionResult Index()
        {
            var carList = carRespository.GetCars();
            return View(carList);
        }

        // GET: CarsController/Details/5
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var car = carRespository.GetCarByID(id.Value);
            if(car == null)
            {
                return NotFound();
            }
            return View(car);
        }

        // GET: CarsController/Create
        public ActionResult Create() => View();

        // POST: CarsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Car car)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    carRespository.InsertCar(car);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(car);
            }
        }

        // GET: CarsController/Edit/5
        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var car = carRespository.GetCarByID(id.Value);
            if(car == null)
            {
                return NotFound() ;
            }
            return View(car);
        }

        // POST: CarsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Car car)
        {
            try
            {
                if(id != car.CarId)
                {
                    return NotFound();
                }
                if(ModelState.IsValid)
                {
                    carRespository.UpdateCar(car);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        // GET: CarsController/Delete/5
        public ActionResult Delete(int? id)
        {
            if(id == null) { return NotFound(); }
            var car = carRespository.GetCarByID(id.Value);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }

        // POST: CarsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                carRespository.DeleteCar(id);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
