using System;
using System.Windows.Forms;
using System.Net;


namespace CanvasAPIApp
{
    public partial class AccessTokenForm : Form
    {
        GeneralAPIGets getProfile = new GeneralAPIGets();
        public AccessTokenForm()
        {
            InitializeComponent();
        }

        private void AccessTokenForm_Load(object sender, EventArgs e)
        {
            //Displaying current settings
            txbWebsite.Text = Properties.Settings.Default.InstructureSite.ToString();
            String currentAccessToken = Properties.Settings.Default.CurrentAccessToken;
            if (currentAccessToken != "No Access Token" && currentAccessToken.Length != 0)
            {
                txbCurrentAccessToken.Text = (string.Concat(currentAccessToken.Substring(0, 7), "".PadRight(currentAccessToken.Length - 7, '*')));
                try
                {
                    string name = "name";
                    lbxCurrentUser.Text = getProfile.GetProfile(name);

                }
                catch (Exception callException)
                {
                    string callExceptionString = callException.ToString();
                    if (callExceptionString.Contains("401"))
                        MessageBox.Show("Access Denied! Please Check Access Token and Website Name. \n\n" + callException.ToString());
                    else
                        MessageBox.Show(callException.ToString());
                }

            }
            else
            {
                txbCurrentAccessToken.Text = "No Access Token";
            }


        }//End Load

        //Saving token
        private void saveAccessToken_Click(object sender, EventArgs e)
        {
            //Saving User input


            //Setting variable for try catch and web call
            String currentAccessToken = Properties.Settings.Default.CurrentAccessToken;

            //Set wait cursor
            Cursor.Current = Cursors.WaitCursor;
            //Make Web call to get name
            if (txbCurrentAccessToken.Text != "No Access Token")
            {

                try
                {
                    //Setting new access token
                    Properties.Settings.Default.CurrentAccessToken = txbCurrentAccessToken.Text.ToString();
                    Properties.Settings.Default.Save();
                    currentAccessToken = Properties.Settings.Default.CurrentAccessToken;
                    //Display new access Token with mask
                    txbCurrentAccessToken.Text = (string.Concat(currentAccessToken.Substring(0, 7), "".PadRight(currentAccessToken.Length - 7, '*')));
                    //REST object to get
                    string name = "name";
                    //Display Name of current profile
                    lbxCurrentUser.Text = getProfile.GetProfile(name);
                }
                catch (Exception callException)
                {
                    //set token text box
                    txbCurrentAccessToken.Text = "No Access Token";
                    //set no user in user text box
                    lbxCurrentUser.Text = "No User Loaded";
                    //save no access token to settings
                    Properties.Settings.Default.CurrentAccessToken = "No Access Token";
                    Properties.Settings.Default.Save();
                    //Change option on close/cancel button
                    btnCancel.Text = "Close";
                    //create strong from exception
                    string callExceptionString = callException.ToString();

                    if (callExceptionString.Contains("401"))
                        MessageBox.Show("Access Denied! Please Check Access Token and Website Name. \n\n" + callException.ToString());
                    else
                        MessageBox.Show(callException.ToString());
                }
                //Change the cancel button to close
                btnCancel.Text = "Close";
            }
            else
            {
                txbCurrentAccessToken.Text = "No Access Token";
                lbxCurrentUser.Text = "No User Loaded";
                btnCancel.Text = "Close";
            }

            /*Build out encryption on Access Token*/
            /*
            // Data to protect. Convert a string to a byte[] using Encoding.UTF8.GetBytes().

            byte[] newAccessToken = Encoding.UTF8.GetBytes(txbNewAccessToken.ToString());

            // Generate additional entropy (will be used as the Initialization vector)
            byte[] entropy = new byte[20];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
               rng.GetBytes(entropy);
            }

            byte[] cipherAccessToken = ProtectedData.Protect(newAccessToken, entropy,
                DataProtectionScope.CurrentUser);

            Properties.Settings.Default.CurrentAccessToken = Encoding.UTF8.GetString(cipherAccessToken); ;
            Properties.Settings.Default.Save();
            txbNewAccessToken.Text = "";

            //Convert setting string back to byte
            cipherAccessToken = Encoding.UTF8.GetBytes(Properties.Settings.Default.CurrentAccessToken);
            //decode 
            byte[] currentAccessToken = ProtectedData.Unprotect(cipherAccessToken, entropy,
       DataProtectionScope.CurrentUser);
            //convert byte to string
            string currentAccessTokenString = Encoding.UTF8.GetString(currentAccessToken);

            txbCurrentAccessToken.Text = Convert.ToString(currentAccessTokenString);
            */

            //Return cursor to default
            Cursor.Current = Cursors.Default;
        }//end saving token

        //Saving Website
        private void btnSaveWebsite_Click(object sender, EventArgs e)
        {
           
                WebRequest webRequest = WebRequest.Create(txbWebsite.Text.ToString());
                WebResponse webResponse;
                try
                {
                    webResponse = webRequest.GetResponse();
                }
                //if HttpWebResponse response = (HttpWebResponse)request.GetResponse(); fails then throw an error
                catch (WebException)
                { MessageBox.Show("Failed to reach site.", "Failed", MessageBoxButtons.OK); }
                    //Saving Website to settings
                    Properties.Settings.Default.InstructureSite = txbWebsite.Text.ToString();
                    Properties.Settings.Default.Save();
                    btnCancel.Text = "Close";
                    MessageBox.Show("The site has been saved.", "Success", MessageBoxButtons.OK);
        }//End Saving website

        //Closing Form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

            //Update courseForm to current course
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == "CoursesForm")
                {
                    (frm as CoursesForm).loadCourseLists();
                    return;
                }
            }
        }//End Closing Form
    }
}
