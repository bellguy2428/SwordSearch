
namespace SwordSearchGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RightButt = new System.Windows.Forms.Button();
            this.LeftButt = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Label();
            this.gradientPanel1 = new SwordSearchGUI.GradientPanel();
            this.readyButton = new System.Windows.Forms.Button();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.promptLabel = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightButt
            // 
            this.RightButt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.RightButt.Enabled = false;
            this.RightButt.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.RightButt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RightButt.Location = new System.Drawing.Point(493, 240);
            this.RightButt.Name = "RightButt";
            this.RightButt.Size = new System.Drawing.Size(161, 98);
            this.RightButt.TabIndex = 0;
            this.RightButt.Text = "Placeholder";
            this.RightButt.UseVisualStyleBackColor = false;
            // 
            // LeftButt
            // 
            this.LeftButt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LeftButt.Enabled = false;
            this.LeftButt.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.LeftButt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LeftButt.Location = new System.Drawing.Point(144, 240);
            this.LeftButt.Name = "LeftButt";
            this.LeftButt.Size = new System.Drawing.Size(161, 98);
            this.LeftButt.TabIndex = 1;
            this.LeftButt.Text = "Placeholder";
            this.LeftButt.UseVisualStyleBackColor = false;
            // 
            // Header
            // 
            this.Header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.Linen;
            this.Header.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.DarkRed;
            this.Header.Location = new System.Drawing.Point(276, 33);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(248, 58);
            this.Header.TabIndex = 3;
            this.Header.Text = "Sword Search";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.AutoSize = true;
            this.gradientPanel1.BackColor = System.Drawing.Color.Linen;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.MistyRose;
            this.gradientPanel1.ColorTop = System.Drawing.Color.Linen;
            this.gradientPanel1.Controls.Add(this.promptLabel);
            this.gradientPanel1.Controls.Add(this.Header);
            this.gradientPanel1.Controls.Add(this.readyButton);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gradientPanel1.Size = new System.Drawing.Size(800, 450);
            this.gradientPanel1.TabIndex = 4;
            // 
            // readyButton
            // 
            this.readyButton.BackColor = System.Drawing.Color.SlateGray;
            this.readyButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.readyButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.readyButton.FlatAppearance.BorderSize = 20;
            this.readyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.readyButton.Font = new System.Drawing.Font("MV Boli", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyButton.ForeColor = System.Drawing.Color.Firebrick;
            this.readyButton.Location = new System.Drawing.Point(0, 250);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(800, 200);
            this.readyButton.TabIndex = 5;
            this.readyButton.Text = "Ready?";
            this.readyButton.UseVisualStyleBackColor = false;
            this.readyButton.Click += new System.EventHandler(this.readyButton_Click);
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(254, 139);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(92, 20);
            this.promptLabel.TabIndex = 6;
            this.promptLabel.Text = "Placeholder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.RightButt);
            this.Controls.Add(this.LeftButt);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Sword Search";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RightButt;
        private System.Windows.Forms.Button LeftButt;
        private System.Windows.Forms.Label Header;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Button readyButton;
        private System.Windows.Forms.Label promptLabel;
    }
}

