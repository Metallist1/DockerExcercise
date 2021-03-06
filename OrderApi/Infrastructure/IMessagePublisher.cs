using System.Collections.Generic;
using OrderApi.Model;

namespace OrderApi.Infrastructure
{
    public interface IMessagePublisher
    {
        void PublishOrderStatusChangedMessage(int customerId,
            IList<OrderLine> orderLines, string topic);
        void PublishCustomerStatusChangedMessage(int customerId,
           decimal totalPrice, string topic);
    }
}
