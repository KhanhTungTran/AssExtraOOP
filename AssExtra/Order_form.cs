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
    public partial class Order_form : Form
    {
        List<string> drink_list = new List<string>();

        public Order_form()
        {
            InitializeComponent();

            this.drink_order.TabPages.Clear();
        }

        private void Drink_btn_click(object sender, EventArgs e)
        {
            if(this.drink_order.TabCount <= 0 || this.drink_order.TabPages[this.drink_order.TabCount - 1].Text != "Bill preview")
            {
                Button drink_btn = (Button)sender;
                this.BackgroundImage = drink_btn.Image;

                this.drink_list.Add(drink_btn.Text);

                Form bill = new Option();
                TabPage new_tab = new TabPage(bill.Text);

                bill.TopLevel = false;
                bill.Parent = new_tab;
                bill.Show();

                this.drink_order.TabPages.Add(new_tab);
                this.drink_order.SelectedIndex = this.drink_order.TabCount - 1;

                this.finish_btn.Text = "Xong";
            }
        }

        private void Switch_form()
        {
            Form new_form = new Choosing_method();
            new_form.TopLevel = false;
            new_form.Parent = this.Parent;
            this.Hide();
            new_form.Show();

            this.Parent.Controls.Remove(this);
            this.Close();
        }

        private void finish_btn_Click(object sender, EventArgs e)
        {
            Button finish_button = (Button)sender;
            if (this.drink_order.TabCount <= 0)
            {
                Switch_form();
                Engine.Bill_manager.Clear();
            }
            else if (finish_btn.Text == "Xong")
            {
                foreach (string i in this.drink_list)
                {
                    Engine.Bill_manager.Add_bills(i);
                }

                drink_list.Clear();

                Bill_preview bill = new Bill_preview();
                TabPage new_tab = new TabPage(bill.Text);

                bill.TopLevel = false;
                bill.Parent = new_tab;
                bill.Show();

                this.drink_order.TabPages.Add(new_tab);
                this.drink_order.SelectedIndex = this.drink_order.TabCount - 1;

                this.next_btn.Text = "In hóa đơn";
                finish_btn.Enabled = false;
            }
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (this.next_btn.Text == "In hóa đơn")
            {
                Engine.File_manager.Write_to_file();
                this.finish_btn.Enabled = true;
                this.next_btn.Text = "Hủy";

                Engine.Bill_manager.Clear();
                Switch_form();
            }
            else
            {
                if (this.drink_order.TabCount > 0)
                {
                    //Engine.Bill_manager.Remove_bill(this.drink_order.SelectedIndex);
                    this.drink_list.RemoveAt(this.drink_order.SelectedIndex);
                    this.drink_order.TabPages.RemoveAt(this.drink_order.SelectedIndex);
                }
            }
        }

        private void drink_order_SizeChanged(object sender, EventArgs e)
        {
            if (this.drink_order.TabCount <= 0)
                this.next_btn.Enabled = false;
            else this.next_btn.Enabled = true;
        }
    }
}