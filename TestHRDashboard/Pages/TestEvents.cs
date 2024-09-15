using Bunit;
using Microsoft.Extensions.DependencyInjection;
using HRDashboard.Pages;

namespace TestHRDashboard
{
	[Collection("HRDashboard")]
	public class TestEvents
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Events>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
