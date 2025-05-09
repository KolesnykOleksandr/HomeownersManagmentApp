namespace HomeownersManagmentApp.Models
{
    public class ReportModel
    {
        public int ReportId { get; set; }
        public string ReportName { get; set; }
        public List<ColumnGroup> ColumnGroups { get; set; }

        public List<string> ColumnsString
        {
            get
            {
                List<string> list = new List<string>();

                foreach (var columnGroup in ColumnGroups)
                {
                    foreach (var column in columnGroup.Columns)
                    {
                        list.Add(column.name);
                    }
                }

                return list;
            }
        }
    }

    public class ColumnGroup
    {
        public string Name { get; set; }
        public List<Column> Columns { get; set; }
    }

    public class Column
    {
        public string name { get; set; }
        public string header { get; set; }
        public string type { get; set; }
        public string align { get; set; }
        public string format { get; set; }
        public bool isGroupBy { get; set; }
    }
}
