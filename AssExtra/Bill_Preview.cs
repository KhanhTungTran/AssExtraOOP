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
    public partial class Bill_preview : Form
    {
        public Bill_preview()
        {
            InitializeComponent();
            timer_Tick(this.timer, new EventArgs());

            this.show_field.Text = Engine.Bill_manager.Bills_preview();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.day_label.Text = (DateTime.Now.DayOfWeek.ToString()) + " " + Engine.Format_manager.Reformat_str(DateTime.Now.Day) + "/" +
                Engine.Format_manager.Reformat_str(DateTime.Now.Month) + "/" + Engine.Format_manager.Reformat_str(DateTime.Now.Year);

            this.date_time_label.Text = Engine.Format_manager.Reformat_str(DateTime.Now.Hour) + ":" + Engine.Format_manager.Reformat_str(DateTime.Now.Minute); ;

        }
    }
}
