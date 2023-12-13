using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week_form
{
    public partial class Calendar : Form
    {

        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            this.Size = new Size(800, 600);
        }

    }
}
