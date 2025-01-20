using BlazorAccountsApp.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorAccountsApp.BranchService
{
    public class BranchService
    {
        private readonly DbContext _context;
        public BranchService(DbContext context)
        {
            _context = context; 
        }
        public async Task<int> AddBranch(Branch branch)
        {
            if(branch!=null)
          await _context.AddAsync(branch);
          _context.SaveChanges();
            return 1;
        }
    }
}
