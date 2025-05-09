namespace HomeownersManagmentApp.Models
{
    public class View
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "";
        public List<string> Settings { get; set; } = new List<string>();

        public View() { }

        public View(View view)
        {
            Id = view.Id;
            Name = view.Name;
            Settings = view.Settings;
        }
    }
}
