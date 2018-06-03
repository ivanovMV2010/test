namespace Kinopins
{
    partial class Form1
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
            this.button_Search = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.panel_result = new System.Windows.Forms.Panel();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_namefiml = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(331, 54);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 0;
            this.button_Search.Text = "Поиск";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(26, 33);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(100, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Название фильма";
            // 
            // panel_result
            // 
            this.panel_result.Location = new System.Drawing.Point(12, 99);
            this.panel_result.Name = "panel_result";
            this.panel_result.Size = new System.Drawing.Size(394, 165);
            this.panel_result.TabIndex = 2;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(331, 276);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 3;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            // 
            // textBox_namefiml
            // 
            this.textBox_namefiml.Location = new System.Drawing.Point(135, 32);
            this.textBox_namefiml.Name = "textBox_namefiml";
            this.textBox_namefiml.Size = new System.Drawing.Size(188, 20);
            this.textBox_namefiml.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 311);
            this.Controls.Add(this.textBox_namefiml);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.panel_result);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.button_Search);
            this.Name = "Form1";
            this.Text = "Kinopoisk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panel_result;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_namefiml;
    }
}

