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
    abstract class IDrink {
        protected string[] names;                                             // chứa tên các options.
        protected string[] values;                                            // chứa giá trị cho các options tương ứng theo index.        
        protected void setTakeAwayOrForHere(int takeAwayOrForHere) {                        // set món nước uống tại chỗ hay mang đi.
            values[0] = takeAwayOrForHere.ToString();
            if (values[0] == "0") { names[0] = "Take Away"; }
            else names[1] = "For Here";

        }                     
        public int numberOfOptions() { return names.Length; }                          // trả về số options có thể tùy chỉnh như: có đá hay kzhông, đường ít hay nhiều.
        public string optionsNameAndValue(int index) { return names[index] + ": " + values[index]; }       // trả về tên và giá trị options thứ index + 1.
        //public string takeAwayOrForHere() { return null; }                         // cho biết món nước được order mang đi hay uống tại chỗ (phải set giá trị này ngay từ lúc tạo).
        abstract public void drawForm();
    };


    // Dùng để tạo Drink.
    class DrinkFactory {
        public static IDrink getDrink(int takeAwayOrForHere, string name) {
            switch (name) {
                case "TraSua":
                    return new TraSua(takeAwayOrForHere);
                case "TraChanh":
                    return new TraChanh(takeAwayOrForHere);
                case "TraDao":
                    return new TraDao(takeAwayOrForHere);
                case "CaPhe":
                    return new CaPhe(takeAwayOrForHere);
                case "HongTra":
                    return new HongTra(takeAwayOrForHere);
                default:
                    return null;
            }
        }
    };

    // Trà sữa sẽ có 5 options: mang đi hay uống tại chỗ, size (vừa, lớn, siêu lớn), đá (0, 50, 100), đường (0, 30, 70, 100, 120), toppings. 
    class TraSua : IDrink {
        public TraSua(int takeAwayOrForHere) {
            names = new string[5];
            values = new string[5];
            setTakeAwayOrForHere(takeAwayOrForHere);
        }
        public override void drawForm() { }
    };

    // Trà chanh sẽ có 4 options: mang đi hay uống tại chỗ, size (vừa, lớn, siêu lớn), đá (70, 100), đường (50, 70, 100).
    class TraChanh : IDrink {
        public TraChanh(int takeAwayOrForHere) {
            names = new string[4];
            values = new string[4];
            setTakeAwayOrForHere(takeAwayOrForHere);
        }
        public override void drawForm() { }
    }

    // Trà đào sẽ có 4 options: mang đi hay uống tại chỗ, size (vừa, lớn, siêu lớn), đá (70, 100), có đào hay không.
    class TraDao : IDrink {
        public TraDao(int takeAwayOrForHere) {
            names = new string[4];
            values = new string[4];
            setTakeAwayOrForHere(takeAwayOrForHere);
        }
        public override void drawForm() { }
    }

    // Cà phê sẽ có 4 options: mang đi hay uống tại chỗ, size (vừa, lớn), nóng hay lạnh, đường (0, 30, 70, 100), sữa hay không.
    class CaPhe : IDrink {
        public CaPhe(int takeAwayOrForHere) {
            names = new string[4];
            values = new string[4];
            setTakeAwayOrForHere(takeAwayOrForHere);
        }
        public override void drawForm() { }
    }

    // Hồng trà sẽ có 5 options: mang đi hay uống tại chỗ, size (vừa, lớn, siêu lớn), đá (0, 30, 50, 100), đường (0, 30, 70, 100), toppings.
    class HongTra : IDrink {
        public HongTra(int takeAwayOrForHere) {
            names = new string[5];
            values = new string[5];
            setTakeAwayOrForHere(takeAwayOrForHere);
        }
        public override void drawForm() { }
    }
}
