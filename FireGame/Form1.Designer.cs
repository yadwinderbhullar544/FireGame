namespace FireGame
{
    partial class Form1
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
            this.button2 = new System.Windows.Forms.Button();
            this.SpinBtn = new System.Windows.Forms.Button();
            this.RelodBtn = new System.Windows.Forms.Button();
            this.LodBtn = new System.Windows.Forms.Button();
            this.AimBtn = new System.Windows.Forms.Button();
            this.FreBtn = new System.Windows.Forms.Button();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.FreAwy = new FireGame.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(622, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 11);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SpinBtn
            // 
            this.SpinBtn.Enabled = false;
            this.SpinBtn.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpinBtn.ForeColor = System.Drawing.Color.Red;
            this.SpinBtn.Image = global::FireGame.Properties.Resources.hd;
            this.SpinBtn.Location = new System.Drawing.Point(663, 182);
            this.SpinBtn.Name = "SpinBtn";
            this.SpinBtn.Size = new System.Drawing.Size(99, 65);
            this.SpinBtn.TabIndex = 5;
            this.SpinBtn.Text = "Spin";
            this.SpinBtn.UseVisualStyleBackColor = true;
            this.SpinBtn.Click += new System.EventHandler(this.SpinBtn_Click);
            // 
            // RelodBtn
            // 
            this.RelodBtn.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelodBtn.ForeColor = System.Drawing.Color.White;
            this.RelodBtn.Image = global::FireGame.Properties.Resources.re;
            this.RelodBtn.Location = new System.Drawing.Point(355, 340);
            this.RelodBtn.Name = "RelodBtn";
            this.RelodBtn.Size = new System.Drawing.Size(124, 60);
            this.RelodBtn.TabIndex = 4;
            this.RelodBtn.Text = "Reload";
            this.RelodBtn.UseVisualStyleBackColor = true;
            this.RelodBtn.Click += new System.EventHandler(this.RelodBtn_Click);
            // 
            // LodBtn
            // 
            this.LodBtn.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LodBtn.ForeColor = System.Drawing.Color.Red;
            this.LodBtn.Image = global::FireGame.Properties.Resources.hd;
            this.LodBtn.Location = new System.Drawing.Point(562, 182);
            this.LodBtn.Name = "LodBtn";
            this.LodBtn.Size = new System.Drawing.Size(93, 65);
            this.LodBtn.TabIndex = 3;
            this.LodBtn.Text = "Load";
            this.LodBtn.UseVisualStyleBackColor = true;
            this.LodBtn.Click += new System.EventHandler(this.LodBtn_Click);
            // 
            // AimBtn
            // 
            this.AimBtn.Enabled = false;
            this.AimBtn.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AimBtn.ForeColor = System.Drawing.Color.Red;
            this.AimBtn.Image = global::FireGame.Properties.Resources.hd;
            this.AimBtn.Location = new System.Drawing.Point(562, 266);
            this.AimBtn.Name = "AimBtn";
            this.AimBtn.Size = new System.Drawing.Size(93, 59);
            this.AimBtn.TabIndex = 2;
            this.AimBtn.Text = "Aim";
            this.AimBtn.UseVisualStyleBackColor = true;
            this.AimBtn.Click += new System.EventHandler(this.AimBtn_Click);
            // 
            // FreBtn
            // 
            this.FreBtn.Enabled = false;
            this.FreBtn.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FreBtn.ForeColor = System.Drawing.Color.Red;
            this.FreBtn.Image = global::FireGame.Properties.Resources.gunlod;
            this.FreBtn.Location = new System.Drawing.Point(663, 266);
            this.FreBtn.Name = "FreBtn";
            this.FreBtn.Size = new System.Drawing.Size(101, 59);
            this.FreBtn.TabIndex = 0;
            this.FreBtn.Text = "Fire";
            this.FreBtn.UseVisualStyleBackColor = true;
            this.FreBtn.Click += new System.EventHandler(this.FreBtn_Click);
            // 
            // PicBox
            // 
            this.PicBox.Image = global::FireGame.Properties.Resources.ss;
            this.PicBox.Location = new System.Drawing.Point(12, 27);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(794, 396);
            this.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox.TabIndex = 0;
            this.PicBox.TabStop = false;
            // 
            // FreAwy
            // 
            this.FreAwy.Enabled = false;
            this.FreAwy.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FreAwy.ForeColor = System.Drawing.Color.Black;
            this.FreAwy.Image = global::FireGame.Properties.Resources.freawy1;
            this.FreAwy.Location = new System.Drawing.Point(585, 340);
            this.FreAwy.Name = "FreAwy";
            this.FreAwy.Size = new System.Drawing.Size(164, 67);
            this.FreAwy.TabIndex = 7;
            this.FreAwy.Text = "Fire Away";
            this.FreAwy.UseVisualStyleBackColor = true;
            this.FreAwy.Click += new System.EventHandler(this.FreAwy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FreAwy);
            this.Controls.Add(this.SpinBtn);
            this.Controls.Add(this.RelodBtn);
            this.Controls.Add(this.LodBtn);
            this.Controls.Add(this.AimBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FreBtn);
            this.Controls.Add(this.PicBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FreBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AimBtn;
        private System.Windows.Forms.Button LodBtn;
        private System.Windows.Forms.Button RelodBtn;
        private System.Windows.Forms.Button SpinBtn;
        private System.Windows.Forms.PictureBox PicBox;
        private RoundButton FreAwy;
    }
}

