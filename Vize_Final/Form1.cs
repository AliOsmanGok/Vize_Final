using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vize_Final
{
    public partial class FormNot : Form
    {
        //bool durum = true;
        string gk = "Geçti";
        TextBox textBoxBut;
        Label labelBut;

        public FormNot()
        {
            InitializeComponent();
        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            double vize=0, final=0, but=0, ort=0;
            string harf="";
            
            vize = Convert.ToDouble(textBoxVize.Text);

            //final = Convert.ToDouble(textBoxFinal.Text);

            //ort = vize * 0.4 + final * 0.6;

            if (gk == "Geçti")
            //if (durum == true)
            {
                final = Convert.ToDouble(textBoxFinal.Text);
                ort = vize * 0.4 + final * 0.6;
            }
            else
            {
                but = Convert.ToDouble(textBoxBut.Text);
                ort = vize * 0.4 + but * 0.6;
            }                               

            //MessageBox.Show("Ortalamanız: " + ort.ToString());
            
            if ((vize <= 100 && vize >=0) && (final <= 100 && final >=0))         
            //if (ort >= 0 && ort <= 100)
            {
                if (ort >= 82)
                {
                    harf = "AA";
                    gk = "Geçti";
                }
                else if (ort >= 74)
                {
                    harf = "BA";
                    gk = "Geçti";
                }
                else if (ort >= 65)
                {
                    harf = "BB";
                    gk = "Geçti";
                }
                else if (ort >= 58)
                {
                    harf = "CB";
                    gk = "Geçti";
                }
                else if (ort >= 50)
                {
                    harf = "CC";
                    gk = "Geçti";
                }
                else if (ort >= 40)
                {
                    harf = "DC";
                    gk = "Kaldı";
                    //durum = false;
                }
                else if (ort >= 35)
                {
                    harf = "DD";
                    gk = "Kaldı";
                    //durum = false;
                }
                else if (ort >= 25)
                {
                    harf = "FD";
                    gk = "Kaldı";
                    //durum = false;
                }
                else 
                {
                    harf = "FF";
                    gk = "Kaldı";
                    //durum = false;
                }             
            MessageBox.Show(gk + " Notunuz: " + harf);
            }
            else
            {
                MessageBox.Show("HATALI DEĞER GİRDİNİZ!");
            }

            if (gk == "Kaldı")
            //if (durum == false)
            {
                //Bütünleme için yeni label ve textbox oluşturulacak

                labelBut = new Label();             // YENİ BİR LABEL TÜRETİLDİ
                this.Controls.Add(labelBut);        // YENİ LABEL FORMA EKLENDİ

                labelBut.Text = "Bütünleme Notu:";
                labelBut.Left = 37;
                labelBut.Top = 85;
                labelBut.Width = 58;
                labelBut.Height = 13;
                labelBut.BackColor = Color.Blue;
                labelBut.ForeColor = Color.Yellow;


                textBoxBut = new TextBox();       // YENİ BİR TEXTBOX TÜRETİLDİ
                this.Controls.Add(textBoxBut);      // YENİ TEXTBOX FORMA EKLENDİ

                textBoxBut.Left = 135;
                textBoxBut.Top = 81;
                textBoxBut.BackColor = Color.Green;
                textBoxBut.ForeColor = Color.White;
                textBoxBut.RightToLeft = RightToLeft.Yes;

                textBoxFinal.Visible = false;
                labelFinal.Visible = false;
            }
        }
    }
}
