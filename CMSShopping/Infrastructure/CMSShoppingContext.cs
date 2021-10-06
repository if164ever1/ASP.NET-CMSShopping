using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSShopping.Infrastructure
{
    public class CMSShoppingContext : DbContext
    {
        public CMSShoppingContext(DbContextOptions<CMSShoppingContext> options)
            :base(options)
        {
        }


    }
}
