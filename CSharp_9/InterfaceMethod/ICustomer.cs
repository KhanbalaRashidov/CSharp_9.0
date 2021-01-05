using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMethod
{
    public interface ICustomer
    {
        IEnumerable<IOrder> PreviousOrders { get; }

        DateTime DateJoined { get; }
        DateTime? LastOrder { get; }
        string Name { get; }
        IDictionary<DateTime, string> Reminders { get; }
        public decimal ComputeLoyaltyDiscount()
        {
            DateTime TwoYearsAgo = DateTime.Now.AddYears(-2);
            if(DateJoined<TwoYearsAgo && PreviousOrders.Count() > 10)
            {
                return 0.10m;
            }
            return 0;
        }
    }
    public interface IOrder
    {
        DateTime Purchased { get; }
        decimal Cost { get; }
    }
}
