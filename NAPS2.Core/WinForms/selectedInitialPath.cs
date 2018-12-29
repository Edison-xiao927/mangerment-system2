namespace NAPS2.WinForms
{
    public interface IInterface<T> where T : class 
    {
        string Name { get; set; }
    }
}