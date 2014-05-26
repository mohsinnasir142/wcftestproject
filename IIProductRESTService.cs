using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using System.IO;



namespace Communicator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IIProductRESTService" in both code and config file together.
    [ServiceContract]
    public interface IIProductRESTService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
                  BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "GetProductList/")]
        List<Product> GetProductList();

      

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "getAllCustomers")]
        List<info> GetAllCustomers();
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "selectAll")]
        List<info> selectAll();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "selectAllbyName/{name}")]
        List<info> selectAllbyName(string name);


        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "updateOrderAddress")]
        int UpdateOrderAddress(Stream JSONdataStream);
  
    }
}
