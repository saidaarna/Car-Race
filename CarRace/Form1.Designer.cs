namespace CarRace
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bluecar = new System.Windows.Forms.PictureBox();
            this.redcar = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.blCKCAR = new System.Windows.Forms.PictureBox();
            this.buttonstart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluecar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redcar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blCKCAR)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CarRace.Properties.Resources.flag;
            this.pictureBox1.Location = new System.Drawing.Point(25, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bluecar
            // 
            this.bluecar.BackColor = System.Drawing.Color.Transparent;
            this.bluecar.Image = global::CarRace.Properties.Resources.i;
            this.bluecar.Location = new System.Drawing.Point(3, 428);
            this.bluecar.Name = "bluecar";
            this.bluecar.Size = new System.Drawing.Size(124, 56);
            this.bluecar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bluecar.TabIndex = 2;
            this.bluecar.TabStop = false;
            // 
            // redcar
            // 
            this.redcar.BackColor = System.Drawing.Color.Transparent;
            this.redcar.Image = global::CarRace.Properties.Resources.porsche_PNG10628;
            this.redcar.Location = new System.Drawing.Point(3, 490);
            this.redcar.Name = "redcar";
            this.redcar.Size = new System.Drawing.Size(108, 49);
            this.redcar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redcar.TabIndex = 3;
            this.redcar.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CarRace.Properties.Resources.linee;
            this.pictureBox6.Location = new System.Drawing.Point(1402, 433);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(44, 185);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // blCKCAR
            // 
            this.blCKCAR.BackColor = System.Drawing.Color.Transparent;
            this.blCKCAR.Image = global::CarRace.Properties.Resources.car_silhouette_side_191;
            this.blCKCAR.Location = new System.Drawing.Point(3, 555);
            this.blCKCAR.Name = "blCKCAR";
            this.blCKCAR.Size = new System.Drawing.Size(108, 63);
            this.blCKCAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blCKCAR.TabIndex = 6;
            this.blCKCAR.TabStop = false;
            // 
            // buttonstart
            // 
            this.buttonstart.BackColor = System.Drawing.Color.Red;
            this.buttonstart.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonstart.ForeColor = System.Drawing.Color.White;
            this.buttonstart.Location = new System.Drawing.Point(12, 12);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(197, 83);
            this.buttonstart.TabIndex = 7;
            this.buttonstart.Text = "Başla";
            this.buttonstart.UseVisualStyleBackColor = false;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRace.Properties.Resources.original_79ae512fddef5f5c6352103e2b02f2b2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1458, 700);
            this.Controls.Add(this.buttonstart);
            this.Controls.Add(this.blCKCAR);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.redcar);
            this.Controls.Add(this.bluecar);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1476, 747);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1476, 747);
            this.Name = "Form1";
            this.Text = "Race";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluecar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redcar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blCKCAR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox blCKCAR;
        private System.Windows.Forms.PictureBox bluecar;
        private System.Windows.Forms.PictureBox redcar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button buttonstart;
    }
}

