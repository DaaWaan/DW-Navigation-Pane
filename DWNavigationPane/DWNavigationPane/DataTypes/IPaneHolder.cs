namespace DWNavigationPane
{
    public interface IPaneElementHolder : IPaneItem
    {
        IPaneElement PaneElement { get; }
    }
}