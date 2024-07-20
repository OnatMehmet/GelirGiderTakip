using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GelirGiderTakip
{
    public partial class frmGelirGider : Form
    {
        public frmGelirGider()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            radGelir.Enabled = true;
            dgv_Update();
            cmbOdemTipi.DataSource = genel.sql.Table("SELECT Id, OdemeAd FROM OdemeTipleri");
            cmbOdemTipi.DisplayMember = "OdemeAd";
            cmbOdemTipi.ValueMember = "Id";
            cmbOdemeTipiSor.DataSource = genel.sql.Table("SELECT Id, OdemeAd FROM OdemeTipleri");
            cmbOdemeTipiSor.DisplayMember = "OdemeAd";
            cmbOdemeTipiSor.ValueMember = "Id";
        }
        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            //else if (Char.IsWhiteSpace(e.KeyChar))
            //{
            //    e.Handled = true; //Boşluk engelleme
            //}
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string tip = "";
            if (radGelir.Checked == true)
            {
                tip = "Gelir";

            }
            if (radGider.Checked == true)
            {
                tip = "Gider";
            }

            if (txtCari.Text == "" || txtCari.Text == null)
            {
                MessageBox.Show("Cari Alanı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (Convert.ToInt32(txtTutar.Text) == 0)
            {
                MessageBox.Show("Tutar 0 olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (Convert.ToInt32(txtId.Text) == 0)
            {
                genel.sql.Command(""
                 + "   INSERT INTO[dbo].[GelirGiderKayitlar]"
                 + "       ([Tarih], [IslemTipi], [Cari], [Tutar] , [Aciklama], [KayitTarih], [Tipi], [OdemeTipi]) "
                 + "   VALUES                               "
                 + "       ('" + Convert.ToDateTime(dtTarih.Value).ToString("yyyMMdd HH:mm:ss") + "'  "
                 + "       ,'" + tip + "'  "
                 + "       ,'" + txtCari.Text + "'  "
                 + "       ,'" + Convert.ToDouble(txtTutar.Text).ToString().Replace(",", ".") + "'  "
                 + "       ,'" + txtAciklama.Text + "'  "
                 + "       ,getdate() "
                 + "       ,'" + cmbTipi.Text + "'  "
                 + "        ,'" + cmbOdemTipi.Text + "' "
                 + ")   "
                 );

                MessageBox.Show("Kayıt İşlemi Başarılı");
            }
            else
            {
                genel.sql.Command(""
                 + "   UPDATE [dbo].[GelirGiderKayitlar] SET "
                 + "     [Tarih]       = '" + Convert.ToDateTime(dtTarih.Value).ToString("yyyMMdd HH:mm") + "'"
                 + "   , [IslemTipi]   = '" + tip + "'  "
                 + "   , [Cari]        = '" + txtCari.Text + "' "
                 + "   , [Tutar]       = '" + Convert.ToDouble(txtTutar.Text).ToString().Replace(",", ".") + "'"
                 + "   , [Aciklama]    = '" + txtAciklama.Text + "'"
                 + "   , [KayitTarih]  = getdate() "
                 + "   , [Tipi]  = '" + cmbTipi.Text + "'"
                 + "   , [OdemeTipi] = '" + cmbOdemTipi.Text + "' "
                 + "   WHERE  Id = " + Convert.ToInt32(txtId.Text) + ""

                );
                MessageBox.Show("Güncelleme İşlemi Başarılı");
            }

            dgv_Update();
            clear();
        }

        void dgv_Update()
        {
            dataGridView1.DataSource = genel.sql.Table("select Id AS [Kayıt No], Tarih, IslemTipi AS [İşlem Tipi] ,Cari, Tutar, OdemeTipi AS [Ödeme Tipi], Aciklama AS [Açıklama], KayitTarih AS [Kayıt Tarihi ] from dbo.GelirGiderKayitlar");
        }

        private void radGelir_CheckedChanged(object sender, EventArgs e)
        {
            if (radGelir.Checked)
            {
                cmbTipi.DataSource = genel.sql.Table("SELECT  GelirAdi, GelirKodu from GelirTipleri");
                cmbTipi.DisplayMember = "GelirAdi";
                cmbTipi.ValueMember = "GelirKodu";
            }
        }

        private void radGider_CheckedChanged(object sender, EventArgs e)
        {
            if (radGider.Checked)
            {
                cmbTipi.DataSource = genel.sql.Table("SELECT  GiderAdi, GiderKodu from GiderTipleri");
                cmbTipi.DisplayMember = "GiderAdi";
                cmbTipi.ValueMember = "GiderKodu";
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void clear()
        {
            txtTutar.Text = "0";
            txtAciklama.Text = "";
            txtCari.Text = "";
            txtId.Text = "0";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                if (row != null)
                {
                    txtId.Text = row.Cells["Id"].Value.ToString();

                    string islemTip = row.Cells["IslemTipi"].Value.ToString();
                    switch (islemTip)
                    {
                        case "Gelir":
                            radGelir.Checked = true; break;
                        case "Gider":
                            radGider.Checked = true; break;
                    }

                    dtTarih.Text = row.Cells["Tarih"].Value.ToString();
                    cmbTipi.Text = row.Cells["Tipi"].Value.ToString();
                    txtCari.Text = row.Cells["Cari"].Value.ToString();
                    txtTutar.Text = row.Cells["Tutar"].Value.ToString();
                    txtAciklama.Text = row.Cells["Aciklama"].Value.ToString();
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            lblNakitSonuc.Text = "0";
            lblKrediSonuc.Text = "0";
            string sql = "SELECT * FROM [dbo].[GelirGiderKayitlar] WHERE ";
            string sonuc = "SELECT SUM(Tutar) FROM[dbo].[GelirGiderKayitlar] WHERE ";
            bool tarih = false;
            if (dtTarih.Text.Length > 0 && dtTarih2.Text.Length > 0)
            {
                tarih = true;
                sql += " Tarih >= "
                     + " '" + Convert.ToDateTime(dtTarih1.Value).ToString("yyyMMdd 00:00:00") + "' AND  Tarih <="
                     + " '" + Convert.ToDateTime(dtTarih2.Value).ToString("yyyMMdd 23:59:59") + "' ";

                sonuc += " Tarih >= "
                     + " '" + Convert.ToDateTime(dtTarih1.Value).ToString("yyyMMdd 00:00:00") + "' AND  Tarih <="
                     + " '" + Convert.ToDateTime(dtTarih2.Value).ToString("yyyMMdd 23:59:59") + "' ";
            }
            else
            {
                MessageBox.Show("Lütfen Tarih Aralını belirtiniz..");
                return;
            }

            if (!string.IsNullOrEmpty(cmbOdemeTipiSor.Text))
            {
                if (tarih == true)
                    sql += " AND ";
                sql += " OdemeTipi =  '" + cmbOdemeTipiSor.Text + "'";
            }


            dataGridView1.DataSource = genel.sql.Table(sql);
            if (cmbOdemeTipiSor.Text == "Nakit")
            {
                if (tarih == true)
                    sonuc += " AND ";
                sonuc += " OdemeTipi =  '" + cmbOdemeTipiSor.Text + "'";

                lblNakitSonuc.Text = genel.sql.Command(sonuc).ToString();
                _ = lblNakitSonuc.Text != "" ? lblNakitSonuc.Text : lblNakitSonuc.Text = "0";

            }
            if (cmbOdemeTipiSor.Text == "Kredi")
            {
                if (tarih == true)
                    sonuc += " AND ";
                sonuc += " OdemeTipi =  '" + cmbOdemeTipiSor.Text + "'";
                lblKrediSonuc.Text = genel.sql.Command(sonuc).ToString();
                _ = lblKrediSonuc.Text != "" ? lblKrediSonuc.Text : lblKrediSonuc.Text = "0";
            }

            lblGelirToplamSonuc.Text = genel.sql.Command(sonuc + " AND IslemTipi = 'Gelir'").ToString();
            lblGiderToplamSonuc.Text = genel.sql.Command(sonuc + " AND IslemTipi = 'Gider'").ToString();
            _ = lblGelirToplamSonuc.Text != "" ? lblGelirToplamSonuc.Text : lblGelirToplamSonuc.Text = "0";
            _ = lblGiderToplamSonuc.Text != "" ? lblGiderToplamSonuc.Text : lblGiderToplamSonuc.Text = "0";

            lblToplamSonuc.Text = (Convert.ToInt32(lblGelirToplamSonuc.Text != "" ? lblGelirToplamSonuc.Text : "0") - Convert.ToInt32(lblGiderToplamSonuc.Text != "" ? lblGiderToplamSonuc.Text : "0")).ToString();
        }

    }
}
