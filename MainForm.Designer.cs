namespace cs_cipher
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
        private void InitializeComponent() {
            this.txtbxinput = new System.Windows.Forms.TextBox();
            this.lblinput = new System.Windows.Forms.Label();
            this.lstbxalgorithm = new System.Windows.Forms.ListBox();
            this.lblalgorithm = new System.Windows.Forms.Label();
            this.btnencrypt = new System.Windows.Forms.Button();
            this.txtbxoutput = new System.Windows.Forms.TextBox();
            this.lbloutput = new System.Windows.Forms.Label();
            this.numcezar = new System.Windows.Forms.NumericUpDown();
            this.lblsettings = new System.Windows.Forms.Label();
            this.btndecrypt = new System.Windows.Forms.Button();
            this.openfilein = new System.Windows.Forms.Button();
            this.openfileout = new System.Windows.Forms.Button();
            this.writefileout = new System.Windows.Forms.Button();
            this.filewritein = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numcezar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbxinput
            // 
            this.txtbxinput.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxinput.Location = new System.Drawing.Point(12, 53);
            this.txtbxinput.Multiline = true;
            this.txtbxinput.Name = "txtbxinput";
            this.txtbxinput.Size = new System.Drawing.Size(293, 141);
            this.txtbxinput.TabIndex = 0;
            // 
            // lblinput
            // 
            this.lblinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblinput.Location = new System.Drawing.Point(12, 9);
            this.lblinput.Name = "lblinput";
            this.lblinput.Size = new System.Drawing.Size(135, 41);
            this.lblinput.TabIndex = 1;
            this.lblinput.Text = "Input";
            // 
            // lstbxalgorithm
            // 
            this.lstbxalgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lstbxalgorithm.FormattingEnabled = true;
            this.lstbxalgorithm.ItemHeight = 29;
            this.lstbxalgorithm.Location = new System.Drawing.Point(641, 20);
            this.lstbxalgorithm.Name = "lstbxalgorithm";
            this.lstbxalgorithm.Size = new System.Drawing.Size(120, 178);
            this.lstbxalgorithm.TabIndex = 2;
            this.lstbxalgorithm.SelectedIndexChanged += new System.EventHandler(this.lstbxalgorithm_SelectedIndexChanged);
            // 
            // lblalgorithm
            // 
            this.lblalgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblalgorithm.Location = new System.Drawing.Point(516, 20);
            this.lblalgorithm.Name = "lblalgorithm";
            this.lblalgorithm.Size = new System.Drawing.Size(119, 30);
            this.lblalgorithm.TabIndex = 3;
            this.lblalgorithm.Text = "Algorithm";
            // 
            // btnencrypt
            // 
            this.btnencrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnencrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnencrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnencrypt.Location = new System.Drawing.Point(175, 9);
            this.btnencrypt.Name = "btnencrypt";
            this.btnencrypt.Size = new System.Drawing.Size(130, 37);
            this.btnencrypt.TabIndex = 4;
            this.btnencrypt.Text = "Encrypt";
            this.btnencrypt.UseVisualStyleBackColor = true;
            this.btnencrypt.Click += new System.EventHandler(this.btnencrypt_Click);
            // 
            // txtbxoutput
            // 
            this.txtbxoutput.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxoutput.Location = new System.Drawing.Point(12, 241);
            this.txtbxoutput.Multiline = true;
            this.txtbxoutput.Name = "txtbxoutput";
            this.txtbxoutput.Size = new System.Drawing.Size(293, 141);
            this.txtbxoutput.TabIndex = 5;
            // 
            // lbloutput
            // 
            this.lbloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbloutput.Location = new System.Drawing.Point(12, 197);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(135, 41);
            this.lbloutput.TabIndex = 6;
            this.lbloutput.Text = "Output";
            // 
            // numcezar
            // 
            this.numcezar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.numcezar.Location = new System.Drawing.Point(311, 53);
            this.numcezar.Maximum = new decimal(new int[] { 36, 0, 0, 0 });
            this.numcezar.Name = "numcezar";
            this.numcezar.Size = new System.Drawing.Size(120, 35);
            this.numcezar.TabIndex = 7;
            this.numcezar.Value = new decimal(new int[] { 18, 0, 0, 0 });
            this.numcezar.Visible = false;
            this.numcezar.ValueChanged += new System.EventHandler(this.numcezar_ValueChanged);
            // 
            // lblsettings
            // 
            this.lblsettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblsettings.Location = new System.Drawing.Point(311, 9);
            this.lblsettings.Name = "lblsettings";
            this.lblsettings.Size = new System.Drawing.Size(135, 41);
            this.lblsettings.TabIndex = 8;
            this.lblsettings.Text = "Settings";
            // 
            // btndecrypt
            // 
            this.btndecrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btndecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndecrypt.Location = new System.Drawing.Point(175, 199);
            this.btndecrypt.Name = "btndecrypt";
            this.btndecrypt.Size = new System.Drawing.Size(130, 37);
            this.btndecrypt.TabIndex = 9;
            this.btndecrypt.Text = "Decrypt";
            this.btndecrypt.UseVisualStyleBackColor = true;
            this.btndecrypt.Click += new System.EventHandler(this.btndecrypt_Click);
            // 
            // openfilein
            // 
            this.openfilein.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.openfilein.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openfilein.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openfilein.Location = new System.Drawing.Point(311, 114);
            this.openfilein.Name = "openfilein";
            this.openfilein.Size = new System.Drawing.Size(135, 37);
            this.openfilein.TabIndex = 10;
            this.openfilein.Text = "Open File";
            this.openfilein.UseVisualStyleBackColor = true;
            this.openfilein.Click += new System.EventHandler(this.openfilein_Click);
            // 
            // openfileout
            // 
            this.openfileout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.openfileout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openfileout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openfileout.Location = new System.Drawing.Point(311, 302);
            this.openfileout.Name = "openfileout";
            this.openfileout.Size = new System.Drawing.Size(135, 37);
            this.openfileout.TabIndex = 11;
            this.openfileout.Text = "Open File";
            this.openfileout.UseVisualStyleBackColor = true;
            this.openfileout.Click += new System.EventHandler(this.openfileout_Click);
            // 
            // writefileout
            // 
            this.writefileout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.writefileout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.writefileout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writefileout.Location = new System.Drawing.Point(311, 345);
            this.writefileout.Name = "writefileout";
            this.writefileout.Size = new System.Drawing.Size(135, 37);
            this.writefileout.TabIndex = 13;
            this.writefileout.Text = "Write File";
            this.writefileout.UseVisualStyleBackColor = true;
            this.writefileout.Click += new System.EventHandler(this.writefileout_Click);
            // 
            // filewritein
            // 
            this.filewritein.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.filewritein.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filewritein.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filewritein.Location = new System.Drawing.Point(311, 157);
            this.filewritein.Name = "filewritein";
            this.filewritein.Size = new System.Drawing.Size(135, 37);
            this.filewritein.TabIndex = 12;
            this.filewritein.Text = "Write File";
            this.filewritein.UseVisualStyleBackColor = true;
            this.filewritein.Click += new System.EventHandler(this.filewritein_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.writefileout);
            this.Controls.Add(this.filewritein);
            this.Controls.Add(this.openfileout);
            this.Controls.Add(this.openfilein);
            this.Controls.Add(this.btndecrypt);
            this.Controls.Add(this.lblsettings);
            this.Controls.Add(this.numcezar);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.txtbxoutput);
            this.Controls.Add(this.btnencrypt);
            this.Controls.Add(this.lblalgorithm);
            this.Controls.Add(this.lstbxalgorithm);
            this.Controls.Add(this.lblinput);
            this.Controls.Add(this.txtbxinput);
            this.Name = "MainForm";
            this.Text = "Text Cipher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numcezar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button openfilein;
        private System.Windows.Forms.Button openfileout;
        private System.Windows.Forms.Button writefileout;
        private System.Windows.Forms.Button filewritein;

        private System.Windows.Forms.Button btndecrypt;

        private System.Windows.Forms.NumericUpDown numcezar;
        private System.Windows.Forms.Label lblsettings;

        private System.Windows.Forms.TextBox txtbxoutput;
        private System.Windows.Forms.Label lbloutput;

        private System.Windows.Forms.Button btnencrypt;

        private System.Windows.Forms.Label lblinput;

        private System.Windows.Forms.Label lblalgorithm;

        private System.Windows.Forms.ListBox lstbxalgorithm;

        private System.Windows.Forms.TextBox txtbxinput;

        #endregion
    }
}