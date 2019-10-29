using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazorDemo.Data.Interfaces
{
    public interface ICounterService
    {
        int CurrentCount { get; }

        void IncrementCount();
    }
}