using MyBlazorDemo.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazorDemo.ViewModels
{
    public class CounterViewModel
    {
        public ICounterService CounterService { get; set; }

        public string Title { get; set; } = "Set from code";

        public CounterViewModel(ICounterService counterService)
        {
            CounterService = counterService;
        }
    }
}