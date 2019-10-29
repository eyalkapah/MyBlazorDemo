using Microsoft.AspNetCore.Components;
using MyBlazorDemo.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazorDemo.Pages
{
    public class CounterBase : ComponentBase
    {
        [Inject]
        public ICounterService CounterService { get; set; }

        [Parameter]
        public string Title { get; set; } = "Set from code";
    }
}