
namespace GUI
{
    partial class ImageDisplay
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
            this.RotateButton = new System.Windows.Forms.Button();
            this.FlipHorizontalButton = new System.Windows.Forms.Button();
            this.FlipVerticalButton = new System.Windows.Forms.Button();
            this.ChangeBrightnessButton = new System.Windows.Forms.Button();
            this.ChangeContrastButton = new System.Windows.Forms.Button();
            this.PhotoNegativeFilterButton = new System.Windows.Forms.Button();
            this.ChangeSaturationButton = new System.Windows.Forms.Button();
            this.SepiaToneFilterButton = new System.Windows.Forms.Button();
            this.GreyScaleFilterButton = new System.Windows.Forms.Button();
            this.BlueScaleFilterButton = new System.Windows.Forms.Button();
            this.SaveImageButton = new System.Windows.Forms.Button();
            this.ImageHolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RotateButton
            // 
            this.RotateButton.BackColor = System.Drawing.Color.LightBlue;
            this.RotateButton.Location = new System.Drawing.Point(16, 15);
            this.RotateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(100, 52);
            this.RotateButton.TabIndex = 0;
            this.RotateButton.Text = "Rotate";
            this.RotateButton.UseVisualStyleBackColor = false;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // FlipHorizontalButton
            // 
            this.FlipHorizontalButton.BackColor = System.Drawing.Color.LightBlue;
            this.FlipHorizontalButton.Location = new System.Drawing.Point(149, 15);
            this.FlipHorizontalButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FlipHorizontalButton.Name = "FlipHorizontalButton";
            this.FlipHorizontalButton.Size = new System.Drawing.Size(100, 52);
            this.FlipHorizontalButton.TabIndex = 1;
            this.FlipHorizontalButton.Text = "Flip Horizontal";
            this.FlipHorizontalButton.UseVisualStyleBackColor = false;
            this.FlipHorizontalButton.Click += new System.EventHandler(this.FlipHorizontalButton_Click);
            // 
            // FlipVerticalButton
            // 
            this.FlipVerticalButton.BackColor = System.Drawing.Color.LightBlue;
            this.FlipVerticalButton.Location = new System.Drawing.Point(284, 15);
            this.FlipVerticalButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FlipVerticalButton.Name = "FlipVerticalButton";
            this.FlipVerticalButton.Size = new System.Drawing.Size(100, 52);
            this.FlipVerticalButton.TabIndex = 2;
            this.FlipVerticalButton.Text = "Flip Vertical";
            this.FlipVerticalButton.UseVisualStyleBackColor = false;
            this.FlipVerticalButton.Click += new System.EventHandler(this.FlipVerticalButton_Click);
            // 
            // ChangeBrightnessButton
            // 
            this.ChangeBrightnessButton.BackColor = System.Drawing.Color.LightCyan;
            this.ChangeBrightnessButton.Location = new System.Drawing.Point(416, 15);
            this.ChangeBrightnessButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChangeBrightnessButton.Name = "ChangeBrightnessButton";
            this.ChangeBrightnessButton.Size = new System.Drawing.Size(100, 52);
            this.ChangeBrightnessButton.TabIndex = 3;
            this.ChangeBrightnessButton.Text = "Change Brightness";
            this.ChangeBrightnessButton.UseVisualStyleBackColor = false;
            this.ChangeBrightnessButton.Click += new System.EventHandler(this.ChangeBrightnessButton_Click);
            // 
            // ChangeContrastButton
            // 
            this.ChangeContrastButton.BackColor = System.Drawing.Color.LightCyan;
            this.ChangeContrastButton.Location = new System.Drawing.Point(545, 15);
            this.ChangeContrastButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChangeContrastButton.Name = "ChangeContrastButton";
            this.ChangeContrastButton.Size = new System.Drawing.Size(100, 52);
            this.ChangeContrastButton.TabIndex = 4;
            this.ChangeContrastButton.Text = "Change Contrast";
            this.ChangeContrastButton.UseVisualStyleBackColor = false;
            this.ChangeContrastButton.Click += new System.EventHandler(this.ChangeContrastButton_Click);
            // 
            // PhotoNegativeFilterButton
            // 
            this.PhotoNegativeFilterButton.BackColor = System.Drawing.Color.Snow;
            this.PhotoNegativeFilterButton.Location = new System.Drawing.Point(484, 487);
            this.PhotoNegativeFilterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhotoNegativeFilterButton.Name = "PhotoNegativeFilterButton";
            this.PhotoNegativeFilterButton.Size = new System.Drawing.Size(127, 52);
            this.PhotoNegativeFilterButton.TabIndex = 7;
            this.PhotoNegativeFilterButton.Text = "Photo-Negative Filter";
            this.PhotoNegativeFilterButton.UseVisualStyleBackColor = false;
            this.PhotoNegativeFilterButton.Click += new System.EventHandler(this.PhotoNegativeFilterButton_Click);
            // 
            // ChangeSaturationButton
            // 
            this.ChangeSaturationButton.BackColor = System.Drawing.Color.LightCyan;
            this.ChangeSaturationButton.Location = new System.Drawing.Point(673, 15);
            this.ChangeSaturationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChangeSaturationButton.Name = "ChangeSaturationButton";
            this.ChangeSaturationButton.Size = new System.Drawing.Size(127, 52);
            this.ChangeSaturationButton.TabIndex = 8;
            this.ChangeSaturationButton.Text = "Change Saturation";
            this.ChangeSaturationButton.UseVisualStyleBackColor = false;
            this.ChangeSaturationButton.Click += new System.EventHandler(this.ChangeSaturationButton_Click);
            // 
            // SepiaToneFilterButton
            // 
            this.SepiaToneFilterButton.BackColor = System.Drawing.Color.Snow;
            this.SepiaToneFilterButton.Location = new System.Drawing.Point(16, 487);
            this.SepiaToneFilterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SepiaToneFilterButton.Name = "SepiaToneFilterButton";
            this.SepiaToneFilterButton.Size = new System.Drawing.Size(127, 52);
            this.SepiaToneFilterButton.TabIndex = 9;
            this.SepiaToneFilterButton.Text = "Sepia Tone Filter";
            this.SepiaToneFilterButton.UseVisualStyleBackColor = false;
            this.SepiaToneFilterButton.Click += new System.EventHandler(this.SepiaToneFilterButton_Click);
            // 
            // GreyScaleFilterButton
            // 
            this.GreyScaleFilterButton.BackColor = System.Drawing.Color.Snow;
            this.GreyScaleFilterButton.Location = new System.Drawing.Point(171, 487);
            this.GreyScaleFilterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GreyScaleFilterButton.Name = "GreyScaleFilterButton";
            this.GreyScaleFilterButton.Size = new System.Drawing.Size(127, 52);
            this.GreyScaleFilterButton.TabIndex = 10;
            this.GreyScaleFilterButton.Text = "Grey Scale Filter";
            this.GreyScaleFilterButton.UseVisualStyleBackColor = false;
            this.GreyScaleFilterButton.Click += new System.EventHandler(this.GreyScaleFilterButton_Click);
            // 
            // BlueScaleFilterButton
            // 
            this.BlueScaleFilterButton.BackColor = System.Drawing.Color.Snow;
            this.BlueScaleFilterButton.Location = new System.Drawing.Point(328, 487);
            this.BlueScaleFilterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BlueScaleFilterButton.Name = "BlueScaleFilterButton";
            this.BlueScaleFilterButton.Size = new System.Drawing.Size(127, 52);
            this.BlueScaleFilterButton.TabIndex = 11;
            this.BlueScaleFilterButton.Text = "Blue Scale Filter";
            this.BlueScaleFilterButton.UseVisualStyleBackColor = false;
            this.BlueScaleFilterButton.Click += new System.EventHandler(this.BlueScaleFilterButton_Click);
            // 
            // SaveImageButton
            // 
            this.SaveImageButton.BackColor = System.Drawing.Color.Ivory;
            this.SaveImageButton.Location = new System.Drawing.Point(924, 15);
            this.SaveImageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveImageButton.Name = "SaveImageButton";
            this.SaveImageButton.Size = new System.Drawing.Size(127, 52);
            this.SaveImageButton.TabIndex = 12;
            this.SaveImageButton.Text = "Save Image";
            this.SaveImageButton.UseVisualStyleBackColor = false;
            this.SaveImageButton.Click += new System.EventHandler(this.SaveImageButton_Click);
            // 
            // ImageHolder
            // 
            this.ImageHolder.Location = new System.Drawing.Point(74, 100);
            this.ImageHolder.Name = "ImageHolder";
            this.ImageHolder.Size = new System.Drawing.Size(916, 352);
            this.ImageHolder.TabIndex = 13;
            this.ImageHolder.UseVisualStyleBackColor = true;
            // 
            // ImageDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ImageHolder);
            this.Controls.Add(this.SaveImageButton);
            this.Controls.Add(this.BlueScaleFilterButton);
            this.Controls.Add(this.GreyScaleFilterButton);
            this.Controls.Add(this.SepiaToneFilterButton);
            this.Controls.Add(this.ChangeSaturationButton);
            this.Controls.Add(this.PhotoNegativeFilterButton);
            this.Controls.Add(this.ChangeContrastButton);
            this.Controls.Add(this.ChangeBrightnessButton);
            this.Controls.Add(this.FlipVerticalButton);
            this.Controls.Add(this.FlipHorizontalButton);
            this.Controls.Add(this.RotateButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ImageDisplay";
            this.Text = "Image Display";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RotateButton;
        private System.Windows.Forms.Button FlipHorizontalButton;
        private System.Windows.Forms.Button FlipVerticalButton;
        private System.Windows.Forms.Button ChangeBrightnessButton;
        private System.Windows.Forms.Button ChangeContrastButton;
        private System.Windows.Forms.Button PhotoNegativeFilterButton;
        private System.Windows.Forms.Button ChangeSaturationButton;
        private System.Windows.Forms.Button SepiaToneFilterButton;
        private System.Windows.Forms.Button GreyScaleFilterButton;
        private System.Windows.Forms.Button BlueScaleFilterButton;
        private System.Windows.Forms.Button SaveImageButton;
        private System.Windows.Forms.Button ImageHolder;
    }
}

