using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.UI.WebControls;

namespace MockExam3
{   
    [DataContract]
    public class Cars
    {
        [DataMember]
        public int CarId { get; set; }
        [DataMember]
        public string Brand { get; set; }
        [DataMember]
        public int Year { get; set; }
        [DataMember]
        public string Price { get; set; }
    }

    //public partial class CarsSingleton
    //{
    //    public static CarsSingleton _instance = new CarsSingleton();

    //    public CarsSingleton() { }

    //    public static CarsSingleton Instance
    //    {
    //        get { return _instance;}
    //    }

    //    public List<Cars> CarList
    //    {
    //        get { return carSingleton; }
    //    }
    //    public List<Cars> carSingleton = new List<Cars>()
    //    {
    //        new Cars() {CarId  = 123, Brand = "Ford", Year = 1989, Price = "20.000 Kr."},
    //        new Cars() {CarId = 234, Brand = "Volvo", Year = 2000, Price = "40.000 Kr."},
    //        new Cars () {CarId = 345, Brand = "BMW", Year = 1999, Price = "60.000 Kr." }
    //    };

    //    public List<Cars> GetAllCars()
    //    {
    //        return carSingleton;
    //    }

    //    public GetCarById(int id)
    //    {
    //        return carSingleton.Find(c => c.CarId == id);
    //    }
    //}
}