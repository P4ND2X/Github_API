using Octokit;
using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace BMO_Admin
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string plainText)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(plainText);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static string ReverseArray(string text)
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return (new string(array));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Decode_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = ReverseArray(dText.Text);
                temp = Base64Decode(temp);
                dText.Text = temp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message, "Decoder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Encode_Click(object sender, EventArgs e)
        {

            try
            {
                string temp = Base64Encode(eText.Text);
                eText.Text = ReverseArray(temp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message, "Encoder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        bool Authorizaed = false;
        bool needUpdate = false;


        async Task Get()
        {
            try
            {
                var client = new GitHubClient(new ProductHeaderValue("GET-CLIENT"));

                var basicAuth = new Credentials(token.Text); // login token
                client.Credentials = basicAuth;
                var user = await client.User.Current(); // Get user info
                string owner = user.Login;
                string repo = repotext.Text;
                string branch = "master";
                string targetFile = dirtext.Text;

                var file = await client.Repository.Content.GetAllContentsByRef(owner, repo, targetFile, branch);
                versiontext.Text = file.First().Content.ToString();
            }
            catch (NotFoundException)
            {
                MessageBox.Show("File/Repo not found, please send an API request to create it...\n", "GitHub API", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        async Task Update()
        {

            try
            {
                var client = new GitHubClient(new ProductHeaderValue("API-CLIENT"));

                try
                {
                    var basicAuth = new Credentials(token.Text);
                    client.Credentials = basicAuth;
                    var user = await client.User.Current(); // Get user info
                    string owner = user.Login;
                    string repo = repotext.Text;
                    string branch = "master";
                    string targetFile = dirtext.Text;

                    if (!Authorizaed)
                    {
                        this.Text = "GitHub API: " + user.Login;
                        MessageBox.Show("Logged in as: \n" + user.Name, "GitHub", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Authorizaed = true;
                        token.Visible = false;
                        label4.Visible = false;
                        login.Visible = false;

                        Decode.Visible = true;
                        label1.Visible = true;
                        dText.Visible = true;

                        Encode.Visible = true;
                        label3.Visible = true;
                        eText.Visible = true;

                        this.SetClientSizeCore(585, 360);
                        // try to get the file content
                        var file = await client.Repository.Content.GetAllContentsByRef(owner, repo, targetFile, branch);
                        versiontext.Text = file.First().Content.ToString();

                    }
                    else
                    {

                        if (user != null && needUpdate)
                        {


                            try
                            {
                                // try to get the file (and with the file the last commit sha)
                                var existingFile = await client.Repository.Content.GetAllContentsByRef(owner, repo, targetFile, branch);

                                // update the file
                                var updateChangeSet = await client.Repository.Content.UpdateFile(owner, repo, targetFile,
                                   new UpdateFileRequest("API: Update", versiontext.Text, existingFile.First().Sha, branch));

                                needUpdate = false;
                                MessageBox.Show("File updated successfully\n", "GitHub API", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Octokit.NotFoundException)
                            {
                                MessageBox.Show("File/Repo not found, creating new one...\n", "GitHub API", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                var createChangeSet = await client.Repository.Content.CreateFile
                                    (owner, repo, targetFile, new CreateFileRequest
                                    ("API: Create",
                                    versiontext.Text + branch));

                                needUpdate = false;
                            }
                        }

                    }

                }
                catch (Octokit.AuthorizationException)
                {
                    MessageBox.Show("Bad getaway: Token is Expired/Invalid.\n", "GitHub API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    login.Enabled = true;
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Bad getaway: Connection failed." +
                    "\nPlease cheack your internet", "GitHub API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                login.Enabled = true;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Authorizaed)
            {
                needUpdate = true;
                Update();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            nowtime.Text = time.ToString("F");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://github.com/P4ND2X/BMO_Release");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://github.com/P4ND2X/BMO_Config");
        }

        private void login_Click(object sender, EventArgs e)
        {
            login.Enabled = false;
            Update();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Get();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Authorizaed = false;
            MessageBox.Show("Logged out successfully!\n", "GitHub", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Text = "Welcome to GitHub API";
            this.SetClientSizeCore(250, 125);

            token.Visible = true;
            label4.Visible = true;
            login.Visible = true;

            Decode.Visible = false;
            label1.Visible = false;
            dText.Visible = false;

            Encode.Visible = false;
            label3.Visible = false;
            eText.Visible = false;

            login.Enabled = true;

        }
    }
}