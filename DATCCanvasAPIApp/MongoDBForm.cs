using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Windows.Forms;

namespace CanvasAPIApp
{
    public partial class MongoDBForm : Form
    {
        Boolean textChanged = false;
        string connectionString = "";
        public MongoDBForm()
        {
            InitializeComponent();
        }

        private void MongoDBForm_Load(object sender, EventArgs e)
        {            
            TxbUserName.Text = Properties.Settings.Default.MongoDBUserName;
            TxbPassword.Text = Properties.Settings.Default.MongoDBPW;
            txbDefaultDatabase.Text = Properties.Settings.Default.MongoDBDefaultDB;
            TxbGradingCollecion.Text = Properties.Settings.Default.MongoDBGradingCollection;
            connectionString = Properties.Settings.Default.MongoDBConnectionString;
            txbConnection.Text = connectionString.Replace(Properties.Settings.Default.MongoDBPW, "<password>");

        }
        private void SaveSettings()
        {
            Properties.Settings.Default.MongoDBUserName = TxbUserName.Text;
            Properties.Settings.Default.MongoDBPW = TxbPassword.Text;
            Properties.Settings.Default.MongoDBDefaultDB = txbDefaultDatabase.Text;
            Properties.Settings.Default.MongoDBGradingCollection = TxbGradingCollecion.Text;
            Properties.Settings.Default.MongoDBConnectionString = connectionString;
            Properties.Settings.Default.Save();
            btnSave.Enabled = false;
            rtbOutput.Clear();
            rtbOutput.AppendText("Settings Saved");
            textChanged = false;
        }

        private void btnParseConnection_Click(object sender, EventArgs e)
        {
            rtbOutput.Clear();
            connectionString = txbConnection.Text.Replace("<password>", TxbPassword.Text).Replace("<dbname>", txbDefaultDatabase.Text);
            try
            {                
                var client = new MongoClient(connectionString);
                var database = client.GetDatabase(txbDefaultDatabase.Text);

                foreach (var collection in database.ListCollectionsAsync().Result.ToListAsync<BsonDocument>().Result)
                {
                    rtbOutput.AppendText(collection.ToString());
                }
                
                if(textChanged == true)
                {
                    btnSave.Enabled = true;                    
                }
               
            }
            catch (Exception ex)
            {
                rtbOutput.AppendText("Connection Failed");
            }          

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettings();            
        }

        private void TextChange(object sender, EventArgs e)
        {
            textChanged = true;
        }

        private void CheckSaved(object sender, FormClosingEventArgs e)
        {
            if (textChanged)
            {
                DialogResult result = MessageBox.Show("Would you like to save your settings?", "Unsaved Settings", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        SaveSettings();
                        break;
                    case DialogResult.No:
                        break;                   
                }
            }

        }
    }
}
