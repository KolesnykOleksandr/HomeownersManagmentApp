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

        public async Task<ReportSnapshot> GetSnapshot()
        {
            ReportSnapshot snapshot = new();

            snapshot.reportItems.AddRange(new[]
            {
                new ReportItem()
                {
                    reportProperties = new List<ReportProperty>
                    {
                        new ReportProperty { name = "Id", value = 1 },
                        new ReportProperty { name = "Address", value = "вул. Центральна, 10" },
                        new ReportProperty { name = "City", value = "Київ" },
                        new ReportProperty { name = "Name", value = "Котедж 'Сонячний'" },
                        new ReportProperty { name = "Region", value = "Київська область" }
                    }
                },
                new ReportItem()
                {
                    reportProperties = new List<ReportProperty>
                    {
                        new ReportProperty { name = "Id", value = 2 },
                        new ReportProperty { name = "Address", value = "вул. Хрещатик, 25" },
                        new ReportProperty { name = "City", value = "Київ" },
                        new ReportProperty { name = "Name", value = "Бізнес-центр 'Престиж'" },
                        new ReportProperty { name = "Region", value = "Київська область" }
                    }
                },
                new ReportItem()
                {
                    reportProperties = new List<ReportProperty>
                    {
                        new ReportProperty { name = "Id", value = 3 },
                        new ReportProperty { name = "Address", value = "вул. Хрещатик, 25" },
                        new ReportProperty { name = "City", value = "Київ" },
                        new ReportProperty { name = "Name", value = "Бізнес-центр 'Престиж'" },
                        new ReportProperty { name = "Region", value = "Київська область" }
                    }
                },
                new ReportItem()
                {
                    reportProperties = new List<ReportProperty>
                    {
                        new ReportProperty { name = "Id", value = 4 },
                        new ReportProperty { name = "Address", value = "вул. Хрещатик, 25" },
                        new ReportProperty { name = "City", value = "Київ" },
                        new ReportProperty { name = "Name", value = "Бізнес-центр 'Престиж'" },
                        new ReportProperty { name = "Region", value = "Київська область" }
                    }
                },
                new ReportItem()
                {
                    reportProperties = new List<ReportProperty>
                    {
                        new ReportProperty { name = "Id", value = 5 },
                        new ReportProperty { name = "Address", value = "вул. Хрещатик, 25" },
                        new ReportProperty { name = "City", value = "Київ" },
                        new ReportProperty { name = "Name", value = "Бізнес-центр 'Престиж'" },
                        new ReportProperty { name = "Region", value = "Київська область" }
                    }
                },
                new ReportItem()
                {
                    reportProperties = new List<ReportProperty>
                    {
                        new ReportProperty { name = "Id", value = 6 },
                        new ReportProperty { name = "Address", value = "вул. Хрещатик, 25" },
                        new ReportProperty { name = "City", value = "Київ" },
                        new ReportProperty { name = "Name", value = "Бізнес-центр 'Престиж'" },
                        new ReportProperty { name = "Region", value = "Київська область" }
                    }
                },
                new ReportItem()
                {
                    reportProperties = new List<ReportProperty>
                    {
                        new ReportProperty { name = "Id", value = 7 },
                        new ReportProperty { name = "Address", value = "вул. Хрещатик, 25" },
                        new ReportProperty { name = "City", value = "Київ" },
                        new ReportProperty { name = "Name", value = "Бізнес-центр 'Престиж'" },
                        new ReportProperty { name = "Region", value = "Київська область" }
                    }
                },
                new ReportItem()
                {
                    reportProperties = new List<ReportProperty>
                    {
                        new ReportProperty { name = "Id", value = 8 },
                        new ReportProperty { name = "Address", value = "вул. Хрещатик, 25" },
                        new ReportProperty { name = "City", value = "Київ" },
                        new ReportProperty { name = "Name", value = "Бізнес-центр 'Престиж'" },
                        new ReportProperty { name = "Region", value = "Київська область" }
                    }
                },
                new ReportItem()
                {
                    reportProperties = new List<ReportProperty>
                    {
                        new ReportProperty { name = "Id", value = 9 },
                        new ReportProperty { name = "Address", value = "вул. Хрещатик, 25" },
                        new ReportProperty { name = "City", value = "Київ" },
                        new ReportProperty { name = "Name", value = "Бізнес-центр 'Престиж'" },
                        new ReportProperty { name = "Region", value = "Київська область" }
                    }
                },
                new ReportItem()
                {
                    reportProperties = new List<ReportProperty>
                    {
                        new ReportProperty { name = "Id", value = 10 },
                        new ReportProperty { name = "Address", value = "вул. Хрещатик, 25" },
                        new ReportProperty { name = "City", value = "Київ" },
                        new ReportProperty { name = "Name", value = "Бізнес-центр 'Престиж'" },
                        new ReportProperty { name = "Region", value = "Київська область" }
                    }
                },
                new ReportItem()
                {
                    reportProperties = new List<ReportProperty>
                    {
                        new ReportProperty { name = "Id", value = 11 },
                        new ReportProperty { name = "Address", value = "вул. Хрещатик, 25" },
                        new ReportProperty { name = "City", value = "Київ" },
                        new ReportProperty { name = "Name", value = "Бізнес-центр 'Престиж'" },
                        new ReportProperty { name = "Region", value = "Київська область" }
                    }
                },
                new ReportItem()
                {
                    reportProperties = new List<ReportProperty>
                    {
                        new ReportProperty { name = "Id", value = 12 },
                        new ReportProperty { name = "Address", value = "вул. Хрещатик, 25" },
                        new ReportProperty { name = "City", value = "Київ" },
                        new ReportProperty { name = "Name", value = "Бізнес-центр 'Престиж'" },
                        new ReportProperty { name = "Region", value = "Київська область" }
                    }
                },
                new ReportItem()
                {
                    reportProperties = new List<ReportProperty>
                    {
                        new ReportProperty { name = "Id", value = 15 },
                        new ReportProperty { name = "Address", value = "вул. Набережна Перемоги, 25" },
                        new ReportProperty { name = "City", value = "Дніпро" },
                        new ReportProperty { name = "Name", value = "Апартаменти з видом на Дніпро" },
                        new ReportProperty { name = "Region", value = "Дніпропетровська область" }
                    }
                }
            });
            return snapshot;
        }
    }
}