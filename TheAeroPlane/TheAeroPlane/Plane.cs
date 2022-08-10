using System;
using System.Collections.Generic;
using System.Text;

namespace TheAeroPlane_
{
    class Plane
    {
        private Logger logger;
        public Plane(Logger logger)
        {
            this.logger = logger;
        }
        public void startEngine()
        {
            this.logger.info("mesin menyala");
        }
        public void takeOff()
        {
            this.logger.info("pesawat naik");
        }
        public void turbulance()
        {
            this.logger.warning("pesawat berguncang");
        }
    }
}
