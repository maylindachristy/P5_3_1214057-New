using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_3_1214057
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void tsbMouse_Click_1(object sender, EventArgs e)
        {

        }

        private void tsbMouse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMouse.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah gambar Mouse";
            }
            else
            {
                tslKetGambar.Text = "Tidak Cocok! Anda memilih gambar yang salah\nIni adalah gambar Mouse";
            }
        }

        private void tsbMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMouse.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah gambar Mouse";
            }
            else
            {
                tslKetGambar.Text = "Tidak Cocok! Anda memilih gambar yang salah\nIni adalah gambar Mouse";
            }
        }

        private void tsbPrinter_CheckedChanged(object sender, EventArgs e)
        {
            if (tsbPrinter.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah gambar Printer";
            }
            else
            {
                tslKetGambar.Text = "Tidak Cocok! Anda memilih gambar yang salah\nIni adalah gambar Printer";
            }
        }

        private void tsbKeyboard_CheckedChanged(object sender, EventArgs e)
        {
            if (tsbKeyboard.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah gambar Keyboard";
            }
            else
            {
                tslKetGambar.Text = "Tidak Cocok! Anda memilih gambar yang salah\nIni adalah gambar keyboard";
            }
        }
    }
}
