using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using MyBlazorDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazorDemo.Pages
{
    public class FetchDataBase : ComponentBase

    {
        public WeatherForecast[] Forecasts;

        [Inject]
        public WeatherForecastService ForecastService { get; set; }

        [Parameter]
        public int Id { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string Title { get; set; } = "Default Title";

        public void Dispose()
        {
            NavigationManager.LocationChanged -= OnLocationChanges;
        }

        public void Navigate()
        {
            NavigationManager.NavigateTo("/fetchdata/Brian Lagunas/36");
        }

        protected override async Task OnInitializedAsync()
        {
            Forecasts = await ForecastService.GetForecastAsync(DateTime.Now);

            Refresh();

            //NavigationManager.LocationChanged += OnLocationChanges;
        }

        private void OnLocationChanges(object sender, LocationChangedEventArgs e) => Refresh();

        private void Refresh()
        {
            var uri = NavigationManager.ToAbsoluteUri(NavigationManager.Uri);
            var name = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(uri.Query).TryGetValue("name", out var title);

            Title = title;
            //StateHasChanged();
        }
    }
}