using LibraryManagement.Win.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Win
{
    public partial class FrmYazarlar : Form
    {
        libraryContext context;
        int id = 0;
        public FrmYazarlar()
        {
            InitializeComponent();
            context = new libraryContext();
            btnAddNew.Click += BtnAddNew_Click;
            btnDelete.Click += BtnDelete_Click;
            btnEdit.Click += BtnEdit_Click;
            btnAra.Click += BtnAra_Click;
            this.Load += FrmYazarlar_Load;
            this.dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            veriGetir(txtAra.Text);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Tbwriter writer = context.Tbwriter.Find(id);
            writer.Person.Name = dataGridView1.SelectedRows[0].Cells["name"].Value.ToString();
            writer.Person.Surname = dataGridView1.SelectedRows[0].Cells["surname"].Value.ToString();
            context.SaveChanges();
            veriGetir();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Tbwriter writer = context.Tbwriter.Find(id);
            context.Tbwriter.Remove(writer);
            context.SaveChanges();
            id = 0;
            txtAd.Clear();
            txtSoyad.Clear();
            richTextBox1.Clear();
            veriGetir();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
                return;
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            txtAd.Text = dataGridView1.SelectedRows[0].Cells["name"].Value.ToString();
            txtSoyad.Text = dataGridView1.SelectedRows[0].Cells["surname"].Value.ToString();

        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            if(btnAddNew.Text.Contains("Yeni"))
            {
                id = 0;
                btnAddNew.Text = "Ekle";
                txtAd.Clear();
                txtSoyad.Clear();
                richTextBox1.Clear();
            } else
            {
                if(txtAd.Text.Trim() == "" || txtSoyad.Text.Trim() == "")
                {
                    MessageBox.Show("Ad Soyad Bilgisi Eksik");
                    return;
                }
                Tbwriter writer = new Tbwriter()
                {
                    Person = new Tbperson()
                    {
                        Name = txtAd.Text.Trim(),
                        Surname = txtSoyad.Text.Trim(),
                    },
                    Biography = richTextBox1.Text
                };
                writer.PersonId = writer.Person.Id;

                context.Tbwriter.Add(writer);
                context.SaveChanges();
                btnAddNew.Text = "Yeni Kayıt";
                veriGetir();
                id = writer.Id;
            }
        }

        private void FrmYazarlar_Load(object sender, EventArgs e)
        {
            veriGetir();
        }
        void veriGetir()
        {
            var data = (from s in context.Tbwriter
                        select new
                        {
                            s.Id,
                            s.Person.Name,
                            s.Person.Surname,
                            s.Biography,
                        }).ToList();

            dataGridView1.DataSource = data;
        }
        void veriGetir(string key)
        {
            var data = (from s in context.Tbwriter
                        select new
                        {
                            s.Id,
                            s.Person.Name,
                            s.Person.Surname,
                            s.Biography,
                        }).ToList();
            data = data.Where(x => x.Name.Contains(key) || x.Surname.Contains(key)).ToList();

            dataGridView1.DataSource = data;
        }
    }
}
