using System.Threading.Tasks;
using RestSharp;

namespace MessageBoardClient.Models
{
    public class ApiHelper
    {
        public static async Task<string> GetAllGroups()
        {
            RestClient client = new RestClient("http://localhost:5000/");
            RestRequest request = new RestRequest($"api/groups", Method.Get);
            RestResponse response = await client.GetAsync(request);
            return response.Content;
        }

        public static async Task<string> GetAllMessages()
        {
            RestClient client = new RestClient("http://localhost:5000/");
            RestRequest request = new RestRequest($"api/messages", Method.Get);
            RestResponse response = await client.GetAsync(request);
            return response.Content;
        }

        public static async Task<string> GetGroupID(int id)
        {
            RestClient client = new RestClient("http://localhost:5000/");
            RestRequest request = new RestRequest($"api/groups/{id}", Method.Get);
            RestResponse response = await client.GetAsync(request);
            return response.Content;
        }
    }
}