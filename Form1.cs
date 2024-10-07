using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color color = new Color();
        #region TextChanged
        private void HexCode_TextChanged(object sender, EventArgs e)
        {
            HexCode.SelectionStart = HexCode.Text.Length;
            if(HexCode.Text.Length == 6)
            {
                string rgb_res = color.HexToRGB(HexCode.Text);
                string[] RGB = rgb_res.Split(',');
                G.Text = RGB[1];
                B.Text = RGB[2];
                R.Text = RGB[0];
                G.Text = RGB[1];
                B.Text = RGB[2];
                R.Text = RGB[0];
                int r = int.Parse(R.Text);
                int g = int.Parse(G.Text);
                int b = int.Parse(B.Text);
                string[] CMYK = color.RGBToCMYK(r, g, b).Split(',');
                C.Text = CMYK[0];
                M.Text = CMYK[1];
                Y.Text = CMYK[2];
                K.Text = CMYK[3];
                string[] HSL = color.RGBToHSL(r, g, b).Split(',');
                H.Text = HSL[0];
                S.Text = HSL[1];
                L.Text = HSL[2];
            }
            else
            {
                R.Text = G.Text = B.Text = C.Text = M.Text = Y.Text = K.Text = H.Text = S.Text = L.Text = String.Empty;
            }    
        }
        private void RGB_TextChanged(object sender, EventArgs e)
        {
            if (R.Text != String.Empty && G.Text != String.Empty && B.Text != String.Empty)
            {
                int r = int.Parse(R.Text);
                int g = int.Parse(G.Text);
                int b = int.Parse(B.Text);
                string Hex = color.RGBToHex(r, g, b);
                HexCode.Text = Hex;
                string[] CMYK = color.RGBToCMYK(r, g, b).Split(',');
                C.Text = CMYK[0];
                M.Text = CMYK[1];
                Y.Text = CMYK[2];
                K.Text = CMYK[3];
            }
            if (R.Text == String.Empty && G.Text == String.Empty && B.Text == String.Empty)
            {
                HexCode.Text = C.Text = M.Text = Y.Text = K.Text = String.Empty;
            }

        }
        #endregion
        #region KeyPress
        private void HexCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                if ((e.KeyChar < 'A' || e.KeyChar > 'F') && (e.KeyChar < 'a' || e.KeyChar > 'f')) e.Handled = true;
            }
        }
        private void RGB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
            TextBox box = sender as TextBox;
            if(box.Text!=string.Empty)
            {
                if (box.Text=="0")
                {
                    box.Text = e.KeyChar.ToString();
                    box.SelectionStart = box.Text.Length;
                    e.Handled = true;
                }    
                string number = String.Empty;
                if (e.KeyChar>='0'&&e.KeyChar<='9') number = box.Text + e.KeyChar;
                else number = box.Text; 
                int n = int.Parse(number);
                if (n > 255) e.Handled = true;
                
            }    
        }
        private void CMYK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
            TextBox box = sender as TextBox;
            if (box.Text != string.Empty)
            {
                if (box.Text == "0")
                {
                    box.Text = e.KeyChar.ToString();
                    box.SelectionStart = box.Text.Length;
                    e.Handled = true;
                }
                string number = String.Empty;
                if (e.KeyChar >= '0' && e.KeyChar <= '9') number = box.Text + e.KeyChar;
                else number = box.Text;
                int n = int.Parse(number);
                if (n > 100) e.Handled = true;
            }
        }
        #endregion
    }
}