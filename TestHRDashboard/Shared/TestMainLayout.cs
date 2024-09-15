using Bunit;
using Microsoft.Extensions.DependencyInjection;
using HRDashboard.Shared;
using HRDashboard.DashboardData;

namespace TestHRDashboard
{
	[Collection("HRDashboard")]
	public class TestMainLayout
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbListModule),
				typeof(IgbAvatarModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbIconButtonModule),
				typeof(IgbCardModule),
				typeof(IgbCheckboxModule),
				typeof(IgbSwitchModule));
			ctx.Services.AddScoped<IDashboardDataService>(sp => new MockDashboardDataService());
			var componentUnderTest = ctx.RenderComponent<MainLayout>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
