using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MockExam3
{
    interface ICarRepository
    {
        List<Cars> GetAllCars();
        Cars GetCarsById(int id);
        Cars AddNewCar(Cars item);
        bool DeleteCars(int id);
        bool UpdateACar(Cars item);
    }
}