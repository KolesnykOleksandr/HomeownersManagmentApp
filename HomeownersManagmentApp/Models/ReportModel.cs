namespace HomeownersManagmentApp.Models
{
    public class ReportModel
    {
        public int ReportId { get; set; }
        public string ReportName { get; set; }
        public List<Column> Columns { get; set; }

        public List<string> ColumnsString
        {
            get
            {
                List<string> list = new List<string>();

                foreach (var column in Columns)
                {
                    list.Add(column.name);
                }

                return list;
            }
        }
    }

    public class Column
    {
        public string name { get; set; }
        public string header { get; set; }
        public string type { get; set; }
        public string align { get; set; }
        public string format { get; set; }
        public bool isGroupBy { get; set; }
        public string Group { get; set; }
    }
}
