namespace _2dGraphics
{
    partial class ParamsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParamsForm));
            this.trcbarPointSize = new System.Windows.Forms.TrackBar();
            this.trcbarWidth = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPointColor = new System.Windows.Forms.Button();
            this.btnLineColor = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trcbarPointSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcbarWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // trcbarPointSize
            // 
            this.trcbarPointSize.BackColor = System.Drawing.SystemColors.GrayText;
            this.trcbarPointSize.Location = new System.Drawing.Point(28, 229);
            this.trcbarPointSize.Name = "trcbarPointSize";
            this.trcbarPointSize.Size = new System.Drawing.Size(270, 69);
            this.trcbarPointSize.TabIndex = 0;
            this.trcbarPointSize.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // trcbarWidth
            // 
            this.trcbarWidth.BackColor = System.Drawing.SystemColors.GrayText;
            this.trcbarWidth.Location = new System.Drawing.Point(28, 382);
            this.trcbarWidth.Name = "trcbarWidth";
            this.trcbarWidth.Size = new System.Drawing.Size(270, 69);
            this.trcbarWidth.TabIndex = 2;
            this.trcbarWidth.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(86, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 30);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Размер точек";
            // 
            // btnPointColor
            // 
            this.btnPointColor.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPointColor.Location = new System.Drawing.Point(75, 52);
            this.btnPointColor.Name = "btnPointColor";
            this.btnPointColor.Size = new System.Drawing.Size(162, 34);
            this.btnPointColor.TabIndex = 6;
            this.btnPointColor.Text = "Цвет точек";
            this.btnPointColor.UseVisualStyleBackColor = true;
            this.btnPointColor.Click += new System.EventHandler(this.btnPointColor_Click);
            // 
            // btnLineColor
            // 
            this.btnLineColor.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLineColor.Location = new System.Drawing.Point(74, 108);
            this.btnLineColor.Name = "btnLineColor";
            this.btnLineColor.Size = new System.Drawing.Size(162, 34);
            this.btnLineColor.TabIndex = 7;
            this.btnLineColor.Text = "Цвет линий";
            this.btnLineColor.UseVisualStyleBackColor = true;
            this.btnLineColor.Click += new System.EventHandler(this.btnLineColor_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(75, 339);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 30);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Ширина линий";
            // 
            // ParamsForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(323, 489);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnLineColor);
            this.Controls.Add(this.btnPointColor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trcbarWidth);
            this.Controls.Add(this.trcbarPointSize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "ParamsForm";
            this.Text = "Настройки параметров";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParamsForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trcbarPointSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcbarWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar trcbarPointSize;
        private TrackBar trcbarWidth;
        private TextBox textBox1;
        private Button btnPointColor;
        private Button btnLineColor;
        private TextBox textBox2;
    }
}