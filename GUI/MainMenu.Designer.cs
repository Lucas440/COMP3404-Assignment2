﻿
namespace GUI
{
    partial class MainMenu
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
            this.NewNoteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewNoteButton
            // 
            this.NewNoteButton.BackColor = System.Drawing.Color.MistyRose;
            this.NewNoteButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewNoteButton.Location = new System.Drawing.Point(49, 36);
            this.NewNoteButton.Name = "NewNoteButton";
            this.NewNoteButton.Size = new System.Drawing.Size(106, 43);
            this.NewNoteButton.TabIndex = 0;
            this.NewNoteButton.Text = "New Note";
            this.NewNoteButton.UseVisualStyleBackColor = false;
            this.NewNoteButton.Click += new System.EventHandler(this.NewNoteButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(382, 124);
            this.Controls.Add(this.NewNoteButton);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewNoteButton;
    }
}