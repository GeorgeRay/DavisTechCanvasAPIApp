using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanvasAPIApp
{
   class PageParameters
   {
      //Get Access Token Parameter
      public string AccessToken()
      {
         return Properties.Settings.Default.CurrentAccessToken;
      }//End Get Access Token Parameter

      public string PageDescription(string description)
      {
         return "&wiki_page[body]=" + description;
      }//End description parameter

      public string EditRoles(bool teachers, bool teachandstu, bool all)
      {
         string result = "";
         if (teachers == true)
         {
            result = "&wiki_page[editing_roles]=teachers";
         }
         if (teachandstu == true)
         {
            result = "&wiki_page[editing_roles]=teachers,students";
         }
         if (all == true)
         {
            result = "&wiki_page[editing_roles]=public";
         }
         return result;
      }//end edit roles

        public string ContentUpdate(bool update)
        {
            return "&wiki_page[notify_of_update]=" + update.ToString().ToLower();
        }//end content update

        public string PagePublish(bool publishPage)
        {
            if (publishPage == true)
                return "&wiki_page[published]=true";
            else
                return "";
        }//End Publish Page
    }// end class
}
