namespace snake
{
    partial class Tail
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tail));
            this.Speed = new System.Windows.Forms.Label();
            this.Mark = new System.Windows.Forms.Label();
            this.Fuild = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textMark = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Fuild)).BeginInit();
            this.SuspendLayout();
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.BackColor = System.Drawing.Color.Orange;
            this.Speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Speed.Location = new System.Drawing.Point(29, 40);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(0, 36);
            this.Speed.TabIndex = 0;
            this.Speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mark
            // 
            this.Mark.AutoSize = true;
            this.Mark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Mark.ForeColor = System.Drawing.Color.White;
            this.Mark.Image = ((System.Drawing.Image)(resources.GetObject("Mark.Image")));
            this.Mark.Location = new System.Drawing.Point(35, 40);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(96, 36);
            this.Mark.TabIndex = 1;
            this.Mark.Text = "Очки:";
            // 
            // Fuild
            // 
            this.Fuild.BackColor = System.Drawing.Color.Snow;
            this.Fuild.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Fuild.BackgroundImage")));
            this.Fuild.Location = new System.Drawing.Point(30, 101);
            this.Fuild.Name = "Fuild";
            this.Fuild.Size = new System.Drawing.Size(640, 640);
            this.Fuild.TabIndex = 3;
            this.Fuild.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textMark
            // 
            this.textMark.AutoSize = true;
            this.textMark.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textMark.ForeColor = System.Drawing.Color.White;
            this.textMark.Image = ((System.Drawing.Image)(resources.GetObject("textMark.Image")));
            this.textMark.Location = new System.Drawing.Point(181, 40);
            this.textMark.MinimumSize = new System.Drawing.Size(100, 36);
            this.textMark.Name = "textMark";
            this.textMark.Size = new System.Drawing.Size(100, 36);
            this.textMark.TabIndex = 4;
            this.textMark.Text = "0";
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TimerLabel.ForeColor = System.Drawing.Color.White;
            this.TimerLabel.Image = ((System.Drawing.Image)(resources.GetObject("TimerLabel.Image")));
            this.TimerLabel.Location = new System.Drawing.Point(570, 40);
            this.TimerLabel.MinimumSize = new System.Drawing.Size(100, 36);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(100, 36);
            this.TimerLabel.TabIndex = 4;
            this.TimerLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(412, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Время:";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Tail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(682, 753);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.textMark);
            this.Controls.Add(this.Fuild);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mark);
            this.Controls.Add(this.Speed);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Aqua;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "Tail";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SNAKE";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tail_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Fuild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Speed;
        private System.Windows.Forms.Label Mark;
        private System.Windows.Forms.PictureBox Fuild;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label textMark;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
    }
}

