namespace HillCypher
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
            this.encrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.matrixKeyText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.fileText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(12, 208);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(75, 23);
            this.encrypt.TabIndex = 0;
            this.encrypt.Text = "encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(184, 208);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(75, 23);
            this.decrypt.TabIndex = 1;
            this.decrypt.Text = "decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // matrixKeyText
            // 
            this.matrixKeyText.Location = new System.Drawing.Point(97, 21);
            this.matrixKeyText.Name = "matrixKeyText";
            this.matrixKeyText.Size = new System.Drawing.Size(148, 20);
            this.matrixKeyText.TabIndex = 2;
            this.matrixKeyText.TextChanged += new System.EventHandler(this.matrixKeyText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Matrix Key";
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(12, 56);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(75, 23);
            this.openFileBtn.TabIndex = 4;
            this.openFileBtn.Text = "Open file...";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // fileText
            // 
            this.fileText.Location = new System.Drawing.Point(15, 85);
            this.fileText.Multiline = true;
            this.fileText.Name = "fileText";
            this.fileText.ReadOnly = true;
            this.fileText.Size = new System.Drawing.Size(244, 117);
            this.fileText.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.fileText);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matrixKeyText);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.TextBox matrixKeyText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.TextBox fileText;
    }
}

