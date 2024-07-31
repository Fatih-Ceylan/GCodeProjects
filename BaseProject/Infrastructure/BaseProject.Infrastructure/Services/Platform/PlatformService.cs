using Azure.Core;
using BaseProject.Application.Abstractions.Platform;
using BaseProject.Application.Exceptions;
using BaseProject.Persistence.Contexts;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.Infrastructure.Services.Platform
{
    public class PlatformService : IPlatformService
    {
        BaseProjectDbContext _baseProjectDbContext;
        IConfiguration _configuration;

        public PlatformService(BaseProjectDbContext baseProjectDbContext, IConfiguration configuration)
        {
            _baseProjectDbContext = baseProjectDbContext;
            _configuration = configuration;
        }

        private async Task<JObject> ReturnJsonObject(HttpResponseMessage responseMessage)
        {
            string jsonString = await responseMessage.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(jsonString);

            return json;
        }

        public async Task<string> GetDbName(string mainCompanyId)
        {
            string baseUrl = _configuration["Platform:ApiServiceUrl"];

            using (var client = new HttpClient())
            {
                string authUrl = $"{baseUrl}/api/Auth/Login";
                string accessToken;

                var authData = new
                {
                    userNameOrEmail = _configuration["Platform:Authorization:UserNameOrEmail"],
                    password = _configuration["Platform:Authorization:Password"]
                };

                HttpResponseMessage authResponse = await client.PostAsJsonAsync(authUrl, authData);

                if (authResponse.IsSuccessStatusCode)
                {
                    var json = await ReturnJsonObject(authResponse);

                    accessToken = (string)json["token"]["accessToken"];
                }
                else
                {
                    throw new PlatformApiServiceException(authResponse.StatusCode.ToString());
                }

                string companyUrl = $"{baseUrl}/api/Company/GetById/{mainCompanyId}";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                HttpResponseMessage companyResponse = await client.GetAsync(companyUrl);

                if (companyResponse.IsSuccessStatusCode)
                {
                    var json = await ReturnJsonObject(companyResponse);

                    _baseProjectDbContext.DbName = (string)json["baseDbName"];
                    return (string)json["baseDbName"];
                }
                else
                {
                    throw new PlatformApiServiceException(companyResponse.StatusCode.ToString());
                }
            }
        }
    }
}