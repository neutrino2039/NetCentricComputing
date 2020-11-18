
namespace CustomControl
{
    partial class MainForm
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
            this.rectangle = new CustomControl.Rectangle();
            this.SuspendLayout();
            // 
            // rectangle
            // 
            this.rectangle.Location = new System.Drawing.Point(74, 52);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(142, 137);
            this.rectangle.StrokeColor = System.Drawing.Color.DarkRed;
            this.rectangle.StrokeWidth = 10F;
            this.rectangle.TabIndex = 0;
            this.rectangle.Text = "rectangle1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 282);
            this.Controls.Add(this.rectangle);
            this.Name = "MainForm";
            this.Text = "Custom Control Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private Rectangle rectangle;
    }
}

