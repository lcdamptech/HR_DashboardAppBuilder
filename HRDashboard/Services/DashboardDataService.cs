using System.Net.Http.Json;
using HRDashboard.Models.DashboardData;

namespace HRDashboard.DashboardData
{
    public class DashboardDataService: IDashboardDataService
    {
        private readonly HttpClient _http;

        public DashboardDataService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<NewTeamMembersListType>> GetNewTeamMembersListList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/6371c465-f63a-4dd9-436e-08da496bf5f2", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<NewTeamMembersListType>>().ConfigureAwait(false);
            }

            return new List<NewTeamMembersListType>();
        }

        public async Task<List<TeamMembersGridType>> GetTeamMembersGridList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/d2d94130-e6aa-4387-437e-08da496bf5f2", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<TeamMembersGridType>>().ConfigureAwait(false);
            }

            return new List<TeamMembersGridType>();
        }

        public async Task<List<TeamGrowthType>> GetTeamGrowthList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/9d362c81-e18a-4fff-4355-08da496bf5f2", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<TeamGrowthType>>().ConfigureAwait(false);
            }

            return new List<TeamGrowthType>();
        }

        public async Task<List<AllTeamMembersType>> GetAllTeamMembersList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/d2d94130-e6aa-4387-437e-08da496bf5f2", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<AllTeamMembersType>>().ConfigureAwait(false);
            }

            return new List<AllTeamMembersType>();
        }
    }
}
