using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Queue;

namespace Queue
{
    public partial class frmMain : Form
    {
        Queue queueMain;
        public frmMain()
        {
            
            InitializeComponent();
            queueMain = new Queue(this.containerMain.Panel1);
            checkStatusQueue();
        }

        

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.txtInput;
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            int test;
            if (int.TryParse(this.txtInput.Text, out test))
            {
                this.queueMain.enqueue(new Node(this.txtInput.Text));
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số");
            }
            this.txtInput.Text = "";
            this.txtInput.Focus();
            checkStatusQueue();
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            this.lbResult.Text = this.queueMain.dequeue().Data.Text;
            checkStatusQueue();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void checkStatusQueue()
        {
            if (this.queueMain.isEmpty())
            {
                this.statusQueue.Text = "Queue rỗng";
                this.btnDequeue.Enabled= this.menuSave.Enabled = false;
                
            }
            else
            {
                this.statusQueue.Text = "Queue có " + this.queueMain.Size + " node";
                this.btnDequeue.Enabled = this.menuSave.Enabled = true;
            }
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            this.queueMain.save();
            checkStatusQueue();
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            this.queueMain.open();
            checkStatusQueue();
        }
    }
}
