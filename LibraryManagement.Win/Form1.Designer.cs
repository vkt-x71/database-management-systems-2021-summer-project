
namespace LibraryManagement.Win
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarlarVeYayinEvleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarlarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yayınEvleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yayınlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Maroon;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.yazarlarVeYayinEvleriToolStripMenuItem,
            this.yayınlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yazarlarVeYayinEvleriToolStripMenuItem
            // 
            this.yazarlarVeYayinEvleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazarlarToolStripMenuItem1,
            this.yayınEvleriToolStripMenuItem});
            this.yazarlarVeYayinEvleriToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.yazarlarVeYayinEvleriToolStripMenuItem.Name = "yazarlarVeYayinEvleriToolStripMenuItem";
            this.yazarlarVeYayinEvleriToolStripMenuItem.Size = new System.Drawing.Size(261, 29);
            this.yazarlarVeYayinEvleriToolStripMenuItem.Text = "Yazarlar Ve YayYazarların Evleri";
            // 
            // yazarlarToolStripMenuItem1
            // 
            this.yazarlarToolStripMenuItem1.BackColor = System.Drawing.Color.Maroon;
            this.yazarlarToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.yazarlarToolStripMenuItem1.Name = "yazarlarToolStripMenuItem1";
            this.yazarlarToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.yazarlarToolStripMenuItem1.Text = "Yazarlar";
            // 
            // yayınEvleriToolStripMenuItem
            // 
            this.yayınEvleriToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.yayınEvleriToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.yayınEvleriToolStripMenuItem.Name = "yayınEvleriToolStripMenuItem";
            this.yayınEvleriToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.yayınEvleriToolStripMenuItem.Text = "Yayın Evleri";
            // 
            // yayınlarToolStripMenuItem
            // 
            this.yayınlarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.yayınlarToolStripMenuItem.Name = "yayınlarToolStripMenuItem";
            this.yayınlarToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.yayınlarToolStripMenuItem.Text = "Yayınlar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 624);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarlarVeYayinEvleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarlarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yayınEvleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yayınlarToolStripMenuItem;
    }
}

