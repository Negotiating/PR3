namespace PR3_1_2_WF
{
	partial class practic3
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
			this.task1 = new System.Windows.Forms.GroupBox();
			this.calculate = new System.Windows.Forms.Button();
			this.dot = new System.Windows.Forms.Label();
			this.dot_label = new System.Windows.Forms.Label();
			this.length2 = new System.Windows.Forms.Label();
			this.length2_label = new System.Windows.Forms.Label();
			this.length1 = new System.Windows.Forms.Label();
			this.length1_label = new System.Windows.Forms.Label();
			this.Y1 = new System.Windows.Forms.TextBox();
			this.X2 = new System.Windows.Forms.TextBox();
			this.Y2 = new System.Windows.Forms.TextBox();
			this.X1 = new System.Windows.Forms.TextBox();
			this.y1_label = new System.Windows.Forms.Label();
			this.x2_label = new System.Windows.Forms.Label();
			this.y2_label = new System.Windows.Forms.Label();
			this.x1_label = new System.Windows.Forms.Label();
			this.task2 = new System.Windows.Forms.GroupBox();
			this.tabel = new System.Windows.Forms.RichTextBox();
			this.step = new System.Windows.Forms.TextBox();
			this.step_label = new System.Windows.Forms.Label();
			this.border2 = new System.Windows.Forms.TextBox();
			this.border1 = new System.Windows.Forms.TextBox();
			this.border2_label = new System.Windows.Forms.Label();
			this.border1_label = new System.Windows.Forms.Label();
			this.calculate2 = new System.Windows.Forms.Button();
			this.task1.SuspendLayout();
			this.task2.SuspendLayout();
			this.SuspendLayout();
			// 
			// task1
			// 
			this.task1.Controls.Add(this.calculate);
			this.task1.Controls.Add(this.dot);
			this.task1.Controls.Add(this.dot_label);
			this.task1.Controls.Add(this.length2);
			this.task1.Controls.Add(this.length2_label);
			this.task1.Controls.Add(this.length1);
			this.task1.Controls.Add(this.length1_label);
			this.task1.Controls.Add(this.Y1);
			this.task1.Controls.Add(this.X2);
			this.task1.Controls.Add(this.Y2);
			this.task1.Controls.Add(this.X1);
			this.task1.Controls.Add(this.y1_label);
			this.task1.Controls.Add(this.x2_label);
			this.task1.Controls.Add(this.y2_label);
			this.task1.Controls.Add(this.x1_label);
			this.task1.Location = new System.Drawing.Point(12, 12);
			this.task1.Name = "task1";
			this.task1.Size = new System.Drawing.Size(290, 297);
			this.task1.TabIndex = 0;
			this.task1.TabStop = false;
			this.task1.Text = "Задание 1";
			// 
			// calculate
			// 
			this.calculate.Location = new System.Drawing.Point(18, 246);
			this.calculate.Name = "calculate";
			this.calculate.Size = new System.Drawing.Size(246, 38);
			this.calculate.TabIndex = 14;
			this.calculate.Text = "Рассчитать";
			this.calculate.UseVisualStyleBackColor = true;
			this.calculate.Click += new System.EventHandler(this.calculate_Click);
			// 
			// dot
			// 
			this.dot.AutoSize = true;
			this.dot.Location = new System.Drawing.Point(208, 215);
			this.dot.Name = "dot";
			this.dot.Size = new System.Drawing.Size(0, 17);
			this.dot.TabIndex = 13;
			// 
			// dot_label
			// 
			this.dot_label.AutoSize = true;
			this.dot_label.Location = new System.Drawing.Point(15, 215);
			this.dot_label.Name = "dot_label";
			this.dot_label.Size = new System.Drawing.Size(187, 17);
			this.dot_label.TabIndex = 12;
			this.dot_label.Text = "Наиболее удаленая точка:";
			// 
			// length2
			// 
			this.length2.AutoSize = true;
			this.length2.Location = new System.Drawing.Point(185, 189);
			this.length2.Name = "length2";
			this.length2.Size = new System.Drawing.Size(0, 17);
			this.length2.TabIndex = 11;
			// 
			// length2_label
			// 
			this.length2_label.AutoSize = true;
			this.length2_label.Location = new System.Drawing.Point(15, 189);
			this.length2_label.Name = "length2_label";
			this.length2_label.Size = new System.Drawing.Size(167, 17);
			this.length2_label.TabIndex = 10;
			this.length2_label.Text = "Длина второго отрезка:";
			// 
			// length1
			// 
			this.length1.AutoSize = true;
			this.length1.Location = new System.Drawing.Point(185, 161);
			this.length1.Name = "length1";
			this.length1.Size = new System.Drawing.Size(0, 17);
			this.length1.TabIndex = 9;
			// 
			// length1_label
			// 
			this.length1_label.AutoSize = true;
			this.length1_label.Location = new System.Drawing.Point(15, 161);
			this.length1_label.Name = "length1_label";
			this.length1_label.Size = new System.Drawing.Size(168, 17);
			this.length1_label.TabIndex = 8;
			this.length1_label.Text = "Длина первого отрезка:";
			// 
			// Y1
			// 
			this.Y1.Location = new System.Drawing.Point(131, 69);
			this.Y1.Name = "Y1";
			this.Y1.Size = new System.Drawing.Size(100, 22);
			this.Y1.TabIndex = 7;
			this.Y1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1_KeyPress);
			// 
			// X2
			// 
			this.X2.Location = new System.Drawing.Point(131, 97);
			this.X2.Name = "X2";
			this.X2.Size = new System.Drawing.Size(100, 22);
			this.X2.TabIndex = 6;
			this.X2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1_KeyPress);
			// 
			// Y2
			// 
			this.Y2.Location = new System.Drawing.Point(131, 126);
			this.Y2.Name = "Y2";
			this.Y2.Size = new System.Drawing.Size(100, 22);
			this.Y2.TabIndex = 5;
			this.Y2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1_KeyPress);
			// 
			// X1
			// 
			this.X1.Location = new System.Drawing.Point(131, 43);
			this.X1.Name = "X1";
			this.X1.Size = new System.Drawing.Size(100, 22);
			this.X1.TabIndex = 4;
			this.X1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1_KeyPress);
			// 
			// y1_label
			// 
			this.y1_label.AutoSize = true;
			this.y1_label.Location = new System.Drawing.Point(15, 70);
			this.y1_label.Name = "y1_label";
			this.y1_label.Size = new System.Drawing.Size(111, 17);
			this.y1_label.TabIndex = 3;
			this.y1_label.Text = "Координата y1:";
			// 
			// x2_label
			// 
			this.x2_label.AutoSize = true;
			this.x2_label.Location = new System.Drawing.Point(15, 97);
			this.x2_label.Name = "x2_label";
			this.x2_label.Size = new System.Drawing.Size(110, 17);
			this.x2_label.TabIndex = 2;
			this.x2_label.Text = "Координата х2:";
			// 
			// y2_label
			// 
			this.y2_label.AutoSize = true;
			this.y2_label.Location = new System.Drawing.Point(15, 126);
			this.y2_label.Name = "y2_label";
			this.y2_label.Size = new System.Drawing.Size(111, 17);
			this.y2_label.TabIndex = 1;
			this.y2_label.Text = "Координата y2:";
			// 
			// x1_label
			// 
			this.x1_label.AutoSize = true;
			this.x1_label.Location = new System.Drawing.Point(15, 43);
			this.x1_label.Name = "x1_label";
			this.x1_label.Size = new System.Drawing.Size(110, 17);
			this.x1_label.TabIndex = 0;
			this.x1_label.Text = "Координата х1:";
			// 
			// task2
			// 
			this.task2.Controls.Add(this.tabel);
			this.task2.Controls.Add(this.step);
			this.task2.Controls.Add(this.step_label);
			this.task2.Controls.Add(this.border2);
			this.task2.Controls.Add(this.border1);
			this.task2.Controls.Add(this.border2_label);
			this.task2.Controls.Add(this.border1_label);
			this.task2.Controls.Add(this.calculate2);
			this.task2.Location = new System.Drawing.Point(319, 12);
			this.task2.Name = "task2";
			this.task2.Size = new System.Drawing.Size(312, 297);
			this.task2.TabIndex = 1;
			this.task2.TabStop = false;
			this.task2.Text = "Задание 2";
			// 
			// tabel
			// 
			this.tabel.Location = new System.Drawing.Point(22, 131);
			this.tabel.Name = "tabel";
			this.tabel.Size = new System.Drawing.Size(263, 96);
			this.tabel.TabIndex = 7;
			this.tabel.Text = "";
			// 
			// step
			// 
			this.step.Location = new System.Drawing.Point(216, 97);
			this.step.Name = "step";
			this.step.Size = new System.Drawing.Size(90, 22);
			this.step.TabIndex = 6;
			this.step.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1_KeyPress);
			// 
			// step_label
			// 
			this.step_label.AutoSize = true;
			this.step_label.Location = new System.Drawing.Point(15, 97);
			this.step_label.Name = "step_label";
			this.step_label.Size = new System.Drawing.Size(40, 17);
			this.step_label.TabIndex = 5;
			this.step_label.Text = "Шаг: ";
			// 
			// border2
			// 
			this.border2.Location = new System.Drawing.Point(216, 69);
			this.border2.Name = "border2";
			this.border2.Size = new System.Drawing.Size(90, 22);
			this.border2.TabIndex = 4;
			this.border2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1_KeyPress);
			// 
			// border1
			// 
			this.border1.Location = new System.Drawing.Point(216, 43);
			this.border1.Name = "border1";
			this.border1.Size = new System.Drawing.Size(90, 22);
			this.border1.TabIndex = 3;
			this.border1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1_KeyPress);
			// 
			// border2_label
			// 
			this.border2_label.AutoSize = true;
			this.border2_label.Location = new System.Drawing.Point(15, 70);
			this.border2_label.Name = "border2_label";
			this.border2_label.Size = new System.Drawing.Size(199, 17);
			this.border2_label.TabIndex = 2;
			this.border2_label.Text = "Верхняя граница диапазона:";
			// 
			// border1_label
			// 
			this.border1_label.AutoSize = true;
			this.border1_label.Location = new System.Drawing.Point(15, 43);
			this.border1_label.Name = "border1_label";
			this.border1_label.Size = new System.Drawing.Size(195, 17);
			this.border1_label.TabIndex = 1;
			this.border1_label.Text = "Нижняя граница диапазона:";
			// 
			// calculate2
			// 
			this.calculate2.Location = new System.Drawing.Point(159, 246);
			this.calculate2.Name = "calculate2";
			this.calculate2.Size = new System.Drawing.Size(147, 38);
			this.calculate2.TabIndex = 0;
			this.calculate2.Text = "Расчитать";
			this.calculate2.UseVisualStyleBackColor = true;
			this.calculate2.Click += new System.EventHandler(this.calculate2_Click);
			// 
			// practic3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(646, 317);
			this.Controls.Add(this.task2);
			this.Controls.Add(this.task1);
			this.Name = "practic3";
			this.Text = "Практикум3";
			this.task1.ResumeLayout(false);
			this.task1.PerformLayout();
			this.task2.ResumeLayout(false);
			this.task2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox task1;
		private System.Windows.Forms.Button calculate;
		private System.Windows.Forms.Label dot;
		private System.Windows.Forms.Label dot_label;
		private System.Windows.Forms.Label length2;
		private System.Windows.Forms.Label length2_label;
		private System.Windows.Forms.Label length1;
		private System.Windows.Forms.Label length1_label;
		private System.Windows.Forms.TextBox Y1;
		private System.Windows.Forms.TextBox X2;
		private System.Windows.Forms.TextBox Y2;
		private System.Windows.Forms.TextBox X1;
		private System.Windows.Forms.Label y1_label;
		private System.Windows.Forms.Label x2_label;
		private System.Windows.Forms.Label y2_label;
		private System.Windows.Forms.Label x1_label;
		private System.Windows.Forms.GroupBox task2;
		private System.Windows.Forms.RichTextBox tabel;
		private System.Windows.Forms.TextBox step;
		private System.Windows.Forms.Label step_label;
		private System.Windows.Forms.TextBox border2;
		private System.Windows.Forms.TextBox border1;
		private System.Windows.Forms.Label border2_label;
		private System.Windows.Forms.Label border1_label;
		private System.Windows.Forms.Button calculate2;
	}
}

