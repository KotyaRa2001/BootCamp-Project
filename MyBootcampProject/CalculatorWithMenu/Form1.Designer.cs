namespace CalculatorWithMenu
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNameMenu = new System.Windows.Forms.Label();
            this.lbllCalculator = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblNameMenu
            // 
            this.lblNameMenu.AutoSize = true;
            this.lblNameMenu.Font = new System.Drawing.Font("Verdana", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameMenu.Location = new System.Drawing.Point(12, 39);
            this.lblNameMenu.Name = "lblNameMenu";
            this.lblNameMenu.Size = new System.Drawing.Size(563, 57);
            this.lblNameMenu.TabIndex = 0;
            this.lblNameMenu.Text = "Добро Пожаловать!";
            // 
            // lbllCalculator
            // 
            this.lbllCalculator.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.lbllCalculator.AutoSize = true;
            this.lbllCalculator.Font = new System.Drawing.Font("Verdana", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbllCalculator.LinkColor = System.Drawing.Color.Red;
            this.lbllCalculator.Location = new System.Drawing.Point(157, 172);
            this.lbllCalculator.Name = "lbllCalculator";
            this.lbllCalculator.Size = new System.Drawing.Size(272, 46);
            this.lbllCalculator.TabIndex = 1;
            this.lbllCalculator.TabStop = true;
            this.lbllCalculator.Text = "Калькулятор";
            this.lbllCalculator.VisitedLinkColor = System.Drawing.Color.Silver;
            this.lbllCalculator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllCalculator_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(584, 281);
            this.Controls.Add(this.lbllCalculator);
            this.Controls.Add(this.lblNameMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню проекта";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameMenu;
        private System.Windows.Forms.LinkLabel lbllCalculator;
    }
}

