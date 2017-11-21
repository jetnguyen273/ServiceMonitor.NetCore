﻿using System;

namespace ServiceMonitor.API.ViewModels
{
    public class ServiceStatusVm
    {
        public Int32? ServiceStatusID { get; set; }

        public Int32? ServiceID { get; set; }

        public Boolean? Success { get; set; }

        public Int32? WatchCount { get; set; }

        public DateTime? LastWatch { get; set; }
    }
}
