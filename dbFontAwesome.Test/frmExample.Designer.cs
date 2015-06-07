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
            this.pbfaExample = new dbFontAwesome.Test.PictureBoxFontAwesome();
            ((System.ComponentModel.ISupportInitialize)(this.pbfaExample)).BeginInit();
            this.SuspendLayout();
            // 
            // pbfaExample
            // 
            this.pbfaExample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbfaExample.IconImage = dbFontAwesome.IconType.Openid;
            this.pbfaExample.Image = ((System.Drawing.Image)(resources.GetObject("pbfaExample.Image")));
            this.pbfaExample.Location = new System.Drawing.Point(0, 0);
            this.pbfaExample.Name = "pbfaExample";
            this.pbfaExample.Size = new System.Drawing.Size(247, 222);
            this.pbfaExample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbfaExample.TabIndex = 0;
            this.pbfaExample.TabStop = false;
            // 
            // frmExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 222);
            this.Controls.Add(this.pbfaExample);
            this.Name = "frmExample";
            this.Text = "Example";
            this.Load += new System.EventHandler(this.frmExample_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbfaExample)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBoxFontAwesome pbfaExample;




    }
}

