﻿using Microsoft.Extensions.Configuration;

namespace GHR.Persistence
{
    public static class Configuration
    {
        static public List<(string server, string database, string userId, string password)> GHRConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();

                try
                {
                    configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "..\\GHR.Api"));
                }
                catch (Exception)
                {
                    configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory()));
                }
                var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

                configurationManager.AddJsonFile(environmentName == "Development" ? "appsettings.json" : $"appsettings.{environmentName}.json");

                List<(string server, string database, string userId, string password)> connectionDatas = new();

    

                return connectionDatas;
            }
        }
    }
}
