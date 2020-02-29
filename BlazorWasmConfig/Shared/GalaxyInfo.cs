using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorWasmConfig.Shared
{
    public class GalaxyInfo
    {
        public string GalaxyCluster { get; set; }
        public string GalaxyName { get; set; }
        public long StarCount { get; set; }

        public override string ToString()
        {
            return $"Galaxy: {GalaxyName}, Cluster: {GalaxyCluster}, Stars: {StarCount}";
        }
    }
}
