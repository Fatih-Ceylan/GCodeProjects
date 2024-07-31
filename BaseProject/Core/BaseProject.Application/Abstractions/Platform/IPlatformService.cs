namespace BaseProject.Application.Abstractions.Platform
{
    public interface IPlatformService
    {
        Task<string> GetDbName(string licenceId);
    }
}