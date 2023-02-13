using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.SqlServer;

namespace DAL.Entities.Partials
{
    public partial class ParkingContext
    {
        private static SqlProviderServices instance = SqlProviderServices.Instance;
    }
}
