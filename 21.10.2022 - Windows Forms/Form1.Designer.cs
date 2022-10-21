namespace _21._10._2022___Windows_Forms
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
            this.buttonShowTime_ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTimeFormat = new System.Windows.Forms.ComboBox();
            this.changeColor = new System.Windows.Forms.Button();
            this.comboChangeColor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonShowTime_
            // 
            this.buttonShowTime_.Location = new System.Drawing.Point(171, 141);
            this.buttonShowTime_.Name = "buttonShowTime_";
            this.buttonShowTime_.Size = new System.Drawing.Size(75, 23);
            this.buttonShowTime_.TabIndex = 0;
            this.buttonShowTime_.Text = "Кнопка";
            this.buttonShowTime_.UseVisualStyleBackColor = true;
            this.buttonShowTime_.MouseHover += new System.EventHandler(this.buttonShowTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(485, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Текущее время";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxTimeFormat
            // 
            this.comboBoxTimeFormat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxTimeFormat.FormattingEnabled = true;
            this.comboBoxTimeFormat.Items.AddRange(new object[] {
            "Полное время",
            "Краткое время",
            "Только дата"});
            this.comboBoxTimeFormat.Location = new System.Drawing.Point(324, 139);
            this.comboBoxTimeFormat.Name = "comboBoxTimeFormat";
            this.comboBoxTimeFormat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTimeFormat.TabIndex = 2;
            this.comboBoxTimeFormat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // changeColor
            // 
            this.changeColor.Location = new System.Drawing.Point(171, 294);
            this.changeColor.Name = "changeColor";
            this.changeColor.Size = new System.Drawing.Size(104, 29);
            this.changeColor.TabIndex = 3;
            this.changeColor.Text = "Измени цвет";
            this.changeColor.UseVisualStyleBackColor = true;
            this.changeColor.Click += new System.EventHandler(this.button1_Click);
            this.changeColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.changeColor_);
            // 
            // comboChangeColor
            // 
            this.comboChangeColor.FormattingEnabled = true;
            this.comboChangeColor.Items.AddRange(new object[] {
            "Зеленый",
            "Синий",
            "Красный"});
            this.comboChangeColor.Location = new System.Drawing.Point(324, 302);
            this.comboChangeColor.Name = "comboChangeColor";
            this.comboChangeColor.Size = new System.Drawing.Size(121, 21);
            this.comboChangeColor.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboChangeColor);
            this.Controls.Add(this.changeColor);
            this.Controls.Add(this.comboBoxTimeFormat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonShowTime_);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowTime_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTimeFormat;
        private System.Windows.Forms.Button changeColor;
        private System.Windows.Forms.ComboBox comboChangeColor;
    }
}

