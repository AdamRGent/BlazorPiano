using Microsoft.EntityFrameworkCore;

namespace BlazorPiano.Server.Services.DetailsServices
{
    public class DetailsServices : IDetailsServices
    {
        private readonly DataContext _context;

        public DetailsServices(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<Details>>> GetDetails()
        {
            var details = await _context.Details1.ToListAsync();
            return new ServiceResponse<List<Details>>
            {
                Data = details
            };
        }
    }
}
