using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MockExam3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICarsRESTService" in both code and config file together.
    [ServiceContract]
    public interface ICarsRESTService
    {


        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json,
             ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "GetCarsList")]
        List<Cars> GetCarsList();

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json,
             ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "GetCarsbyId/{id}")]
        Cars GetCarsById(string id);


        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
             ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "AddCars/{id}")]
        string CreateCar(string id, Cars car);

        [OperationContract]
        [WebInvoke(Method = "PUT", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "UpdateCars/{id}")]
        string UpdateCar(string id, Cars car);

        [OperationContract]
        [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "DeleteCars/{id}")]
        string DeleteCars(string id, Cars car);

    }
}
