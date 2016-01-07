using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Queue
{
    class Queue
    {
        private Node _front, _rear;
        private FlowLayoutPanel khung;
        private uint _size = 0;
        public Node front
        {
            get
            {
                return this._front;
            }
            set
            {
                this._front = value;
            }
        }
        public uint Size { get { return this._size; } }
        public Queue(Panel panel)
        {
            this._front = null;
            this._size = 0;
            this.khung = new FlowLayoutPanel();
            this.khung.AutoScroll = true;
            this.khung.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.khung.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.khung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khung.Location = new System.Drawing.Point(0, 0);
            this.khung.Size = new System.Drawing.Size(573, 100);
            panel.Controls.Add(this.khung);
        }
        public void enqueue(Node n)
        {
            if (this._front == null)
            {

                this._front = n;

            }
            else {
                this._rear.next = n;
            }

            this._rear = n;
            this._size++;
            this.khung.Controls.Add(n.Data);
        }
        public Node dequeue()
        {
            if (this._front == null)
            {
                return null;
            }
            else
            {
                Node tam = this.front;
                this._front = this._front.next;
                this.khung.Controls.RemoveAt(0);
                this._size--;
                return tam;
            }
        }
        public bool isEmpty()
        {
            return this._front == null;
        }
        public void save()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text file(.txt) | *.txt";
            DialogResult res = saveFile.ShowDialog();
            if (res == DialogResult.OK)
            {
                StreamWriter w = new StreamWriter(saveFile.FileName, false);
                string result = "";
                Node tam = this._front;
                while (tam!=null)
                {
                    w.WriteLine(tam.Data.Text.ToString());
                    tam = tam.next;
                }
                w.Close();
            }
        }
        public void open()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text file(.txt) | *.txt";
            DialogResult res = openFile.ShowDialog();
            
            if (res == DialogResult.OK)
            {
                this.front = null;
                this.khung.Controls.Clear();
                this._size = 0;
                StreamReader r = new StreamReader(openFile.FileName);
                string line = r.ReadLine();
                while(line != null)
                {
                    this.enqueue(new Node(line));
                    line = r.ReadLine();
                }
                r.Close();
            }
        }
    }
}
