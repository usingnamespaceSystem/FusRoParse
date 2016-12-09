namespace goparceyourself
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.link = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.metal = new System.Windows.Forms.TextBox();
            this.incrust = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.choice_type = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.size_begin = new System.Windows.Forms.TextBox();
            this.size_step = new System.Windows.Forms.TextBox();
            this.size_end = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.size_write = new System.Windows.Forms.Button();
            this.size_box = new System.Windows.Forms.Panel();
            this.size_ok = new System.Windows.Forms.Button();
            this.webControl1 = new Awesomium.Windows.Forms.WebControl(this.components);
            this.size_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // link
            // 
            this.link.Location = new System.Drawing.Point(435, 38);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(632, 20);
            this.link.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1084, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 61);
            this.button2.TabIndex = 10;
            this.button2.Text = "FUS RO PARS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(435, 229);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(363, 82);
            this.richTextBox3.TabIndex = 8;
            this.richTextBox3.Text = "";
            // 
            // name
            // 
            this.name.Enabled = false;
            this.name.Location = new System.Drawing.Point(435, 79);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(632, 20);
            this.name.TabIndex = 12;
            // 
            // price
            // 
            this.price.Enabled = false;
            this.price.Location = new System.Drawing.Point(435, 115);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(204, 20);
            this.price.TabIndex = 13;
            // 
            // metal
            // 
            this.metal.Enabled = false;
            this.metal.Location = new System.Drawing.Point(435, 141);
            this.metal.Name = "metal";
            this.metal.Size = new System.Drawing.Size(204, 20);
            this.metal.TabIndex = 14;
            // 
            // incrust
            // 
            this.incrust.Enabled = false;
            this.incrust.Location = new System.Drawing.Point(435, 167);
            this.incrust.Name = "incrust";
            this.incrust.Size = new System.Drawing.Size(204, 20);
            this.incrust.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Вставка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Металл";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ссылка";
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(400, 196);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(26, 13);
            this.weight.TabIndex = 24;
            this.weight.Text = "Вес";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(435, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 20);
            this.textBox2.TabIndex = 23;
            // 
            // choice_type
            // 
            this.choice_type.FormattingEnabled = true;
            this.choice_type.Location = new System.Drawing.Point(657, 114);
            this.choice_type.Name = "choice_type";
            this.choice_type.Size = new System.Drawing.Size(162, 21);
            this.choice_type.TabIndex = 29;
            this.choice_type.SelectedIndexChanged += new System.EventHandler(this.choice_type_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1322, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 61);
            this.button1.TabIndex = 30;
            this.button1.Text = "Перезагрузить лагобраузер";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // size_begin
            // 
            this.size_begin.Location = new System.Drawing.Point(0, 20);
            this.size_begin.Name = "size_begin";
            this.size_begin.Size = new System.Drawing.Size(52, 20);
            this.size_begin.TabIndex = 33;
            // 
            // size_step
            // 
            this.size_step.Location = new System.Drawing.Point(58, 20);
            this.size_step.Name = "size_step";
            this.size_step.Size = new System.Drawing.Size(41, 20);
            this.size_step.TabIndex = 34;
            // 
            // size_end
            // 
            this.size_end.Location = new System.Drawing.Point(105, 20);
            this.size_end.Name = "size_end";
            this.size_end.Size = new System.Drawing.Size(54, 20);
            this.size_end.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Нач.знач.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Шаг";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Конеч.знач.";
            // 
            // size_write
            // 
            this.size_write.Location = new System.Drawing.Point(0, 46);
            this.size_write.Name = "size_write";
            this.size_write.Size = new System.Drawing.Size(70, 20);
            this.size_write.TabIndex = 39;
            this.size_write.Text = "Вычислить";
            this.size_write.UseVisualStyleBackColor = true;
            this.size_write.Click += new System.EventHandler(this.Get_size);
            // 
            // size_box
            // 
            this.size_box.Controls.Add(this.size_ok);
            this.size_box.Controls.Add(this.size_write);
            this.size_box.Controls.Add(this.size_begin);
            this.size_box.Controls.Add(this.label8);
            this.size_box.Controls.Add(this.size_step);
            this.size_box.Controls.Add(this.label7);
            this.size_box.Controls.Add(this.size_end);
            this.size_box.Controls.Add(this.label6);
            this.size_box.Location = new System.Drawing.Point(660, 146);
            this.size_box.Name = "size_box";
            this.size_box.Size = new System.Drawing.Size(159, 66);
            this.size_box.TabIndex = 40;
            // 
            // size_ok
            // 
            this.size_ok.Location = new System.Drawing.Point(76, 46);
            this.size_ok.Name = "size_ok";
            this.size_ok.Size = new System.Drawing.Size(83, 20);
            this.size_ok.TabIndex = 40;
            this.size_ok.Text = "Подтвердить";
            this.size_ok.UseVisualStyleBackColor = true;
            this.size_ok.Click += new System.EventHandler(this.Confirm_size);
            // 
            // webControl1
            // 
            this.webControl1.Location = new System.Drawing.Point(435, 331);
            this.webControl1.Size = new System.Drawing.Size(989, 569);
            this.webControl1.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 902);
            this.Controls.Add(this.webControl1);
            this.Controls.Add(this.size_box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.choice_type);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.incrust);
            this.Controls.Add(this.metal);
            this.Controls.Add(this.price);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.link);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.size_box.ResumeLayout(false);
            this.size_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox link;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox metal;
        private System.Windows.Forms.TextBox incrust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox choice_type;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox size_begin;
        private System.Windows.Forms.TextBox size_step;
        private System.Windows.Forms.TextBox size_end;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button size_write;
        private System.Windows.Forms.Panel size_box;
        private System.Windows.Forms.Button size_ok;
        private Awesomium.Windows.Forms.WebControl webControl1;
    }
}

