
namespace Joc
{
    partial class Form2
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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Viata = new System.Windows.Forms.ProgressBar();
            this.Scor = new System.Windows.Forms.Label();
            this.ammo = new System.Windows.Forms.Label();
            this.TextRestart = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.MainTimer);
            // 
            // Viata
            // 
            this.Viata.Location = new System.Drawing.Point(950, 12);
            this.Viata.Name = "Viata";
            this.Viata.Size = new System.Drawing.Size(138, 23);
            this.Viata.TabIndex = 1;
            this.Viata.Value = 100;
            // 
            // Scor
            // 
            this.Scor.AutoSize = true;
            this.Scor.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Scor.Location = new System.Drawing.Point(473, 12);
            this.Scor.Name = "Scor";
            this.Scor.Size = new System.Drawing.Size(110, 20);
            this.Scor.TabIndex = 2;
            this.Scor.Text = "Scorul: 000";
            // 
            // ammo
            // 
            this.ammo.AutoSize = true;
            this.ammo.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ammo.Location = new System.Drawing.Point(12, 15);
            this.ammo.Name = "ammo";
            this.ammo.Size = new System.Drawing.Size(97, 20);
            this.ammo.TabIndex = 3;
            this.ammo.Text = "Munitie: 5";
            this.ammo.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextRestart
            // 
            this.TextRestart.AutoSize = true;
            this.TextRestart.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextRestart.Location = new System.Drawing.Point(170, 257);
            this.TextRestart.Name = "TextRestart";
            this.TextRestart.Size = new System.Drawing.Size(738, 34);
            this.TextRestart.TabIndex = 4;
            this.TextRestart.Text = "Ai pierdut. Apasă pe text pentru a reîncepe!!!";
            this.TextRestart.Click += new System.EventHandler(this.TextRestart_Click);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::Joc.Properties.Resources.SurvivorUp;
            this.Player.InitialImage = global::Joc.Properties.Resources.Survivor;
            this.Player.Location = new System.Drawing.Point(968, 364);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(133, 120);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(229, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Apasă aici pentru a salva progresul!!";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1100, 627);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextRestart);
            this.Controls.Add(this.ammo);
            this.Controls.Add(this.Scor);
            this.Controls.Add(this.Viata);
            this.Controls.Add(this.Player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Joaca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inchide);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.ProgressBar Viata;
        private System.Windows.Forms.Label Scor;
        private System.Windows.Forms.Label ammo;
        private System.Windows.Forms.Label TextRestart;
        private System.Windows.Forms.Label label1;
    }
}