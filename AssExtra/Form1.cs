using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssExtra {    
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        IDrinks DrinksFactory;
        private void btnToGo_Click(object sender, EventArgs e) {
            DrinksFactory = new TakeAwayForm();
            DrinksFactory.createFormForChooseDrinks();
        }

        private void btnForHere_Click(object sender, EventArgs e) {
            DrinksFactory = new ForHereForm();
            DrinksFactory.createFormForChooseDrinks();
        }
    }
}
