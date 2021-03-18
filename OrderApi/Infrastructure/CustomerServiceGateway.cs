using OrderApi.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApi.Infrastructure
{
    public class CustomerServiceGateway : IServiceGateway<CustomerDTO>
    {
        Uri customerServiceBaseUrl;

        public CustomerServiceGateway(Uri baseUrl)
        {
            customerServiceBaseUrl = baseUrl;
        }

        public CustomerDTO Get(int id)
        {
            RestClient c = new RestClient();
            c.BaseUrl = customerServiceBaseUrl;

            var request = new RestRequest(id.ToString(), Method.GET);
            var response = c.Execute<CustomerDTO>(request);
            var customerData = response.Data;
            return customerData;
        }
    }
}
