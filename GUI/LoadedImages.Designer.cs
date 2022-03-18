
namespace GUI
{
    partial class LoadedImages
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
            this.LoadNewImageButton = new System.Windows.Forms.Button();
            this.ImageMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // LoadNewImageButton
            // 
            this.LoadNewImageButton.BackColor = System.Drawing.Color.MintCream;
            this.LoadNewImageButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadNewImageButton.Location = new System.Drawing.Point(655, 12);
            this.LoadNewImageButton.Name = "LoadNewImageButton";
            this.LoadNewImageButton.Size = new System.Drawing.Size(133, 42);
            this.LoadNewImageButton.TabIndex = 0;
            this.LoadNewImageButton.Text = "Load New Image";
            this.LoadNewImageButton.UseVisualStyleBackColor = false;
            this.LoadNewImageButton.Click += new System.EventHandler(this.LoadNewImageButton_Click);
            // 
            // ImageMenu
            // 
            this.ImageMenu.Location = new System.Drawing.Point(12, 12);
            this.ImageMenu.Name = "ImageMenu";
            this.ImageMenu.Size = new System.Drawing.Size(637, 426);
            this.ImageMenu.TabIndex = 1;
            // 
            // LoadedImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImageMenu);
            this.Controls.Add(this.LoadNewImageButton);
            this.Name = "LoadedImages";
            this.Text = "LoadedImages";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadNewImageButton;
        private System.Windows.Forms.FlowLayoutPanel ImageMenu;
    }
}