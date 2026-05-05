namespace HomeDesigner.Adapter
{
    public interface IProjectLogger
    {
        void LogProject(string description, double originalPrice, double finalPrice);
    }
}