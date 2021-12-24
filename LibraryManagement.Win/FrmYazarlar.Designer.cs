
namespace LibraryManagement.Win
{
    partial class FrmYazarlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(826, 189);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı";
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.Black;
            this.txtAd.ForeColor = System.Drawing.Color.White;
            this.txtAd.Location = new System.Drawing.Point(95, 85);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(214, 29);
            this.txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.Black;
            this.txtSoyad.ForeColor = System.Drawing.Color.White;
            this.txtSoyad.Location = new System.Drawing.Point(95, 129);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(214, 29);
            this.txtSoyad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hayatı";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(95, 174);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(620, 78);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(736, 238);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 29);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Black;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(736, 204);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 29);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Black;
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(736, 166);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(101, 29);
            this.btnAddNew.TabIndex = 9;
            this.btnAddNew.Text = "Yeni Kayıt";
            this.btnAddNew.UseVisualStyleBackColor = false;
            // 
            // txtAra
            // 
            this.txtAra.BackColor = System.Drawing.Color.Black;
            this.txtAra.ForeColor = System.Drawing.Color.White;
            this.txtAra.Location = new System.Drawing.Point(501, 25);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(214, 29);
            this.txtAra.TabIndex = 10;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Black;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(736, 23);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(101, 29);
            this.btnAra.TabIndex = 11;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Black;
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(843, 280);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(226, 187);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "";
            // 
            // FrmYazarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1086, 479);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmYazarlar";
            this.Text = "FrmYazarlar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.RichTextBox lblInfo;
    }
}