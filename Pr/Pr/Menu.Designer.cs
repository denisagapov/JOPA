namespace Pr
{
    partial class Menu
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.buttonText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCalc
            // 
            this.buttonCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalc.Location = new System.Drawing.Point(86, 24);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(188, 83);
            this.buttonCalc.TabIndex = 0;
            this.buttonCalc.Text = "Калькулятор";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonGraph
            // 
            this.buttonGraph.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGraph.Location = new System.Drawing.Point(86, 113);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(188, 83);
            this.buttonGraph.TabIndex = 1;
            this.buttonGraph.Text = "Графический редактор";
            this.buttonGraph.UseVisualStyleBackColor = true;
            this.buttonGraph.Click += new System.EventHandler(this.buttonGraph_Click);
            // 
            // buttonText
            // 
            this.buttonText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonText.Location = new System.Drawing.Point(86, 202);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(188, 83);
            this.buttonText.TabIndex = 2;
            this.buttonText.Text = "Текстовый редактор";
            this.buttonText.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 317);
            this.Controls.Add(this.buttonText);
            this.Controls.Add(this.buttonGraph);
            this.Controls.Add(this.buttonCalc);
            this.Name = "Menu";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonGraph;
        private System.Windows.Forms.Button buttonText;
    }
}

