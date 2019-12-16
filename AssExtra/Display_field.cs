using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssExtra
{
    public partial class Display_field : Form
    {
        public Display_field()
        {
            InitializeComponent();
        }

        private void Display_field_Load(object sender, EventArgs e)
        {
            Form new_form = new Choosing_method();
            new_form.TopLevel = false;
            new_form.Parent = this;
            new_form.Show();
        }
    }
}
