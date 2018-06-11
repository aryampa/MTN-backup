using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace MTNBachUpHTTP1v2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            tbxDisplay.Text = "";
            tbxFinalDisplay.Text = "";

        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
           // tbxDisplay.Text = "";
            tbxFinalDisplay.Text = "";

            GetData Gdt = new GetData();
            //Gdt.ShowDialog();

            Gdt.ButtonOk = true;

            if (Gdt.ButtonOk)
            {

                try
                {
                    openFileDlg.ShowDialog();


                    FileStream fsIn = new FileStream(openFileDlg.FileName, FileMode.Open, FileAccess.Read);

                    StreamReader sReader = new StreamReader(fsIn);

                    tbxDisplay.Text = sReader.ReadToEnd();

                    tbxDisplay.Update();

                    fsIn.Close();

                    //String SID = Gdt.SID;
                    //String ContCount = Gdt.ContCount;

                    //WebClient wc = new WebClient();

                    //WebHeaderCollection WHC = new WebHeaderCollection();
                    //WHC.Add("Host", "mtnuganda.weballynis.gemalto.com");
                    //WHC.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:33.0) Gecko/20100101 Firefox/33.0");
                    //WHC.Add("Accept", "application/json, text/javascript, */*; q=0.01");
                    //WHC.Add("Accept-Language", "en-US,en;q=0.5");
                    //// WHC.Add("Accept-Encoding","gzip, deflate");

                    //WHC.Add("Referer", "https://mtnuganda.weballynis.gemalto.com/CloudBackup/asp_getfileid.osp?SID=721651514_edpubhap&FID=3002&Substitute=__o3sis_TID__^contact^__o3sis_SYNC_REQUESTED__^false^__o3sis_SUBST_FILTER__^^&Language=en");
                    //// WHC.Add("Connection", "keep-alive");

                    //wc.Headers = WHC;

                    //string reQString = "https://mtnuganda.weballynis.gemalto.com/CloudBackup/ajax_contact_list.osp?SID=" + SID + "&FolderID=0&PageOffset=0&PageSize=" + ContCount + "&FilterCategory=&ShowCategories=1&SortColumn=NickName:FirstName:MiddleName:LastName&DetailsToShow=FirstName,MiddleName,LastName,Mobile1,Mobile2,Mobile3&requestid=1459392695291";

                    if (tbxDisplay.Text == "") throw new Exception("please Input Json Text");


                    String Response = tbxDisplay.Text;
                   // tbxDisplay.Text = Response;
                   // tbxDisplay.Update();


                  //  if (tbxDisplay.Text == "") throw new Exception("please Input Json Text");



                    JsonSerializerSettings st = new JsonSerializerSettings();
                    st.MissingMemberHandling = MissingMemberHandling.Ignore;

                    jsonClass JsonObject = (jsonClass)JsonConvert.DeserializeObject<jsonClass>(tbxDisplay.Text, st);

                    //String kk = JsonObject.timestamp;

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("\"Contact ID\",\"Full Name\",\"Phone1\"");

                    int genCounter = 1;
                    foreach (contact contObject in JsonObject.data.contacts)
                    {
                        String Name = "";


                        List<String> Phone = new List<string> { };

                        if (contObject.firstname != "") Name = Name + " " + contObject.firstname.Replace(",", "");
                        if (contObject.lastname != "") Name = Name + " " + contObject.lastname.Replace(",", "");
                        if (contObject.middlename != "") Name = Name + " " + contObject.middlename.Replace(",", "");

                        if (contObject.mobile1 != "") Phone.Add(contObject.mobile1.Replace(",", ""));
                        if (contObject.mobile2 != "") Phone.Add(contObject.mobile2.Replace(",", ""));
                        if (contObject.mobile3 != "") Phone.Add(contObject.mobile3.Replace(",", ""));

                        if (Phone.Count == 1)
                        {
                            sb.AppendLine(genCounter.ToString() + "," + Name + "," + Phone[0]);
                            genCounter++;
                        }

                        else
                        {
                            int counter = 1;
                            foreach (String phone in Phone)
                            {

                                sb.AppendLine(genCounter.ToString() + "," + Name + "_" + counter + "," + phone);
                                counter++;
                                genCounter++;
                            }
                        }




                    }

                    tbxFinalDisplay.Text = sb.ToString();
                    btnSave.Enabled = true;



                    MessageBox.Show("Done!!");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog svDialog = new SaveFileDialog();
                svDialog.OverwritePrompt = true;
                svDialog.ValidateNames = true;

                DialogResult DR = svDialog.ShowDialog();

                if (DR == System.Windows.Forms.DialogResult.OK)
                {
                    MessageBox.Show("OK Has Been Clicked");

                    svDialog.AddExtension = true;
                    svDialog.DefaultExt = ".csv";

                    StreamWriter sw = File.CreateText(svDialog.FileName);

                    sw.Write(tbxFinalDisplay.Text);

                    sw.Flush();
                    sw.Close();

                    MessageBox.Show("Done Saving");



                    // svDialog.
                }
                else
                {
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Saving Error");
            }
        }


    }
}
