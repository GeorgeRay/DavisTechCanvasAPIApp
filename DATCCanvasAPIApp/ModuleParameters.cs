using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanvasAPIApp
{
    class ModuleParameters
    {
        //Get Access Token Parameter
        public string AccessToken()
        {
            return Properties.Settings.Default.CurrentAccessToken;
        }//End Get Access Token Parameter
        
        public string SequentialProgress (bool seqProChecked)
        {
            if (seqProChecked == true)
                return "&module[require_sequential_progress]=true";
            else
                return "";
        }

        public string UnlockDate(bool dateChecked, DateTime date)
        {
            if (dateChecked == true)
            {
                string unlockDate = date.ToString();
                return "&module[unlock_at]=" + unlockDate;
            }
            else
                return "";
        }

        public string ModulePosition(bool posChecked, decimal pos)
        {
            if (posChecked == true)
            {
                return "&module[position]=" + pos;
            }
            else
                return "";
        }

        /*public string ModulePublish(bool publishModule)
        {
            if (publishModule == true)
                return "&module[published]=true";
            else
                return "";
        }*///End Publish Module
    }
}
