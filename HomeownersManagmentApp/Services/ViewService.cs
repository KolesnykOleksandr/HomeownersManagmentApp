using HomeownersManagmentApp.Interfaces;
using HomeownersManagmentApp.Models;

namespace HomeownersManagmentApp.Services
{
    public class ViewService : IViewService
    {
        public async Task CreateView(View view)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteView(Guid viewId)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateView(View view)
        {
            throw new NotImplementedException();
        }

        public async Task<List<View>> GetViews(Guid userId)
        {
            List<View> views = new List<View>()
            {
                new View
                {
                    Id = Guid.NewGuid(),
                    Name = "First",
                    Settings = new List<string> {"Id", "Name", "City", "Address"}
                },
                new View
                {
                    Id = Guid.NewGuid(),
                    Name = "Second",
                    Settings = new List<string> {"Id", "Name", "City", "Region"}
                },
                new View
                {
                    Id = Guid.NewGuid(),
                    Name = "Third",
                    Settings = new List<string> {"Id", "Name"}
                },
                new View
                {
                    Id = Guid.NewGuid(),
                    Name = "Fourth",
                    Settings = new List<string> {"Id", "Name", "City", "Region", "Address"}
                }
            };
            return views;
        }
    }
}
