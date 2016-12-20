using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MockExam3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CarsRESTService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CarsRESTService.svc or CarsRESTService.svc.cs at the Solution Explorer and start debugging.
    public class CarsRESTService : ICarsRESTService
    {
        static CarsRepository service = new CarsRepository();


        public string CreateCar(string id, Cars car)
        {
            Cars newcar = service.AddNewCar(car);
            return "id = " + newcar.CarId;
        }

        public List<Cars> GetCarsList()
        {
            return service.GetAllCars();
        }

        public Cars GetCarsById(string id)
        {
            return service.GetCarById(Int32.Parse(id));
        }


        public string UpdateCar(string id, Cars car)
        {
            bool updated = service.UpdateABook(car);
            if (updated)
                return "Car with id = " + id + "Updated successfully";
            else
                return "unable to update book with id: + " + id;


        }

        public string DeleteCars(string id, Cars car)
        {
            bool deleted = service.DeleteCar(Int32.Parse(id));
            if (deleted)
                return "Book with id = " + id + "Deleted successfully";
            else
                return "Unable to delete book with id: + " + id;

        }
    }
}
