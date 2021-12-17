namespace SLep
{
    partial class Form2
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
            this.backgr = new System.Windows.Forms.Button();
            this.doubleclick = new System.Windows.Forms.Button();
            this.autoclick = new System.Windows.Forms.Button();
            this.skin = new System.Windows.Forms.Button();
            this.clse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgr
            // 
            this.backgr.BackColor = System.Drawing.Color.White;
            this.backgr.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backgr.Location = new System.Drawing.Point(42, 318);
            this.backgr.Name = "backgr";
            this.backgr.Size = new System.Drawing.Size(240, 62);
            this.backgr.TabIndex = 15;
            this.backgr.Text = "NEW BACKGROUND / 150 coins";
            this.backgr.UseVisualStyleBackColor = false;
            this.backgr.Click += new System.EventHandler(this.backgr_Click);
            // 
            // doubleclick
            // 
            this.doubleclick.BackColor = System.Drawing.Color.White;
            this.doubleclick.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doubleclick.Location = new System.Drawing.Point(42, 192);
            this.doubleclick.Name = "doubleclick";
            this.doubleclick.Size = new System.Drawing.Size(240, 65);
            this.doubleclick.TabIndex = 14;
            this.doubleclick.Text = "CLICK X1000 / 300 coins";
            this.doubleclick.UseVisualStyleBackColor = false;
            this.doubleclick.Click += new System.EventHandler(this.doubleclick_Click);
            // 
            // autoclick
            // 
            this.autoclick.BackColor = System.Drawing.Color.White;
            this.autoclick.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoclick.Location = new System.Drawing.Point(42, 107);
            this.autoclick.Name = "autoclick";
            this.autoclick.Size = new System.Drawing.Size(240, 35);
            this.autoclick.TabIndex = 13;
            this.autoclick.Text = "AUTOCLICK / 30 coins";
            this.autoclick.UseVisualStyleBackColor = false;
            this.autoclick.Click += new System.EventHandler(this.autoclick_Click);
            // 
            // skin
            // 
            this.skin.BackColor = System.Drawing.Color.White;
            this.skin.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skin.Location = new System.Drawing.Point(42, 22);
            this.skin.Name = "skin";
            this.skin.Size = new System.Drawing.Size(240, 40);
            this.skin.TabIndex = 12;
            this.skin.Text = "NEW SKIN / 50 coins";
            this.skin.UseVisualStyleBackColor = false;
            this.skin.Click += new System.EventHandler(this.skin_Click);
            // 
            // clse
            // 
            this.clse.BackColor = System.Drawing.Color.White;
            this.clse.Location = new System.Drawing.Point(267, 421);
            this.clse.Name = "clse";
            this.clse.Size = new System.Drawing.Size(56, 29);
            this.clse.TabIndex = 22;
            this.clse.Text = "close";
            this.clse.UseVisualStyleBackColor = false;
            this.clse.Click += new System.EventHandler(this.clse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 450);
            this.Controls.Add(this.clse);
            this.Controls.Add(this.backgr);
            this.Controls.Add(this.doubleclick);
            this.Controls.Add(this.autoclick);
            this.Controls.Add(this.skin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button backgr;
        private System.Windows.Forms.Button doubleclick;
        private System.Windows.Forms.Button autoclick;
        private System.Windows.Forms.Button skin;
        private System.Windows.Forms.Button clse;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}