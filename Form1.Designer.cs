namespace Russian_Roulette
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
            this.btnLoadBalloons = new System.Windows.Forms.Button();
            this.btnDodge = new System.Windows.Forms.Button();
            this.btnThrow = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblBalloonsLoaded = new System.Windows.Forms.Label();
            this.lblBalloonsLeft = new System.Windows.Forms.Label();
            this.lblDodgesLeft = new System.Windows.Forms.Label();
            this.lblWinLoss = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.pbResult = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadBalloons
            // 
            this.btnLoadBalloons.Location = new System.Drawing.Point(54, 32);
            this.btnLoadBalloons.Name = "btnLoadBalloons";
            this.btnLoadBalloons.Size = new System.Drawing.Size(122, 48);
            this.btnLoadBalloons.TabIndex = 0;
            this.btnLoadBalloons.Text = "Load up water balloons";
            this.btnLoadBalloons.UseVisualStyleBackColor = true;
            this.btnLoadBalloons.Click += new System.EventHandler(this.BtnLoadBalloons_Click);
            // 
            // btnDodge
            // 
            this.btnDodge.Location = new System.Drawing.Point(344, 32);
            this.btnDodge.Name = "btnDodge";
            this.btnDodge.Size = new System.Drawing.Size(122, 48);
            this.btnDodge.TabIndex = 1;
            this.btnDodge.Text = "Dodge";
            this.btnDodge.UseVisualStyleBackColor = true;
            this.btnDodge.Click += new System.EventHandler(this.BtnDodge_Click);
            // 
            // btnThrow
            // 
            this.btnThrow.Location = new System.Drawing.Point(199, 32);
            this.btnThrow.Name = "btnThrow";
            this.btnThrow.Size = new System.Drawing.Size(122, 48);
            this.btnThrow.TabIndex = 2;
            this.btnThrow.Text = "Throw water ballons";
            this.btnThrow.UseVisualStyleBackColor = true;
            this.btnThrow.Click += new System.EventHandler(this.BtnThrow_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(598, 39);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 35);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // lblBalloonsLoaded
            // 
            this.lblBalloonsLoaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalloonsLoaded.Location = new System.Drawing.Point(50, 128);
            this.lblBalloonsLoaded.Name = "lblBalloonsLoaded";
            this.lblBalloonsLoaded.Size = new System.Drawing.Size(539, 31);
            this.lblBalloonsLoaded.TabIndex = 4;
            this.lblBalloonsLoaded.Text = "Water Balloons Loaded: ";
            this.lblBalloonsLoaded.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBalloonsLeft
            // 
            this.lblBalloonsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalloonsLeft.Location = new System.Drawing.Point(50, 174);
            this.lblBalloonsLeft.Name = "lblBalloonsLeft";
            this.lblBalloonsLeft.Size = new System.Drawing.Size(539, 31);
            this.lblBalloonsLeft.TabIndex = 5;
            this.lblBalloonsLeft.Text = "Water Balloons Left: ";
            this.lblBalloonsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDodgesLeft
            // 
            this.lblDodgesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodgesLeft.Location = new System.Drawing.Point(50, 219);
            this.lblDodgesLeft.Name = "lblDodgesLeft";
            this.lblDodgesLeft.Size = new System.Drawing.Size(539, 31);
            this.lblDodgesLeft.TabIndex = 6;
            this.lblDodgesLeft.Text = "Dodges Left: ";
            this.lblDodgesLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWinLoss
            // 
            this.lblWinLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinLoss.Location = new System.Drawing.Point(50, 267);
            this.lblWinLoss.Name = "lblWinLoss";
            this.lblWinLoss.Size = new System.Drawing.Size(539, 31);
            this.lblWinLoss.TabIndex = 7;
            this.lblWinLoss.Text = "Wins / Losses:  ";
            this.lblWinLoss.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(531, 281);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(218, 111);
            this.lblResult.TabIndex = 8;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbResult
            // 
            this.pbResult.Location = new System.Drawing.Point(533, 116);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(216, 162);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResult.TabIndex = 9;
            this.pbResult.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblWinLoss);
            this.Controls.Add(this.lblDodgesLeft);
            this.Controls.Add(this.lblBalloonsLeft);
            this.Controls.Add(this.lblBalloonsLoaded);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnThrow);
            this.Controls.Add(this.btnDodge);
            this.Controls.Add(this.btnLoadBalloons);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadBalloons;
        private System.Windows.Forms.Button btnDodge;
        private System.Windows.Forms.Button btnThrow;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblBalloonsLoaded;
        private System.Windows.Forms.Label lblBalloonsLeft;
        private System.Windows.Forms.Label lblDodgesLeft;
        private System.Windows.Forms.Label lblWinLoss;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox pbResult;
    }
}

