using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Extra library for drawing form
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AssExtra {
    interface IDrinks {
        void createFormForChooseDrinks(); // tạo form hiển thị thông tin từng món nước.
        IDrink createDrink();               // tạo ra món nước.
    };


    // Form trong trường hợp người dùng đặt mang đi.
    class TakeAwayForm : IDrinks {
        public void createFormForChooseDrinks() {
            MessageBox.Show("jhgiboih");
        }

        public IDrink createDrink() {
            return null;
        }
    };

    // Form trong trường hợp người dùng uống tại quán.
    class ForHereForm : IDrinks {
        public void createFormForChooseDrinks() {

        }

        public IDrink createDrink() {
            return null;
        }
    };
}
