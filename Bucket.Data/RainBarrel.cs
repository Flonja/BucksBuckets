using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket.Data
{
    class RainBarrel : WaterBucket
    {
        public RainBarrel(int content, BarrelSize capacity)
        {
            Content = content;
            Capacity = (int) capacity;
        }
    }
}
