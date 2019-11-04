namespace Meme_Rewind_2018_2019
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
            this.outputMain = new System.Windows.Forms.Label();
            this.buttYell = new System.Windows.Forms.Label();
            this.buttRed = new System.Windows.Forms.Label();
            this.buttBlue = new System.Windows.Forms.Label();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // outputMain
            // 
            this.outputMain.BackColor = System.Drawing.Color.Firebrick;
            this.outputMain.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputMain.ForeColor = System.Drawing.Color.White;
            this.outputMain.Location = new System.Drawing.Point(33, 38);
            this.outputMain.Name = "outputMain";
            this.outputMain.Size = new System.Drawing.Size(1190, 725);
            this.outputMain.TabIndex = 13;
            this.outputMain.Text = "Story Box";
            // 
            // buttYell
            // 
            this.buttYell.BackColor = System.Drawing.Color.Goldenrod;
            this.buttYell.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttYell.ForeColor = System.Drawing.Color.White;
            this.buttYell.Location = new System.Drawing.Point(33, 811);
            this.buttYell.Name = "buttYell";
            this.buttYell.Size = new System.Drawing.Size(2227, 52);
            this.buttYell.TabIndex = 15;
            this.buttYell.Text = "Button 1";
            // 
            // buttRed
            // 
            this.buttRed.BackColor = System.Drawing.Color.LightCoral;
            this.buttRed.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttRed.ForeColor = System.Drawing.Color.White;
            this.buttRed.Location = new System.Drawing.Point(33, 958);
            this.buttRed.Name = "buttRed";
            this.buttRed.Size = new System.Drawing.Size(2227, 52);
            this.buttRed.TabIndex = 16;
            this.buttRed.Text = "Button 3";
            // 
            // buttBlue
            // 
            this.buttBlue.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttBlue.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttBlue.ForeColor = System.Drawing.Color.White;
            this.buttBlue.Location = new System.Drawing.Point(33, 885);
            this.buttBlue.Name = "buttBlue";
            this.buttBlue.Size = new System.Drawing.Size(2227, 52);
            this.buttBlue.TabIndex = 17;
            this.buttBlue.Text = "Button 2";
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Image = global::Meme_Rewind_2018_2019.Properties.Resources.youknow;
            this.pictureBoxMain.Location = new System.Drawing.Point(1269, 38);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(991, 725);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxMain.TabIndex = 18;
            this.pictureBoxMain.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(2308, 1041);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.buttBlue);
            this.Controls.Add(this.buttRed);
            this.Controls.Add(this.buttYell);
            this.Controls.Add(this.outputMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputMain;
        private System.Windows.Forms.Label buttYell;
        private System.Windows.Forms.Label buttRed;
        private System.Windows.Forms.Label buttBlue;
        private System.Windows.Forms.PictureBox pictureBoxMain;
    }
}

