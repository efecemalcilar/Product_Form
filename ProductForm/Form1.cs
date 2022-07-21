using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductForm.Entity;

namespace ProductForm
{
    public partial class Form1 : Form
    {
        private readonly ProductDBContext _db = new ProductDBContext();
        private int selectedid = -1;
        private Product findData;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listing();
        }

        private List<Product> allPros;
        private void Listing()
        {
            Liste.Rows.Clear();
            int i = 0;
            allPros = _db.Products.ToList();
            
            foreach (var item in allPros)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = item.UrunAdi;
                Liste.Rows[i].Cells[1].Value = item.Fiyat;
                Liste.Rows[i].Cells[2].Value = item.UreticiAdi;
                Liste.Rows[i].Cells[4].Value = item.Id;

                if (item.Category != null)
                {
                    Liste.Rows[i].Cells[3].Value = item.Category.KategoriAdi;
                }

                i++;

            }

            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;

        }

        private void ComboDoldur()
        {
            comboBox1.DataSource = _db.Categories.ToList();
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "KategoriAdi";
            comboBox1.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (TxtUrunAdi.Text == "" || TxtFiyat.Text=="" || TxtUretici.Text=="")
            {
                MessageBox.Show("Boş Alan Bırakılamaz!");
                return;
            }
           
            Product Product = new Product();

            Product.UrunAdi = TxtUrunAdi.Text;
            Product.Fiyat = Convert.ToDouble(TxtFiyat.Text);
            Product.UreticiAdi = TxtUretici.Text;
            if (comboBox1.SelectedValue != null)
            {
                Product.KategoriId = (int) comboBox1.SelectedValue;
            }

            _db.Products.Add(Product);
            _db.SaveChanges();
            FormuTemizle();
            Listing();
            MessageBox.Show("Ürün Başarıyla Eklendi!");
        }

        private void FormuTemizle()
        {
            foreach (Control k in spcUrunKayit.Panel1.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox || k is RichTextBox)
                {
                    k.Text = "";
                }

                comboBox1.SelectedIndex = -1;



            }

        }

        private void CAdd_Click(object sender, EventArgs e)
        {
            if (CName.Text == "")
            {
                MessageBox.Show("Kategori Adı Boş Olamaz!");
                return;
            }
            Category category = new Category();
            category.KategoriAdi = CName.Text;
            _db.Categories.Add(category);
            _db.SaveChanges();
            ComboDoldur();
            MessageBox.Show("Kategori Başarıyla Eklendi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (selectedid < 0)
            {
                MessageBox.Show("Lütfen geçerli bir kayıt seçiniz!");
                return;
            }

            if (findData != null)
            {
                findData.UrunAdi = TxtUrunAdi.Text;
                if (comboBox1.SelectedValue!=null)
                {
                    findData.KategoriId= Convert.ToInt32(comboBox1.SelectedValue);
                }

                findData.Fiyat = Convert.ToDouble(TxtFiyat.Text);
            }

            _db.SaveChanges();
            MessageBox.Show("Güncelleme Yapıldı.");
            FormuTemizle();
            Listing();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null) selectedid = (int)Liste.CurrentRow.Cells[4].Value;
            Open(selectedid);
        }

        private void Open(int id)
        {
            selectedid = id;
            if (selectedid<0)
            {
                MessageBox.Show("Kayit Bulunamadi");
                return;
            }

            findData = allPros.FirstOrDefault(x => x.Id == selectedid);
            if (findData!=null)
            {
                TxtUrunAdi.Text = findData.UrunAdi;
                TxtFiyat.Text = Convert.ToString(findData.Fiyat);
                TxtUretici.Text = findData.UreticiAdi;
                comboBox1.Text = findData.Category.KategoriAdi;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (selectedid > 0)
            {
                _db.Products.Remove(findData);
                _db.SaveChanges();
                MessageBox.Show("Kayit Silindi!");
                FormuTemizle();
                Listing();
            }
        }
    }
}
