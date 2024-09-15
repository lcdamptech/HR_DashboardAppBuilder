using HRDashboard.Models.DashboardData;

namespace HRDashboard.DashboardData
{
    public interface IDashboardDataService
    {
        Task<List<NewTeamMembersListType>> GetNewTeamMembersListList();
        Task<List<TeamMembersGridType>> GetTeamMembersGridList();
        Task<List<TeamGrowthType>> GetTeamGrowthList();
        Task<List<AllTeamMembersType>> GetAllTeamMembersList();
    }
}
