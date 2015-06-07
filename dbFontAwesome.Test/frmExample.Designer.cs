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
            this.pictureBoxFontAwesome1 = new dbFontAwesome.Test.PictureBoxFontAwesome();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFontAwesome1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFontAwesome1
            // 
            this.pictureBoxFontAwesome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFontAwesome1.IconImage = dbFontAwesome.IconType.Search;
            this.pictureBoxFontAwesome1.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFontAwesome1.Name = "pictureBoxFontAwesome1";
            this.pictureBoxFontAwesome1.Size = new System.Drawing.Size(247, 222);
            this.pictureBoxFontAwesome1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFontAwesome1.TabIndex = 0;
            this.pictureBoxFontAwesome1.TabStop = false;
            // 
            // frmExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 222);
            this.Controls.Add(this.pictureBoxFontAwesome1);
            this.Name = "frmExample";
            this.Text = "Example";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFontAwesome1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBoxFontAwesome pictureBoxFontAwesome1;



    }
}

