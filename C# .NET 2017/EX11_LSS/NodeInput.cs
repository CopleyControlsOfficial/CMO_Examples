using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX12_LSS
{
    public partial class NodeInput : Form
    {
        int nodeID;

        public NodeInput()
        {
            InitializeComponent();
            ShowDialog();
        }

        private void NodeInput_Load(object sender, EventArgs e)
        {

        }

        private void SendIDButton_Click(object sender, EventArgs e)
        {
            nodeID = Convert.ToInt32(NodeIDTextBox.Text);
            Dispose();
        }

        public int NodeID
        {
            get { return nodeID; }
        }
    }
}
