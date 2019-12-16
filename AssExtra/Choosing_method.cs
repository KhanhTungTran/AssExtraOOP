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
    public partial class Choosing_method : Form
    {
        private static string method = "";
        private static bool is_get = false;
        public Choosing_method()
        {
            InitializeComponent();
        }

        private void Switch_form()
        {
            Form new_form = new Order_form();
            new_form.TopLevel = false;
            new_form.Parent = this.Parent;
            this.Hide();
            new_form.Show();

            this.Parent.Controls.Remove(this);
            this.Close();
        }

        private void here_btn_Click(object sender, EventArgs e)
        {
            Choosing_method.method = "For here";
            Choosing_method.is_get = true;

            Switch_form();
        }

        private void take_away_btn_Click(object sender, EventArgs e)
        {
            Choosing_method.method = "Take away";
            Choosing_method.is_get = true;

            Switch_form();
        }

        public static string Get_method()
        {
            Choosing_method.is_get = false;
            return Choosing_method.method;
        }
    }
}
