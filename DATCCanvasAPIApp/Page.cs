using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanvasAPIApp
{
   class Page
   {
        public string title { get; set; }
        public string body { get; set; }
        public string editing_roles { get; set; }
        public bool notify_of_update { get; set; }
        public bool published { get; set; }
        public bool front_page { get; set; }



      public string EditRoles(bool teachers, bool teachandstu, bool all)
      {
         string result = "";
         if (teachers == true)
         {
            result = "teachers";
         }
         if (teachandstu == true)
         {
            result = "teachers,students";
         }
         if (all == true)
         {
            result = "public";
         }
         return result;
      }//end edit roles

    }// end class
}
