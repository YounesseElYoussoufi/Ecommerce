using Ecomproject.Data.Base;
using Ecomproject.Models;
using Ecomproject.Data.Base;

namespace Ecomproject.Data.Service
{
    public class CategoryService : EntityBaseRepository<Category>, ICategoryService
    {
        private readonly AppDbContext _context;

        public CategoryService(AppDbContext context) : base(context)
        {
        }
    }
}
