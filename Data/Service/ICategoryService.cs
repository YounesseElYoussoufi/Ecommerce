using Ecomproject.Data.Base;
using Ecomproject.Models;
using Ecomproject.Data.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



using Ecomproject.Data.Base;
namespace Ecomproject.Data.Service
{
    public interface ICategoryService : IEntityBaseRepository<Category>
    {
    }
}
