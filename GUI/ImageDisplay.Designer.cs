
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
            this.ImageHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // RotateButton
            // 
            this.RotateButton.BackColor = System.Drawing.Color.LightBlue;
            this.RotateButton.Location = new System.Drawing.Point(12, 12);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(75, 42);
            this.RotateButton.TabIndex = 0;
            this.RotateButton.Text = "Rotate";
            this.RotateButton.UseVisualStyleBackColor = false;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // FlipHorizontalButton
            // 
            this.FlipHorizontalButton.BackColor = System.Drawing.Color.LightBlue;
            this.FlipHorizontalButton.Location = new System.Drawing.Point(112, 12);
            this.FlipHorizontalButton.Name = "FlipHorizontalButton";
            this.FlipHorizontalButton.Size = new System.Drawing.Size(75, 42);
            this.FlipHorizontalButton.TabIndex = 1;
            this.FlipHorizontalButton.Text = "Flip Horizontal";
            this.FlipHorizontalButton.UseVisualStyleBackColor = false;
            this.FlipHorizontalButton.Click += new System.EventHandler(this.FlipHorizontalButton_Click);
            // 
            // FlipVerticalButton
            // 
            this.FlipVerticalButton.BackColor = System.Drawing.Color.LightBlue;
            this.FlipVerticalButton.Location = new System.Drawing.Point(213, 12);
            this.FlipVerticalButton.Name = "FlipVerticalButton";
            this.FlipVerticalButton.Size = new System.Drawing.Size(75, 42);
            this.FlipVerticalButton.TabIndex = 2;
            this.FlipVerticalButton.Text = "Flip Vertical";
            this.FlipVerticalButton.UseVisualStyleBackColor = false;
            this.FlipVerticalButton.Click += new System.EventHandler(this.FlipVerticalButton_Click);
            // 
            // ChangeBrightnessButton
            // 
            this.ChangeBrightnessButton.BackColor = System.Drawing.Color.LightCyan;
            this.ChangeBrightnessButton.Location = new System.Drawing.Point(312, 12);
            this.ChangeBrightnessButton.Name = "ChangeBrightnessButton";
            this.ChangeBrightnessButton.Size = new System.Drawing.Size(75, 42);
            this.ChangeBrightnessButton.TabIndex = 3;
            this.ChangeBrightnessButton.Text = "Change Brightness";
            this.ChangeBrightnessButton.UseVisualStyleBackColor = false;
            this.ChangeBrightnessButton.Click += new System.EventHandler(this.ChangeBrightnessButton_Click);
            // 
            // ChangeContrastButton
            // 
            this.ChangeContrastButton.BackColor = System.Drawing.Color.LightCyan;
            this.ChangeContrastButton.Location = new System.Drawing.Point(409, 12);
            this.ChangeContrastButton.Name = "ChangeContrastButton";
            this.ChangeContrastButton.Size = new System.Drawing.Size(75, 42);
            this.ChangeContrastButton.TabIndex = 4;
            this.ChangeContrastButton.Text = "Change Contrast";
            this.ChangeContrastButton.UseVisualStyleBackColor = false;
            this.ChangeContrastButton.Click += new System.EventHandler(this.ChangeContrastButton_Click);
            // 
            // PhotoNegativeFilterButton
            // 
            this.PhotoNegativeFilterButton.BackColor = System.Drawing.Color.Snow;
            this.PhotoNegativeFilterButton.Location = new System.Drawing.Point(363, 396);
            this.PhotoNegativeFilterButton.Name = "PhotoNegativeFilterButton";
            this.PhotoNegativeFilterButton.Size = new System.Drawing.Size(95, 42);
            this.PhotoNegativeFilterButton.TabIndex = 7;
            this.PhotoNegativeFilterButton.Text = "Photo-Negative Filter";
            this.PhotoNegativeFilterButton.UseVisualStyleBackColor = false;
            this.PhotoNegativeFilterButton.Click += new System.EventHandler(this.PhotoNegativeFilterButton_Click);
            // 
            // ChangeSaturationButton
            // 
            this.ChangeSaturationButton.BackColor = System.Drawing.Color.LightCyan;
            this.ChangeSaturationButton.Location = new System.Drawing.Point(505, 12);
            this.ChangeSaturationButton.Name = "ChangeSaturationButton";
            this.ChangeSaturationButton.Size = new System.Drawing.Size(95, 42);
            this.ChangeSaturationButton.TabIndex = 8;
            this.ChangeSaturationButton.Text = "Change Saturation";
            this.ChangeSaturationButton.UseVisualStyleBackColor = false;
            this.ChangeSaturationButton.Click += new System.EventHandler(this.ChangeSaturationButton_Click);
            // 
            // SepiaToneFilterButton
            // 
            this.SepiaToneFilterButton.BackColor = System.Drawing.Color.Snow;
            this.SepiaToneFilterButton.Location = new System.Drawing.Point(12, 396);
            this.SepiaToneFilterButton.Name = "SepiaToneFilterButton";
            this.SepiaToneFilterButton.Size = new System.Drawing.Size(95, 42);
            this.SepiaToneFilterButton.TabIndex = 9;
            this.SepiaToneFilterButton.Text = "Sepia Tone Filter";
            this.SepiaToneFilterButton.UseVisualStyleBackColor = false;
            this.SepiaToneFilterButton.Click += new System.EventHandler(this.SepiaToneFilterButton_Click);
            // 
            // GreyScaleFilterButton
            // 
            this.GreyScaleFilterButton.BackColor = System.Drawing.Color.Snow;
            this.GreyScaleFilterButton.Location = new System.Drawing.Point(128, 396);
            this.GreyScaleFilterButton.Name = "GreyScaleFilterButton";
            this.GreyScaleFilterButton.Size = new System.Drawing.Size(95, 42);
            this.GreyScaleFilterButton.TabIndex = 10;
            this.GreyScaleFilterButton.Text = "Grey Scale Filter";
            this.GreyScaleFilterButton.UseVisualStyleBackColor = false;
            this.GreyScaleFilterButton.Click += new System.EventHandler(this.GreyScaleFilterButton_Click);
            // 
            // BlueScaleFilterButton
            // 
            this.BlueScaleFilterButton.BackColor = System.Drawing.Color.Snow;
            this.BlueScaleFilterButton.Location = new System.Drawing.Point(246, 396);
            this.BlueScaleFilterButton.Name = "BlueScaleFilterButton";
            this.BlueScaleFilterButton.Size = new System.Drawing.Size(95, 42);
            this.BlueScaleFilterButton.TabIndex = 11;
            this.BlueScaleFilterButton.Text = "Blue Scale Filter";
            this.BlueScaleFilterButton.UseVisualStyleBackColor = false;
            this.BlueScaleFilterButton.Click += new System.EventHandler(this.BlueScaleFilterButton_Click);
            // 
            // SaveImageButton
            // 
            this.SaveImageButton.BackColor = System.Drawing.Color.Ivory;
            this.SaveImageButton.Location = new System.Drawing.Point(693, 12);
            this.SaveImageButton.Name = "SaveImageButton";
            this.SaveImageButton.Size = new System.Drawing.Size(95, 42);
            this.SaveImageButton.TabIndex = 12;
            this.SaveImageButton.Text = "Save Image";
            this.SaveImageButton.UseVisualStyleBackColor = false;
            this.SaveImageButton.Click += new System.EventHandler(this.SaveImageButton_Click);
            // 
            // ImageHolder
            // 
            this.ImageHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageHolder.Location = new System.Drawing.Point(44, 83);
            this.ImageHolder.Name = "ImageHolder";
            this.ImageHolder.Size = new System.Drawing.Size(698, 274);
            this.ImageHolder.TabIndex = 13;
            // 
            // ImageDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.FlowLayoutPanel ImageHolder;
    }
}

