namespace CalculatorWithMenu
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.txtBNumber1 = new System.Windows.Forms.TextBox();
            this.txtBNumber2 = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstNumber.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFirstNumber.Location = new System.Drawing.Point(12, 30);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(197, 26);
            this.lblFirstNumber.TabIndex = 0;
            this.lblFirstNumber.Text = "Первое число:";
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblSecondNumber.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSecondNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSecondNumber.Location = new System.Drawing.Point(12, 90);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(193, 26);
            this.lblSecondNumber.TabIndex = 1;
            this.lblSecondNumber.Text = "Второе число:";
            // 
            // txtBNumber1
            // 
            this.txtBNumber1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBNumber1.Location = new System.Drawing.Point(250, 35);
            this.txtBNumber1.Name = "txtBNumber1";
            this.txtBNumber1.Size = new System.Drawing.Size(100, 24);
            this.txtBNumber1.TabIndex = 2;
            this.txtBNumber1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtBNumber1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtBNumber2
            // 
            this.txtBNumber2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBNumber2.Location = new System.Drawing.Point(250, 95);
            this.txtBNumber2.Name = "txtBNumber2";
            this.txtBNumber2.Size = new System.Drawing.Size(100, 24);
            this.txtBNumber2.TabIndex = 3;
            this.txtBNumber2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtBNumber2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Orange;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(26, 166);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 75);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Orange;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(107, 166);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 75);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnIncrease
            // 
            this.btnIncrease.BackColor = System.Drawing.Color.Orange;
            this.btnIncrease.FlatAppearance.BorderSize = 0;
            this.btnIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrease.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIncrease.Location = new System.Drawing.Point(188, 166);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(75, 75);
            this.btnIncrease.TabIndex = 6;
            this.btnIncrease.Text = "*";
            this.btnIncrease.UseVisualStyleBackColor = false;
            this.btnIncrease.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.Orange;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDivide.Location = new System.Drawing.Point(269, 166);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 75);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.BackColor = System.Drawing.Color.Transparent;
            this.lblRes.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRes.ForeColor = System.Drawing.Color.White;
            this.lblRes.Location = new System.Drawing.Point(61, 299);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(148, 26);
            this.lblRes.TabIndex = 8;
            this.lblRes.Text = "Результат:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(278, 299);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(28, 26);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "*";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Orange;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(134, 373);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 43);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btn_Exit);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CalculatorWithMenu.Properties.Resources._1533326959_low_poly_background_generator_min;
            this.ClientSize = new System.Drawing.Size(384, 440);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtBNumber2);
            this.Controls.Add(this.txtBNumber1);
            this.Controls.Add(this.lblSecondNumber);
            this.Controls.Add(this.lblFirstNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.TextBox txtBNumber1;
        private System.Windows.Forms.TextBox txtBNumber2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnExit;
    }
}