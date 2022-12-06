using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_learning
{
    public partial class Lecture : Form
    {
        public Lecture()
        {
            InitializeComponent();
        }

        private void lectureText_TextChanged(object sender, EventArgs e)
        {

        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ActiveControl = null;
        }
    }
}
