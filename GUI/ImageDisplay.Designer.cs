
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
            this.BrightnessLabel = new System.Windows.Forms.Label();
            this.BrightnessCounter = new System.Windows.Forms.NumericUpDown();
            this.SaturationCounter = new System.Windows.Forms.NumericUpDown();
            this.ContrastCounter = new System.Windows.Forms.NumericUpDown();
            this.ImageScaleButton = new System.Windows.Forms.Button();
            this.ImageScale_Bar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageScale_Bar)).BeginInit();
            this.SuspendLayout();
            // 
            // RotateButton
            // 
            this.RotateButton.BackColor = System.Drawing.Color.LightBlue;
            this.RotateButton.Location = new System.Drawing.Point(16, 15);
            this.RotateButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.FlipHorizontalButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.FlipVerticalButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.ChangeBrightnessButton.Location = new System.Drawing.Point(484, 100);
            this.ChangeBrightnessButton.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeBrightnessButton.Name = "ChangeBrightnessButton";
            this.ChangeBrightnessButton.Size = new System.Drawing.Size(100, 52);
            this.ChangeBrightnessButton.TabIndex = 3;
            this.ChangeBrightnessButton.Text = "Change Brightness";
            this.ChangeBrightnessButton.UseVisualStyleBackColor = false;
            // 
            // ChangeContrastButton
            // 
            this.ChangeContrastButton.BackColor = System.Drawing.Color.LightCyan;
            this.ChangeContrastButton.Location = new System.Drawing.Point(484, 219);
            this.ChangeContrastButton.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeContrastButton.Name = "ChangeContrastButton";
            this.ChangeContrastButton.Size = new System.Drawing.Size(100, 52);
            this.ChangeContrastButton.TabIndex = 4;
            this.ChangeContrastButton.Text = "Change Contrast";
            this.ChangeContrastButton.UseVisualStyleBackColor = false;
            // 
            // PhotoNegativeFilterButton
            // 
            this.PhotoNegativeFilterButton.BackColor = System.Drawing.Color.Snow;
            this.PhotoNegativeFilterButton.Location = new System.Drawing.Point(484, 487);
            this.PhotoNegativeFilterButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.ChangeSaturationButton.Location = new System.Drawing.Point(484, 159);
            this.ChangeSaturationButton.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeSaturationButton.Name = "ChangeSaturationButton";
            this.ChangeSaturationButton.Size = new System.Drawing.Size(100, 52);
            this.ChangeSaturationButton.TabIndex = 8;
            this.ChangeSaturationButton.Text = "Change Saturation";
            this.ChangeSaturationButton.UseVisualStyleBackColor = false;
            // 
            // SepiaToneFilterButton
            // 
            this.SepiaToneFilterButton.BackColor = System.Drawing.Color.Snow;
            this.SepiaToneFilterButton.Location = new System.Drawing.Point(16, 487);
            this.SepiaToneFilterButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.GreyScaleFilterButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.BlueScaleFilterButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.SaveImageButton.Location = new System.Drawing.Point(484, 13);
            this.SaveImageButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveImageButton.Name = "SaveImageButton";
            this.SaveImageButton.Size = new System.Drawing.Size(127, 52);
            this.SaveImageButton.TabIndex = 12;
            this.SaveImageButton.Text = "Save Image";
            this.SaveImageButton.UseVisualStyleBackColor = false;
            this.SaveImageButton.Click += new System.EventHandler(this.SaveImageButton_Click);
            // 
            // ImageHolder
            // 
            this.ImageHolder.Location = new System.Drawing.Point(75, 100);
            this.ImageHolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImageHolder.Name = "ImageHolder";
            this.ImageHolder.Size = new System.Drawing.Size(364, 352);
            this.ImageHolder.TabIndex = 13;
            this.ImageHolder.UseVisualStyleBackColor = true;
            // 
            // BrightnessLabel
            // 
            this.BrightnessLabel.AutoSize = true;
            this.BrightnessLabel.Location = new System.Drawing.Point(809, 116);
            this.BrightnessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BrightnessLabel.Name = "BrightnessLabel";
            this.BrightnessLabel.Size = new System.Drawing.Size(0, 17);
            this.BrightnessLabel.TabIndex = 15;
            // 
            // BrightnessCounter
            // 
            this.BrightnessCounter.Location = new System.Drawing.Point(612, 116);
            this.BrightnessCounter.Margin = new System.Windows.Forms.Padding(4);
            this.BrightnessCounter.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.BrightnessCounter.Name = "BrightnessCounter";
            this.BrightnessCounter.Size = new System.Drawing.Size(160, 22);
            this.BrightnessCounter.TabIndex = 16;
            this.BrightnessCounter.ValueChanged += new System.EventHandler(this.BrightnessCounter_ValueChanged);
            // 
            // SaturationCounter
            // 
            this.SaturationCounter.Location = new System.Drawing.Point(612, 175);
            this.SaturationCounter.Margin = new System.Windows.Forms.Padding(4);
            this.SaturationCounter.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.SaturationCounter.Name = "SaturationCounter";
            this.SaturationCounter.Size = new System.Drawing.Size(160, 22);
            this.SaturationCounter.TabIndex = 17;
            this.SaturationCounter.ValueChanged += new System.EventHandler(this.SaturationCounter_ValueChanged);
            // 
            // ContrastCounter
            // 
            this.ContrastCounter.Location = new System.Drawing.Point(612, 235);
            this.ContrastCounter.Margin = new System.Windows.Forms.Padding(4);
            this.ContrastCounter.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ContrastCounter.Name = "ContrastCounter";
            this.ContrastCounter.Size = new System.Drawing.Size(160, 22);
            this.ContrastCounter.TabIndex = 18;
            this.ContrastCounter.ValueChanged += new System.EventHandler(this.ContrastCounter_ValueChanged);
            // 
            // ImageScaleButton
            // 
            this.ImageScaleButton.BackColor = System.Drawing.Color.LightCyan;
            this.ImageScaleButton.Location = new System.Drawing.Point(484, 279);
            this.ImageScaleButton.Margin = new System.Windows.Forms.Padding(4);
            this.ImageScaleButton.Name = "ImageScaleButton";
            this.ImageScaleButton.Size = new System.Drawing.Size(100, 52);
            this.ImageScaleButton.TabIndex = 19;
            this.ImageScaleButton.Text = "Scale Image";
            this.ImageScaleButton.UseVisualStyleBackColor = false;
            // 
            // ImageScale_Bar
            // 
            this.ImageScale_Bar.Location = new System.Drawing.Point(612, 289);
            this.ImageScale_Bar.Name = "ImageScale_Bar";
            this.ImageScale_Bar.Size = new System.Drawing.Size(160, 56);
            this.ImageScale_Bar.TabIndex = 20;
            this.ImageScale_Bar.Value = 5;
            this.ImageScale_Bar.Scroll += new System.EventHandler(this.ImageScale_Bar_Scroll);
            // 
            // ImageDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(795, 554);
            this.Controls.Add(this.ImageScale_Bar);
            this.Controls.Add(this.ImageScaleButton);
            this.Controls.Add(this.ContrastCounter);
            this.Controls.Add(this.SaturationCounter);
            this.Controls.Add(this.BrightnessCounter);
            this.Controls.Add(this.BrightnessLabel);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ImageDisplay";
            this.Text = "Image Display";
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageScale_Bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label BrightnessLabel;
        private System.Windows.Forms.NumericUpDown BrightnessCounter;
        private System.Windows.Forms.NumericUpDown SaturationCounter;
        private System.Windows.Forms.NumericUpDown ContrastCounter;
        private System.Windows.Forms.Button ImageScaleButton;
        private System.Windows.Forms.TrackBar ImageScale_Bar;
    }
}

