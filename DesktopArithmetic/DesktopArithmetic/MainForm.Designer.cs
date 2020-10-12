namespace DesktopArithmetic
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sumButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a:";
            // 
            // aTextBox
            // 
            this.aTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aTextBox.Location = new System.Drawing.Point(45, 13);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(182, 20);
            this.aTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "b:";
            // 
            // bTextBox
            // 
            this.bTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bTextBox.Location = new System.Drawing.Point(45, 39);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(182, 20);
            this.bTextBox.TabIndex = 3;
            // 
            // sumTextBox
            // 
            this.sumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sumTextBox.Location = new System.Drawing.Point(45, 65);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.ReadOnly = true;
            this.sumTextBox.Size = new System.Drawing.Size(182, 20);
            this.sumTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "sum:";
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(45, 92);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(75, 23);
            this.sumButton.TabIndex = 6;
            this.sumButton.Text = "Sum";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 126);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Arithmetic";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

