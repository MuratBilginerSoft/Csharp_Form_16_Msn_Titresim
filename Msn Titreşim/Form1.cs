using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Msn_Titreşim
{
    public partial class Form1 : Form
    {
        #region Parameters

        int x, y;

        #endregion

        #region Definition

        Random r = new Random();

        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point u = this.Location; // FOrmun Konumu x=100 ve y=50 ise. u.x=100 u.y=50;

            for (int i = 0; i < 100; i++)
            {
                x = r.Next(1, 10);
                y = r.Next(1, 10);

                this.Location = new Point(u.X+x,u.Y+y);

                Thread.Sleep(20);
            }

            this.Location = u;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
