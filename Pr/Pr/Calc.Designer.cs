namespace Pr
{
    partial class Calc
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
            this.textBoxChislo1 = new System.Windows.Forms.TextBox();
            this.textBoxChislo2 = new System.Windows.Forms.TextBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonDelenie = new System.Windows.Forms.Button();
            this.buttonUmnozh = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxChislo1
            // 
            this.textBoxChislo1.Location = new System.Drawing.Point(12, 35);
            this.textBoxChislo1.Multiline = true;
            this.textBoxChislo1.Name = "textBoxChislo1";
            this.textBoxChislo1.Size = new System.Drawing.Size(71, 37);
            this.textBoxChislo1.TabIndex = 0;
            // 
            // textBoxChislo2
            // 
            this.textBoxChislo2.Location = new System.Drawing.Point(231, 35);
            this.textBoxChislo2.Multiline = true;
            this.textBoxChislo2.Name = "textBoxChislo2";
            this.textBoxChislo2.Size = new System.Drawing.Size(73, 37);
            this.textBoxChislo2.TabIndex = 1;
            // 
            // buttonPlus
            // 
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(89, 35);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(136, 36);
            this.buttonPlus.TabIndex = 2;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.Location = new System.Drawing.Point(89, 77);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(136, 36);
            this.buttonMinus.TabIndex = 3;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonDelenie
            // 
            this.buttonDelenie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelenie.Location = new System.Drawing.Point(89, 119);
            this.buttonDelenie.Name = "buttonDelenie";
            this.buttonDelenie.Size = new System.Drawing.Size(136, 36);
            this.buttonDelenie.TabIndex = 4;
            this.buttonDelenie.Text = "/";
            this.buttonDelenie.UseVisualStyleBackColor = true;
            this.buttonDelenie.Click += new System.EventHandler(this.buttonDelenie_Click);
            // 
            // buttonUmnozh
            // 
            this.buttonUmnozh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUmnozh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUmnozh.Location = new System.Drawing.Point(89, 161);
            this.buttonUmnozh.Name = "buttonUmnozh";
            this.buttonUmnozh.Size = new System.Drawing.Size(136, 36);
            this.buttonUmnozh.TabIndex = 5;
            this.buttonUmnozh.Text = "*";
            this.buttonUmnozh.UseVisualStyleBackColor = true;
            this.buttonUmnozh.Click += new System.EventHandler(this.buttonUmnozh_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(12, 230);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(127, 25);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Результат: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Число 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(234, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Число 2";
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 301);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonUmnozh);
            this.Controls.Add(this.buttonDelenie);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.textBoxChislo2);
            this.Controls.Add(this.textBoxChislo1);
            this.Name = "Calc";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxChislo1;
        private System.Windows.Forms.TextBox textBoxChislo2;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonDelenie;
        private System.Windows.Forms.Button buttonUmnozh;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}