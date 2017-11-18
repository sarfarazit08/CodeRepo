using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldWindowsClient
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            HelloServiceReference.HelloServiceClient client =
                new HelloServiceReference.HelloServiceClient("NetTcpBinding_IHelloService");
            lblResult.Text = client.HelloMessage(txtName.Text);

        }
    }
}
