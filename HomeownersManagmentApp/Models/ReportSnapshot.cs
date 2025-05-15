using System.Diagnostics.CodeAnalysis;
using System.Dynamic;

namespace HomeownersManagmentApp.Models
{
    public class ReportSnapshot
    {
        public List<ReportItem> reportItems {  get; set; } = new ();

        public List<ExpandoObject> Report()
        {
            List<ExpandoObject> result = new();

            foreach (ReportItem item in reportItems)
            {
                var obj = new ExpandoObject() as IDictionary<string, object>;

                foreach (var property in item.reportProperties)
                {
                    obj[property.name] = property.value;
                }

                result.Add((ExpandoObject)obj);
            }

            return result;
        }

    }

    public class ReportItem
    {
        public List<ReportProperty> reportProperties { get; set; } = new ();
    }

    public class ReportProperty
    {
        public string name { get; set; }
        public object value { get; set; }
    }
}
