using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_CheckBoxInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedBoxListDoldur();
        }

        private void checkedBoxListDoldur()
        {
            foreach (var item in database.UrunTablo)
            {
                checkedListBox.Items.Add(item);
            }
        }

        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedList = (CheckedListBox)sender;
            if (e.NewValue == CheckState.Checked)
            {
                Urun secilenUrun = checkedListBox.Items[e.Index] as Urun;
                pctUrunResim.Image = Image.FromFile(secilenUrun.urunResim);
                txturunadi.Text = secilenUrun.urunAdi;
                txturunkategori.Text = secilenUrun.urunKategori;
                txtstokadeti.Text = secilenUrun.stokAdet.ToString();
                txtacıklama.Text = secilenUrun.aciklama;
                txtyazar.Text = secilenUrun.yazar;
            }
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (i == e.Index)
                {
                    //Üzerinde bulunan kayıt
                }
                else
                {
                    checkedListBox.SetItemChecked(i, false);
                }
            }
        }
    }
}
