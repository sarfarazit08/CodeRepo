using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


namespace HelloRemotingServiceClient
{
    public partial class frmMain : Form
    {
        IHelloRemotingService.IHelloRemotingService client;

        public frmMain()
        {
            InitializeComponent();
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel);

            client = (IHelloRemotingService.IHelloRemotingService) Activator.GetObject
                (
                    typeof(IHelloRemotingService.IHelloRemotingService),
                    "tcp://localhost:8085/HelloWorldMessage"
                );
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {             
             lblResult.Text = client.HelloWorldMessage(txtBoxName.Text);
        }
    }
}
