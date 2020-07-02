namespace Kontragent
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.battonMenager = new System.Windows.Forms.Button();
            this.battonFizL = new System.Windows.Forms.Button();
            this.battonYourL = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // battonMenager
            // 
            this.battonMenager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.battonMenager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.battonMenager.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.battonMenager.ForeColor = System.Drawing.Color.Black;
            this.battonMenager.Location = new System.Drawing.Point(33, 150);
            this.battonMenager.Name = "battonMenager";
            this.battonMenager.Size = new System.Drawing.Size(220, 40);
            this.battonMenager.TabIndex = 5;
            this.battonMenager.Text = "Менеджер";
            this.battonMenager.UseVisualStyleBackColor = false;
            this.battonMenager.Click += new System.EventHandler(this.battonMenager_Click);
            // 
            // battonFizL
            // 
            this.battonFizL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.battonFizL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.battonFizL.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.battonFizL.ForeColor = System.Drawing.Color.Black;
            this.battonFizL.Location = new System.Drawing.Point(33, 282);
            this.battonFizL.Name = "battonFizL";
            this.battonFizL.Size = new System.Drawing.Size(220, 40);
            this.battonFizL.TabIndex = 4;
            this.battonFizL.Text = "Физическое лицо";
            this.battonFizL.UseVisualStyleBackColor = false;
            this.battonFizL.Click += new System.EventHandler(this.battonFizL_Click);
            // 
            // battonYourL
            // 
            this.battonYourL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.battonYourL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.battonYourL.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.battonYourL.ForeColor = System.Drawing.Color.Black;
            this.battonYourL.Location = new System.Drawing.Point(33, 215);
            this.battonYourL.Name = "battonYourL";
            this.battonYourL.Size = new System.Drawing.Size(220, 40);
            this.battonYourL.TabIndex = 3;
            this.battonYourL.Text = "Юридическое лицо";
            this.battonYourL.UseVisualStyleBackColor = false;
            this.battonYourL.Click += new System.EventHandler(this.battonYourL_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kontragent.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(287, 347);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.battonMenager);
            this.Controls.Add(this.battonFizL);
            this.Controls.Add(this.battonYourL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button battonMenager;
        private System.Windows.Forms.Button battonFizL;
        private System.Windows.Forms.Button battonYourL;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}