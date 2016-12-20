using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;

namespace MockExam3
{
    public class CarsRepository
    {

        private int counter = 1;
         
        public List<Cars> carList = new List<Cars>()
        {
            new Cars() {CarId  = 123, Brand = "Ford", Year = 1989, Price = "20.000 Kr."},
            new Cars() {CarId = 234, Brand = "Volvo", Year = 2000, Price = "40.000 Kr."},
            new Cars () {CarId = 345, Brand = "BMW", Year = 1999, Price = "60.000 Kr." }
        };

        public List<Cars> GetAllCars()
        {
            return carList;
        }

        public Cars GetCarById(int id)
        {
            return carList.Find(c => c.CarId == id);
        }

        public Cars AddNewCar(Cars item)
        {
            if (item == null)
                throw new ArgumentException("item");
            item.CarId = counter++;
            carList.Add(item);
            return item;
        }

        public bool DeleteCar(int id)
        {
            int idx = carList.FindIndex(c => c.CarId == id);
            if (idx == -1)
                return false;
            carList.RemoveAll(c => c.CarId == id);
            return true;
        }

        public bool UpdateABook(Cars item)
        {
            if (item == null)
                throw new ArgumentNullException("item");
            int idx = carList.FindIndex(c => c.CarId == item.CarId);
            if (idx == -1)
                return false; carList.RemoveAt(idx);
            carList.Add(item);
            return true;
        }

       
    }
}