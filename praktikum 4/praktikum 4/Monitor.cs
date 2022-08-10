using System;
using System.Collections.Generic;
using System.Text;

namespace Praktikum4
{
    class Monitor
    {
        private String resolution;
        private Boolean supportHdmi;
        private double size;
        public Monitor(String resolution, Boolean supportHdmi, double size)
        {
            this.resolution = resolution;
            this.supportHdmi = supportHdmi;
            this.size = size;
        }
        private String getResolution()
        {
            return this.resolution;
        }
        private Boolean isSupportHdmi()
        {
            return this.supportHdmi;
        }
        private double getSize()
        {
            return this.size;
        }
        public override string ToString()
        {
            return $"Monitor resolution: {resolution} ; Monitor support hdmi :
        { supportHdmi}; Monitor dimensi; { size} inch ";

        }
    
    }
}
