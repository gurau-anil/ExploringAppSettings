namespace ExploringAppSettings.Options
{
    public class PrintSetting
    {
        public bool EnablePrintOption { get; set; }
        public int DefaultPrintSize { get; set; }
        public int TimeOutSeconds { get; set; }
        public PrintProvider PrintProvider { get; set; }
    }
    public class PrintProvider
    {
        public string Name { get; set; } 
    }
}
