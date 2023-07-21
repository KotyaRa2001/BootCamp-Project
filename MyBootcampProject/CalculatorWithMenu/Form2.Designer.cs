namespace CalculatorWithMenu
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Location = new System.Drawing.Point(54, 49);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(277, 29);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Введите ваш пароль:";
            // 
            // btnEnter
            // 
            this.btnEnter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEnter.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnter.Location = new System.Drawing.Point(59, 203);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(272, 42);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Ввод";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(59, 130);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.PasswordChar = '*';
            this.txtbPassword.Size = new System.Drawing.Size(272, 20);
            this.txtbPassword.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(384, 271);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblPassword);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пароль";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtbPassword;
    }
}