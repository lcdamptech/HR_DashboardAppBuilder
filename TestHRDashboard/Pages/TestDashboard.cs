using Bunit;
using Microsoft.Extensions.DependencyInjection;
using HRDashboard.Pages;
using HRDashboard.DashboardData;

namespace TestHRDashboard
{
	[Collection("HRDashboard")]
	public class TestDashboard
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCardModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbIconButtonModule),
				typeof(IgbGridModule),
				typeof(IgbCategoryChartModule));
			ctx.Services.AddScoped<IDashboardDataService>(sp => new MockDashboardDataService());
			var componentUnderTest = ctx.RenderComponent<Dashboard>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
