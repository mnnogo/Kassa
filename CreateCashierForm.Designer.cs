﻿
namespace Касса
{
    partial class CreateCashierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCashierForm));
            this.registerButton = new System.Windows.Forms.Button();
            this.back_to_menu = new System.Windows.Forms.Button();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newLoginTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowHidePassButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShowHidePassButton)).BeginInit();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerButton.Location = new System.Drawing.Point(23, 206);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(220, 48);
            this.registerButton.TabIndex = 12;
            this.registerButton.Text = "Зарегистрировать\r\n";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // back_to_menu
            // 
            this.back_to_menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back_to_menu.Location = new System.Drawing.Point(89, 344);
            this.back_to_menu.Name = "back_to_menu";
            this.back_to_menu.Size = new System.Drawing.Size(80, 27);
            this.back_to_menu.TabIndex = 11;
            this.back_to_menu.Text = "Назад";
            this.back_to_menu.UseVisualStyleBackColor = true;
            this.back_to_menu.Click += new System.EventHandler(this.back_to_menu_Click);
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPasswordTextBox.Location = new System.Drawing.Point(23, 147);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PlaceholderText = "Пароль";
            this.newPasswordTextBox.Size = new System.Drawing.Size(183, 30);
            this.newPasswordTextBox.TabIndex = 9;
            this.newPasswordTextBox.UseSystemPasswordChar = true;
            this.newPasswordTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.newPasswordTextBox_KeyUp);
            // 
            // newLoginTextBox
            // 
            this.newLoginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newLoginTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newLoginTextBox.Location = new System.Drawing.Point(23, 88);
            this.newLoginTextBox.Name = "newLoginTextBox";
            this.newLoginTextBox.PlaceholderText = "Логин";
            this.newLoginTextBox.Size = new System.Drawing.Size(220, 30);
            this.newLoginTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(69, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Регистрация";
            // 
            // ShowHidePassButton
            // 
            this.ShowHidePassButton.BackColor = System.Drawing.Color.Transparent;
            this.ShowHidePassButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShowHidePassButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowHidePassButton.Image")));
            this.ShowHidePassButton.Location = new System.Drawing.Point(203, 147);
            this.ShowHidePassButton.Name = "ShowHidePassButton";
            this.ShowHidePassButton.Size = new System.Drawing.Size(40, 30);
            this.ShowHidePassButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowHidePassButton.TabIndex = 19;
            this.ShowHidePassButton.TabStop = false;
            this.ShowHidePassButton.Click += new System.EventHandler(this.ShowHidePassButton_Click);
            // 
            // CreateCashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 383);
            this.Controls.Add(this.ShowHidePassButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.back_to_menu);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.newLoginTextBox);
            this.Name = "CreateCashierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Регистрация нового кассира";
            ((System.ComponentModel.ISupportInitialize)(this.ShowHidePassButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button back_to_menu;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.TextBox newLoginTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ShowHidePassButton;
    }
}