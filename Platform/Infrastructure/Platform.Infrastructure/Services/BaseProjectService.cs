using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using Platform.Application.Abstractions.Services;
using Platform.Application.DTOs.Identity.AppUser;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Platform.Infrastructure.Services
{
    public class BaseProjectService : IBaseProjectService
    {
        IConfiguration _configuration;

        public BaseProjectService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<string> AddUser(CreateUserRequestDTO user, string accessToken, string routeName)
        {

            using (var client = new HttpClient())
            {
                var baseProjectDeployedUrl = _configuration["BaseProject:DeployedUrl"];
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                client.DefaultRequestHeaders.Add("Route-Name", routeName);

                string createUserUrl = $"{baseProjectDeployedUrl}User/Create";

                HttpResponseMessage userCreateResponse = await client.PostAsJsonAsync(createUserUrl, user);

                if (userCreateResponse.IsSuccessStatusCode)
                {
                    return "user added success";
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        public async Task<string> SoftDeleteAllUsers(string accessToken, string routeName)
        {
            using (var client = new HttpClient())
            {
                var baseProjectDeployedUrl = _configuration["BaseProject:DeployedUrl"];
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                client.DefaultRequestHeaders.Add("Route-Name", routeName);

                string getAllUserUrl = $"{baseProjectDeployedUrl}User/GetAll";

                HttpResponseMessage getAllUserResponse = await client.GetAsync(getAllUserUrl);

                if (getAllUserResponse.IsSuccessStatusCode)
                {
                    string usersJson = await getAllUserResponse.Content.ReadAsStringAsync();
                    JObject json = JObject.Parse(usersJson);
                    JArray usersArray = (JArray)json["users"];
                    List<string> userIds = new();

                    foreach (var user in usersArray)
                    {
                        string userId = (string)user["id"];
                        userIds.Add(userId);
                    }

                    string deleteUserUrl = $"{baseProjectDeployedUrl}User/Delete";

                    HttpResponseMessage deleteUserResponse = new();

                    foreach (var item in userIds)
                    {
                        deleteUserResponse = await client.DeleteAsync($"{deleteUserUrl}/{item}");

                        if (!deleteUserResponse.IsSuccessStatusCode)
                        {
                            throw new Exception();
                        }
                    }

                    return "Users deleted success";
                }
                else
                {
                    throw new Exception();
                }
            }
        }
    }
}