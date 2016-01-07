using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue
{
    class Node
    {
        private Label data;
        private Node _next;
        public Node() {
            this.data = new Label();
            this._next = null;
            this.data.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.data.Location = new System.Drawing.Point(3, 0);
            this.data.Padding = new System.Windows.Forms.Padding(10);
            this.data.Size = new System.Drawing.Size(41, 85);
            this.data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }
        public Node(string d, Node next = null) {
            this.data = new Label();
            this._next = next;
            this.data.Text = d;
            this.data.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.Padding = new System.Windows.Forms.Padding(10);
            this.data.Size = new System.Drawing.Size(41, 85);
            this.data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }
        public Label Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
        public Node next{
            get
            {
                return this._next;
            }
            set
            {
                this._next = value;
            }
        }
    }
}
