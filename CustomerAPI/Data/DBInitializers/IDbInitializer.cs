using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Data.DBInitializers
{
    public interface IDbInitializer
    {
        void Initialize(CustomerAPIContext context);
    }
}
