namespace BingoGame
{
    partial class frmBingoCard
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
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.btnNextNumber = new System.Windows.Forms.Button();
            this.txtNextNumber = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblDsiplayName = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEnterName
            // 
            this.txtEnterName.Location = new System.Drawing.Point(82, 15);
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(100, 20);
            this.txtEnterName.TabIndex = 0;
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(13, 19);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(63, 13);
            this.lblEnterName.TabIndex = 1;
            this.lblEnterName.Text = "EnterName:";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point(188, 13);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pnlCard
            // 
            this.pnlCard.Location = new System.Drawing.Point(12, 207);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(588, 540);
            this.pnlCard.TabIndex = 3;
            // 
            // btnNextNumber
            // 
            this.btnNextNumber.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNextNumber.Location = new System.Drawing.Point(482, 15);
            this.btnNextNumber.Name = "btnNextNumber";
            this.btnNextNumber.Size = new System.Drawing.Size(122, 23);
            this.btnNextNumber.TabIndex = 4;
            this.btnNextNumber.Text = "Next Number";
            this.btnNextNumber.UseVisualStyleBackColor = true;
            this.btnNextNumber.Click += new System.EventHandler(this.btnNextNumber_Click);
            // 
            // txtNextNumber
            // 
            this.txtNextNumber.Location = new System.Drawing.Point(482, 61);
            this.txtNextNumber.Name = "txtNextNumber";
            this.txtNextNumber.ReadOnly = true;
            this.txtNextNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNextNumber.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(311, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(13, 48);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(39, 13);
            this.lblPlayerName.TabIndex = 7;
            this.lblPlayerName.Text = "Player:";
            // 
            // lblDsiplayName
            // 
            this.lblDsiplayName.AutoSize = true;
            this.lblDsiplayName.Location = new System.Drawing.Point(79, 48);
            this.lblDsiplayName.Name = "lblDsiplayName";
            this.lblDsiplayName.Size = new System.Drawing.Size(0, 13);
            this.lblDsiplayName.TabIndex = 8;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(16, 100);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(0, 13);
            this.lblInstructions.TabIndex = 9;
            // 
            // frmBingoCard
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(702, 759);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblDsiplayName);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtNextNumber);
            this.Controls.Add(this.btnNextNumber);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.txtEnterName);
            this.Name = "frmBingoCard";
            this.Text = "Bingo!!!";
            this.Load += new System.EventHandler(this.frmBingoCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Button btnNextNumber;
        private System.Windows.Forms.TextBox txtNextNumber;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblDsiplayName;
        private System.Windows.Forms.Label lblInstructions;
    }
}

