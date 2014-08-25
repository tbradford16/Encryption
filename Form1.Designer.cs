namespace Encryption
{
    partial class Encrypter
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
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.codebox = new System.Windows.Forms.RichTextBox();
            this.encrypt_decript = new System.Windows.Forms.Label();
            this.action = new System.Windows.Forms.Button();
            this.Choose = new System.Windows.Forms.GroupBox();
            this.decrypt = new System.Windows.Forms.RadioButton();
            this.encrypt = new System.Windows.Forms.RadioButton();
            this.Choose.SuspendLayout();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(22, 62);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(208, 20);
            this.password.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // codebox
            // 
            this.codebox.Location = new System.Drawing.Point(300, 62);
            this.codebox.Name = "codebox";
            this.codebox.Size = new System.Drawing.Size(423, 429);
            this.codebox.TabIndex = 2;
            this.codebox.Text = "";
            // 
            // encrypt_decript
            // 
            this.encrypt_decript.AutoSize = true;
            this.encrypt_decript.Location = new System.Drawing.Point(472, 46);
            this.encrypt_decript.Name = "encrypt_decript";
            this.encrypt_decript.Size = new System.Drawing.Size(83, 13);
            this.encrypt_decript.TabIndex = 3;
            this.encrypt_decript.Text = "Code to Encrypt";
            // 
            // action
            // 
            this.action.Location = new System.Drawing.Point(12, 468);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(102, 23);
            this.action.TabIndex = 4;
            this.action.Text = "Encrypt Now";
            this.action.UseVisualStyleBackColor = true;
            this.action.Click += new System.EventHandler(this.action_Click);
            // 
            // Choose
            // 
            this.Choose.Controls.Add(this.decrypt);
            this.Choose.Controls.Add(this.encrypt);
            this.Choose.Location = new System.Drawing.Point(22, 88);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(181, 50);
            this.Choose.TabIndex = 5;
            this.Choose.TabStop = false;
            this.Choose.Text = "Choose";
            // 
            // decrypt
            // 
            this.decrypt.AutoSize = true;
            this.decrypt.Location = new System.Drawing.Point(98, 20);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(62, 17);
            this.decrypt.TabIndex = 1;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.CheckedChanged += new System.EventHandler(this.decrypt_CheckedChanged);
            // 
            // encrypt
            // 
            this.encrypt.AutoSize = true;
            this.encrypt.Checked = true;
            this.encrypt.Location = new System.Drawing.Point(7, 20);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(61, 17);
            this.encrypt.TabIndex = 0;
            this.encrypt.TabStop = true;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.CheckedChanged += new System.EventHandler(this.encrypt_CheckedChanged);
            // 
            // Encrypter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 503);
            this.Controls.Add(this.Choose);
            this.Controls.Add(this.action);
            this.Controls.Add(this.encrypt_decript);
            this.Controls.Add(this.codebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Name = "Encrypter";
            this.Text = "Encrypter";
            this.Choose.ResumeLayout(false);
            this.Choose.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox codebox;
        private System.Windows.Forms.Label encrypt_decript;
        private System.Windows.Forms.Button action;
        private System.Windows.Forms.GroupBox Choose;
        private System.Windows.Forms.RadioButton decrypt;
        private System.Windows.Forms.RadioButton encrypt;
    }
}

