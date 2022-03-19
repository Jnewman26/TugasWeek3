using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasWeek2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonProses_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.ToLower() == "hide") // cek text input apakah isi nya hide
            {
                labelOutput.Hide();
            }
            else if (textBoxInput.Text.ToLower() == "shown") // cek text input apakah isinya shown
            {
                labelOutput.Show();
            }
            else
            {
                string hapus = "isi:";
                string warna = "warna:";
                string biru = "biru";
                string merah = "merah";
                string hijau = "hijau";
                string hitam = "default";
                string restart = "[EMPTY]";
                if (textBoxInput.Text.ToLower().Contains(hapus)) // cek apakah mengandung isi:
                {
                    labelOutput.Text = textBoxInput.Text.Remove(textBoxInput.Text.ToLower().IndexOf(hapus), hapus.Length);
                    // ini label yg mau diganti = input.text
                }
                else if (textBoxInput.Text.ToLower().Contains(warna))
                {
                    string color = textBoxInput.Text.Remove(textBoxInput.Text.IndexOf(warna), warna.Length);
                    if (color.ToLower().Contains(biru))
                    {
                        labelOutput.ForeColor = Color.Blue; // ini buat ganti warna
                    }
                    if (color.ToLower().Contains(merah))
                    {
                        labelOutput.ForeColor = Color.Red; // ini buat ganti warna
                    }
                    if (color.ToLower().Contains(hijau))
                    {
                        labelOutput.ForeColor = Color.Green; // ini buat ganti warna
                    }
                    if (color.ToLower().Contains(hitam))
                    {
                        labelOutput.ForeColor = Color.Black; // ini buat ganti warna
                    }
                }
                else if (textBoxInput.Text == "besarkan")
                {
                    labelOutput.Font = new Font("Microsoft San Serif", labelOutput.Font.Size + 1);
                }
                else if (textBoxInput.Text == "kecilkan")
                {
                    labelOutput.Font = new Font("microsoft san serif", labelOutput.Font.Size - 1);
                }
                else if (textBoxInput.Text.ToLower() == "restart")
                {
                    labelOutput.Text = restart;
                    labelOutput.ForeColor = Color.Black;
                    labelOutput.Font = new Font("microsoft san serif", 14);
                }
                else
                {
                    MessageBox.Show("Syntax tidak ditemukan");
                }
            }
        }
    }
}
