using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamGamePanelLibrary
{
    public class SteamWebRequest
    {
        public static string SteamCommunityURL { get; set; } = "https://steamcommunity.com/";

        // TODO - Check if inventory is private.
        public static string? GetUserInventory(SteamUserModel _account)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri($"{SteamCommunityURL}/inventory/{_account.SteamID}/730/2?l=english&count=5000");
            HttpResponseMessage httpResponseMessage = client.Send(new HttpRequestMessage(HttpMethod.Get, client.BaseAddress));

            if (!httpResponseMessage.IsSuccessStatusCode) return null;

            string response = httpResponseMessage.Content.ReadAsStringAsync().Result;
            return response;
        }
    }
}
