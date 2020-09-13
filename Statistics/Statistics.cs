using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    
    public class Stats
    {
         float average;
         float min;
        float max;

        public Stats()
        {
            this.average=0;
            this.max=0;
            this.min=0;
        }

        #region properties
        public float Average
        {
            get{return this.average;}
            set{
                this.average=value;
            }
        }

        public float Min
        {
            get{return this.min;}
            set{
                this.min=value;
            }
        }

        public float Max
        {
            get{return this.max;}
            set{
                this.max=value;
            }
        }
    }
    #endregion
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers) {
            //Implement statistics here
            Stats resultobj = new Stats();

            if(numbers.Count!=0)
            {
                resultobj.Average=numbers.Average();
                resultobj.Min=numbers.Min();
                resultobj.Max=numbers.Max();
            }
            else
            {
               
                resultobj.Average= float.NaN;
                resultobj.Min= float.NaN;
                resultobj.Max= float.NaN;
            }

            return resultobj;
        }
    }
}
