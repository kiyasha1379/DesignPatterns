namespace DesignePatterns.Behavioral.Template
{
    // Base class
    public abstract class ReportGenerator
    {
        public void GenerateReport()
        {
            ReadData();
            ProcessData();
            PrintReport();
        }

        protected abstract void ReadData();
        protected abstract void ProcessData();
        protected abstract void PrintReport();
    }
    public class DatabaseReport : ReportGenerator
    {
        protected override void ReadData() => Console.WriteLine("Reading data from Database...");
        protected override void ProcessData() => Console.WriteLine("Processing DB data...");
        protected override void PrintReport() => Console.WriteLine("Printing Database Report.");
    }
    public class FileReport : ReportGenerator
    {
        protected override void ReadData() => Console.WriteLine("Reading data from File...");
        protected override void ProcessData() => Console.WriteLine("Processing File data...");
        protected override void PrintReport() => Console.WriteLine("Printing File Report.");
    }
}
