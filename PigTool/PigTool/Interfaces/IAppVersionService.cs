namespace PigTool.Interfaces
{
    public interface IAppVersionService
    {
        string GetVersionNumber();

        public int GetVersionCode();
    }
}
