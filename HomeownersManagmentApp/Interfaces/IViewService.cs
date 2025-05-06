using HomeownersManagmentApp.Models;

namespace HomeownersManagmentApp.Interfaces
{
    public interface IViewService
    {
        public Task CreateView(View view);
        public Task UpdateView(View view);
        public Task DeleteView(Guid viewId);
        public Task<List<View>> GetViews(Guid userId);

    }
}
