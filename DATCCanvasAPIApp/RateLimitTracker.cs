using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanvasAPIApp
{

    public class RateLimitTracker
    {
        //the API only returns the remaining limit, it is usually out of 700 maximimum, and seems to refill within seconds. Depends on API server settings which vary

        //continously updated property in case we need it
        public string RateLimitRemaining { get; set; }

        //data
        public List<LimitCheck> LimitChecks { get; set; }

        int maximumStored = 5000;
        public double MaxLimit { get; set; } = 700.0;


        public RateLimitTracker()
        {
            LimitChecks = new List<LimitCheck>();
        }


        public void AddLimitCheck(DateTime timestamp, string limitRemaining)
        {
            AddLimitCheck(timestamp, double.Parse(limitRemaining));
        }
        public void AddLimitCheck(DateTime timestamp, double limitRemaining)
        {
            LimitChecks.Add(new LimitCheck( timestamp, limitRemaining));

            if(LimitChecks.Count > maximumStored)
                LimitChecks.RemoveRange(0, 20);

            //auto adjust max limit for varying server conditions
            if (limitRemaining > MaxLimit)
                MaxLimit = limitRemaining;
            
        }

        //holds a timestamp and the rate limit reported at that time
        public class LimitCheck
        {
            public LimitCheck(DateTime timestamp, double limitRemaining)
            {
                Timestamp = timestamp;
                LimitRemaining = limitRemaining;

            }
            public DateTime Timestamp { get; set; }
            public double LimitRemaining {get; set;}
        }
    }
}
