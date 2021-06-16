
namespace Lesson_6_WPF_Task
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
            this.label1 = new System.Windows.Forms.Label();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.Open_Btn = new System.Windows.Forms.Button();
            this.Choose_File_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ovalPictureBox1 = new OvalPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Information";
            // 
            // Save_Btn
            // 
            this.Save_Btn.AutoSize = true;
            this.Save_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_Btn.Location = new System.Drawing.Point(648, 384);
            this.Save_Btn.Margin = new System.Windows.Forms.Padding(13);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Padding = new System.Windows.Forms.Padding(5);
            this.Save_Btn.Size = new System.Drawing.Size(130, 45);
            this.Save_Btn.TabIndex = 1;
            this.Save_Btn.Text = "Save";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // Open_Btn
            // 
            this.Open_Btn.AutoSize = true;
            this.Open_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Open_Btn.Location = new System.Drawing.Point(492, 383);
            this.Open_Btn.Margin = new System.Windows.Forms.Padding(13);
            this.Open_Btn.Name = "Open_Btn";
            this.Open_Btn.Padding = new System.Windows.Forms.Padding(5);
            this.Open_Btn.Size = new System.Drawing.Size(130, 45);
            this.Open_Btn.TabIndex = 2;
            this.Open_Btn.Text = "Open";
            this.Open_Btn.UseVisualStyleBackColor = true;
            this.Open_Btn.Click += new System.EventHandler(this.Open_Btn_Click);
            // 
            // Choose_File_Btn
            // 
            this.Choose_File_Btn.AutoSize = true;
            this.Choose_File_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Choose_File_Btn.Location = new System.Drawing.Point(326, 235);
            this.Choose_File_Btn.Margin = new System.Windows.Forms.Padding(9);
            this.Choose_File_Btn.Name = "Choose_File_Btn";
            this.Choose_File_Btn.Padding = new System.Windows.Forms.Padding(3);
            this.Choose_File_Btn.Size = new System.Drawing.Size(114, 36);
            this.Choose_File_Btn.TabIndex = 4;
            this.Choose_File_Btn.Text = "Choose File";
            this.Choose_File_Btn.UseVisualStyleBackColor = true;
            this.Choose_File_Btn.Click += new System.EventHandler(this.Choose_File_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(12, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(127, 367);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(274, 63);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.ovalPictureBox1.Image = global::Lesson_6_WPF_Task.Properties.Resources.images;
            this.ovalPictureBox1.Location = new System.Drawing.Point(17, 51);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(297, 290);
            this.ovalPictureBox1.TabIndex = 6;
            this.ovalPictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ovalPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Choose_File_Btn);
            this.Controls.Add(this.Open_Btn);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Button Open_Btn;
        private System.Windows.Forms.Button Choose_File_Btn;
        private System.Windows.Forms.Label label2;
        private OvalPictureBox ovalPictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

