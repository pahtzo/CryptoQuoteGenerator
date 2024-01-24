﻿namespace CryptoQuoteGenerator
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
            this.textBox_Alphabet = new System.Windows.Forms.TextBox();
            this.btn_scramble = new System.Windows.Forms.Button();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.textBox_PlainText = new System.Windows.Forms.TextBox();
            this.textBox_CryptedText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_savesolution = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Alphabet
            // 
            this.textBox_Alphabet.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Alphabet.Location = new System.Drawing.Point(12, 15);
            this.textBox_Alphabet.Name = "textBox_Alphabet";
            this.textBox_Alphabet.ReadOnly = true;
            this.textBox_Alphabet.Size = new System.Drawing.Size(508, 23);
            this.textBox_Alphabet.TabIndex = 3;
            this.textBox_Alphabet.TabStop = false;
            // 
            // btn_scramble
            // 
            this.btn_scramble.Location = new System.Drawing.Point(639, 12);
            this.btn_scramble.Name = "btn_scramble";
            this.btn_scramble.Size = new System.Drawing.Size(92, 23);
            this.btn_scramble.TabIndex = 1;
            this.btn_scramble.Text = "Scramble";
            this.btn_scramble.UseVisualStyleBackColor = true;
            this.btn_scramble.Click += new System.EventHandler(this.btn_scramble_Click);
            // 
            // textBox_Key
            // 
            this.textBox_Key.AcceptsReturn = true;
            this.textBox_Key.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Key.Location = new System.Drawing.Point(13, 47);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.ReadOnly = true;
            this.textBox_Key.Size = new System.Drawing.Size(507, 23);
            this.textBox_Key.TabIndex = 4;
            this.textBox_Key.TabStop = false;
            // 
            // textBox_PlainText
            // 
            this.textBox_PlainText.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PlainText.Location = new System.Drawing.Point(16, 100);
            this.textBox_PlainText.Multiline = true;
            this.textBox_PlainText.Name = "textBox_PlainText";
            this.textBox_PlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_PlainText.Size = new System.Drawing.Size(715, 230);
            this.textBox_PlainText.TabIndex = 0;
            // 
            // textBox_CryptedText
            // 
            this.textBox_CryptedText.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CryptedText.Location = new System.Drawing.Point(16, 354);
            this.textBox_CryptedText.Multiline = true;
            this.textBox_CryptedText.Name = "textBox_CryptedText";
            this.textBox_CryptedText.ReadOnly = true;
            this.textBox_CryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_CryptedText.Size = new System.Drawing.Size(715, 230);
            this.textBox_CryptedText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Alphabet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Substitution Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Plaintext";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ciphertext";
            // 
            // btn_savesolution
            // 
            this.btn_savesolution.Location = new System.Drawing.Point(639, 44);
            this.btn_savesolution.Name = "btn_savesolution";
            this.btn_savesolution.Size = new System.Drawing.Size(92, 23);
            this.btn_savesolution.TabIndex = 2;
            this.btn_savesolution.Text = "Save Solution";
            this.btn_savesolution.UseVisualStyleBackColor = true;
            this.btn_savesolution.Click += new System.EventHandler(this.btn_savesolution_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 600);
            this.Controls.Add(this.btn_savesolution);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_CryptedText);
            this.Controls.Add(this.textBox_PlainText);
            this.Controls.Add(this.textBox_Key);
            this.Controls.Add(this.btn_scramble);
            this.Controls.Add(this.textBox_Alphabet);
            this.Name = "Form1";
            this.Text = "CryptoQuote Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Alphabet;
        private System.Windows.Forms.Button btn_scramble;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.TextBox textBox_PlainText;
        private System.Windows.Forms.TextBox textBox_CryptedText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_savesolution;
    }
}

