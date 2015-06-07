namespace dbFontAwesome.Test
{
    partial class frmExample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExample));
            this.pictureBoxFontAwesome2 = new dbFontAwesome.Test.PictureBoxFontAwesome();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFontAwesome2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFontAwesome2
            // 
            this.pictureBoxFontAwesome2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFontAwesome2.IconImage = dbFontAwesome.IconType.Language;
            this.pictureBoxFontAwesome2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFontAwesome2.Image")));
            this.pictureBoxFontAwesome2.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFontAwesome2.Name = "pictureBoxFontAwesome2";
            this.pictureBoxFontAwesome2.Size = new System.Drawing.Size(247, 222);
            this.pictureBoxFontAwesome2.TabIndex = 0;
            this.pictureBoxFontAwesome2.TabStop = false;
            // 
            // frmExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 222);
            this.Controls.Add(this.pictureBoxFontAwesome2);
            this.Name = "frmExample";
            this.Text = "Example";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFontAwesome2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBoxFontAwesome pictureBoxFontAwesome2;



    }
}

