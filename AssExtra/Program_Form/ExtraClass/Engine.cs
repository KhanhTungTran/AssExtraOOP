using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Windows.Forms;

namespace AssExtra
{
    class Engine
    {
        private class Bills_history
        {
            private int id;
            private List<string> order_type = new List<string>();

            public Bills_history(string _order_type)
            {
                this.id = Engine.Bill_manager.id_counter++;
                this.order_type.Add(_order_type);
            }

            public string Get_order()
            {
                string re = "";

                foreach(string i in this.order_type)
                {
                    re += i;
                }

                return re;
            }

            public void Add_to_bill(string _order_form)
            {
                this.order_type.Add("\n" + _order_form);
            }

            public string Get_bills_name()
            {
                return "Bill id " + this.id.ToString();
            }

            public void Remove(int index)
            {
                this.order_type.RemoveAt(index);
            }
        }

        public static class Bill_manager
        {
            static public int id_counter = 0;
            static Bills_history bills = null;
            static public string Bills_preview()
            {
                return Add_header() + bills.Get_order() + Add_footer();
            }

            static string Add_date_and_time()
            {
                return (DateTime.Now.DayOfWeek.ToString()) + " " + Engine.Format_manager.Reformat_str(DateTime.Now.Day) + "/" +
                    Engine.Format_manager.Reformat_str(DateTime.Now.Month) + "/" + Engine.Format_manager.Reformat_str(DateTime.Now.Year) + "\n\t\t\t\t\t" +
                    Engine.Format_manager.Reformat_str(DateTime.Now.Hour) + ":" + Engine.Format_manager.Reformat_str(DateTime.Now.Minute);
            }

            static string Add_header()
            {
                return bills.Get_bills_name() + "\t\t\t\t" + Add_date_and_time()
                    + "\n\t\t" + Choosing_method.Get_method() + "\n";
            }

            static string Add_footer()
            {
                return "\n\n======================================================";
            }

            static public void Add_bills(string order_form)
            {
                if (bills == null)
                {
                    bills = (new Bills_history(order_form));
                }
                else bills.Add_to_bill(order_form);
            }

            static public void Clear()
            {
                bills = null;
            }

            static public void Remove_bill(int index)
            {
                if (bills != null) bills.Remove(index);
            }
        }

        public static class File_manager
        {
            static public void Write_to_file()
            {
                if (!Directory.Exists("./Bills"))
                {
                    Directory.CreateDirectory("./Bills");
                }
            }
        }

        public static class Format_manager
        {
            static public string Reformat_str(int input, int num_of_digit = 2)
            {
                return ((input < 10) ? "0" : "") + input.ToString();
            }
        }
    }
}
