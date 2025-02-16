// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> VmMemory Data. </summary>
    public partial class DataBoxEdgeVmMemory
    {
        /// <summary> Initializes a new instance of DataBoxEdgeVmMemory. </summary>
        public DataBoxEdgeVmMemory()
        {
        }

        /// <summary> Initializes a new instance of DataBoxEdgeVmMemory. </summary>
        /// <param name="startupMemoryInMB"> The total amount of RAM in the virtual machine, as seen by the guest  operating system. For a virtual machine with dynamic memory enabled, this represents the initial memory available at startup. </param>
        /// <param name="currentMemoryUsageInMB"> The current memory used by the virtual machine. </param>
        internal DataBoxEdgeVmMemory(long? startupMemoryInMB, long? currentMemoryUsageInMB)
        {
            StartupMemoryInMB = startupMemoryInMB;
            CurrentMemoryUsageInMB = currentMemoryUsageInMB;
        }

        /// <summary> The total amount of RAM in the virtual machine, as seen by the guest  operating system. For a virtual machine with dynamic memory enabled, this represents the initial memory available at startup. </summary>
        public long? StartupMemoryInMB { get; set; }
        /// <summary> The current memory used by the virtual machine. </summary>
        public long? CurrentMemoryUsageInMB { get; set; }
    }
}
