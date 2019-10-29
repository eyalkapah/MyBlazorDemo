using MyBlazorDemo.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazorDemo.Data
{
    public class CounterService : ICounterService
    {
        public int CurrentCount { get; private set; }

        public void IncrementCount()
        {
            CurrentCount++;
        }
    }
}