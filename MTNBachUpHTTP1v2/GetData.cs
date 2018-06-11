using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTNBachUpHTTP1v2
{
    public partial class GetData : Form
    {
        public Boolean ButtonOk = false;
        public String SID;
        public String ContCount;

        public GetData()
        {
            InitializeComponent();
        }

        private void GetData_Load(object sender, EventArgs e)
        {




        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            try
            {
                if (tbxSID.Text == "") throw new Exception("Please Provide SID");
                if (tbxContNum.Text == "") throw new Exception("Please Provide Numbber of Contacts");

                SID = tbxSID.Text;
                ContCount = tbxContNum.Text;
                ButtonOk = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }

        }
    }
}
