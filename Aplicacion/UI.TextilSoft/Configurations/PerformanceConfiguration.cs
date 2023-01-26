using AutoMapper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.TextilSoft.Configurations
{
    public static class PerformanceConfiguration
    {      
        public static bool EnabledAnimator { get => Convert.ToBoolean(Program.Configuration["Application:Performance:EnabledAnimator"]); }
        public static bool EnabledSliceButtonsPanel { get => Convert.ToBoolean(Program.Configuration["Application:Performance:EnabledSliceButtonsPanel"]); }     
    }
}
