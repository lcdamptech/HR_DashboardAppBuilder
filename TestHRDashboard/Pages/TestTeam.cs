using Bunit;
using Microsoft.Extensions.DependencyInjection;
using HRDashboard.Pages;
using HRDashboard.DashboardData;

namespace TestHRDashboard
{
	[Collection("HRDashboard")]
	public class TestTeam
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCardModule));
			ctx.Services.AddScoped<IDashboardDataService>(sp => new MockDashboardDataService());
			var componentUnderTest = ctx.RenderComponent<Team>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
