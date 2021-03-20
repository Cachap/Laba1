
namespace AutoClick
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
			this.Start = new System.Windows.Forms.Button();
			this.Stop = new System.Windows.Forms.Button();
			this.Info = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.CurrentCount = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.MessageText = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.CountMessage = new System.Windows.Forms.TextBox();
			this.Delay = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.RandomAnecdot = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// Start
			// 
			this.Start.BackColor = System.Drawing.Color.DarkSlateGray;
			this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Start.Font = new System.Drawing.Font("Century Gothic", 27.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Start.ForeColor = System.Drawing.Color.LawnGreen;
			this.Start.Location = new System.Drawing.Point(12, 467);
			this.Start.Name = "Start";
			this.Start.Size = new System.Drawing.Size(513, 208);
			this.Start.TabIndex = 0;
			this.Start.Text = "Start(F5)";
			this.Start.UseVisualStyleBackColor = false;
			this.Start.Click += new System.EventHandler(this.button1_Click);
			// 
			// Stop
			// 
			this.Stop.BackColor = System.Drawing.Color.DarkSlateGray;
			this.Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Stop.Font = new System.Drawing.Font("Century Gothic", 27.9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Stop.ForeColor = System.Drawing.Color.OrangeRed;
			this.Stop.Location = new System.Drawing.Point(531, 467);
			this.Stop.Name = "Stop";
			this.Stop.Size = new System.Drawing.Size(555, 208);
			this.Stop.TabIndex = 1;
			this.Stop.Text = "Stop(F4)";
			this.Stop.UseVisualStyleBackColor = false;
			this.Stop.Click += new System.EventHandler(this.button2_Click);
			// 
			// Info
			// 
			this.Info.BackColor = System.Drawing.Color.Aquamarine;
			this.Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Info.Enabled = false;
			this.Info.ForeColor = System.Drawing.Color.Maroon;
			this.Info.Location = new System.Drawing.Point(22, 193);
			this.Info.Name = "Info";
			this.Info.Size = new System.Drawing.Size(835, 38);
			this.Info.TabIndex = 2;
			this.Info.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(470, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(490, 46);
			this.label1.TabIndex = 3;
			this.label1.Text = "Сообщений отправлено: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(300, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 32);
			this.label2.TabIndex = 4;
			// 
			// CurrentCount
			// 
			this.CurrentCount.BackColor = System.Drawing.Color.Aquamarine;
			this.CurrentCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CurrentCount.Enabled = false;
			this.CurrentCount.ForeColor = System.Drawing.Color.Maroon;
			this.CurrentCount.Location = new System.Drawing.Point(984, 20);
			this.CurrentCount.Name = "CurrentCount";
			this.CurrentCount.Size = new System.Drawing.Size(102, 38);
			this.CurrentCount.TabIndex = 5;
			this.CurrentCount.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(441, 55);
			this.label3.TabIndex = 6;
			this.label3.Text = "Текст сообщения: ";
			// 
			// MessageText
			// 
			this.MessageText.BackColor = System.Drawing.Color.Aquamarine;
			this.MessageText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MessageText.ForeColor = System.Drawing.Color.Maroon;
			this.MessageText.Location = new System.Drawing.Point(22, 63);
			this.MessageText.Multiline = true;
			this.MessageText.Name = "MessageText";
			this.MessageText.Size = new System.Drawing.Size(835, 124);
			this.MessageText.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(15, 245);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(400, 39);
			this.label4.TabIndex = 8;
			this.label4.Text = "Количество сообщений:";
			// 
			// CountMessage
			// 
			this.CountMessage.BackColor = System.Drawing.Color.Aquamarine;
			this.CountMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CountMessage.ForeColor = System.Drawing.Color.Maroon;
			this.CountMessage.Location = new System.Drawing.Point(478, 246);
			this.CountMessage.Name = "CountMessage";
			this.CountMessage.Size = new System.Drawing.Size(102, 38);
			this.CountMessage.TabIndex = 9;
			// 
			// Delay
			// 
			this.Delay.BackColor = System.Drawing.Color.Aquamarine;
			this.Delay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Delay.ForeColor = System.Drawing.Color.Maroon;
			this.Delay.Location = new System.Drawing.Point(248, 296);
			this.Delay.Name = "Delay";
			this.Delay.Size = new System.Drawing.Size(102, 38);
			this.Delay.TabIndex = 10;
			this.Delay.TextChanged += new System.EventHandler(this.Delay_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(15, 293);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(185, 39);
			this.label5.TabIndex = 11;
			this.label5.Text = "Задержка:";
			// 
			// RandomAnecdot
			// 
			this.RandomAnecdot.AutoSize = true;
			this.RandomAnecdot.Location = new System.Drawing.Point(12, 425);
			this.RandomAnecdot.Name = "RandomAnecdot";
			this.RandomAnecdot.Size = new System.Drawing.Size(316, 36);
			this.RandomAnecdot.TabIndex = 12;
			this.RandomAnecdot.Text = "Случайный анекдот";
			this.RandomAnecdot.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1098, 676);
			this.Controls.Add(this.RandomAnecdot);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Delay);
			this.Controls.Add(this.CountMessage);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.MessageText);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.CurrentCount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Info);
			this.Controls.Add(this.Stop);
			this.Controls.Add(this.Start);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "Form1";
			this.Text = "Spamer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Start;
		private System.Windows.Forms.Button Stop;
		private System.Windows.Forms.TextBox Info;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox CurrentCount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox MessageText;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox CountMessage;
		private System.Windows.Forms.TextBox Delay;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox RandomAnecdot;
	}
}

