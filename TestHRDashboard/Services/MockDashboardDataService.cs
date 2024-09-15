using HRDashboard.Models.DashboardData;

namespace HRDashboard.DashboardData
{
    public class MockDashboardDataService : IDashboardDataService
    {
        public Task<List<NewTeamMembersListType>> GetNewTeamMembersListList()
        {
            return Task.FromResult<List<NewTeamMembersListType>>(new());
        }

        public Task<List<TeamMembersGridType>> GetTeamMembersGridList()
        {
            return Task.FromResult<List<TeamMembersGridType>>(new());
        }

        public Task<List<TeamGrowthType>> GetTeamGrowthList()
        {
            return Task.FromResult<List<TeamGrowthType>>(new());
        }

        public Task<List<AllTeamMembersType>> GetAllTeamMembersList()
        {
            return Task.FromResult<List<AllTeamMembersType>>(new());
        }
    }
}
