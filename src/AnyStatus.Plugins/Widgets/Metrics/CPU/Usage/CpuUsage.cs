﻿using AnyStatus.API;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AnyStatus
{
    [DisplayColumn("Metrics")]
    [DisplayName("CPU Usage")]
    [Description("Shows the percentage of CPU usage")]
    public class CpuUsage : MetricValue, ISchedulable
    {
        public CpuUsage()
        {
            Interval = 1;
        }

        [DisplayName("Machine Name")]
        [Description("Optional. Leave blank for local computer.")]
        public string MachineName { get; set; }
    }
}