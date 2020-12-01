using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Linq;
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
            if (Properties.Settings.Default.MongoDBPW.Length > 0)
            {
                txbConnection.Text = connectionString.Replace(Properties.Settings.Default.MongoDBPW, "<password>");
            }

            //Turn on event handlers after the form loads to prevent form closing with unsaved data
            this.TxbUserName.TextChanged += new System.EventHandler(this.TextChange);
            this.TxbPassword.TextChanged += new System.EventHandler(this.TextChange);
            this.txbDefaultDatabase.TextChanged += new System.EventHandler(this.TextChange);
            this.TxbGradingCollecion.TextChanged += new System.EventHandler(this.TextChange);
            this.txbConnection.TextChanged += new System.EventHandler(this.TextChange);

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

            var frm = Application.OpenForms.Cast<Form>().Where(x => x.Name == "GradingQueue").FirstOrDefault();

            if (null != frm)
            {
                GradingQueue gradingForm = (GradingQueue)frm;
                gradingForm.ConnectToMongoDB();
                frm = null;
            }


        }

        private void btnParseConnection_Click(object sender, EventArgs e)
        {
            rtbOutput.Clear();
            connectionString = txbConnection.Text.Replace("<password>", TxbPassword.Text).Replace("<dbname>", txbDefaultDatabase.Text);
            try
            {
                //Set wait cursor
                Cursor.Current = Cursors.WaitCursor;
                var client = new MongoClient(connectionString);
                
                var database = client.GetDatabase(txbDefaultDatabase.Text);

                foreach (var collection in database.ListCollectionsAsync().Result.ToListAsync<BsonDocument>().Result)
                {
                    rtbOutput.AppendText(collection.ToString());
                }

                if (textChanged == true)
                {
                    btnSave.Enabled = true;
                }
                //Return cursor to default
                Cursor.Current = Cursors.Default;

            }
            catch (Exception ex)
            {
                rtbOutput.AppendText($"Connection Failed\n{ex}");
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
