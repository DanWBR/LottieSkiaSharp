﻿
namespace LottieSkiaSharp.Samples.WinForms
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
            this.skglControl1 = new SkiaSharp.Views.Desktop.SKGLControl();
            this.SuspendLayout();
            // 
            // skglControl1
            // 
            this.skglControl1.BackColor = System.Drawing.Color.White;
            this.skglControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skglControl1.Location = new System.Drawing.Point(0, 0);
            this.skglControl1.Name = "skglControl1";
            this.skglControl1.Size = new System.Drawing.Size(300, 189);
            this.skglControl1.TabIndex = 0;
            this.skglControl1.VSync = false;
            this.skglControl1.PaintSurface += new System.EventHandler<SkiaSharp.Views.Desktop.SKPaintGLSurfaceEventArgs>(this.skglControl1_PaintSurface);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 189);
            this.Controls.Add(this.skglControl1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SkiaSharp.Views.Desktop.SKGLControl skglControl1;
    }
}

