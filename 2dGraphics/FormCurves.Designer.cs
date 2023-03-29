namespace _2dGraphics
{
    partial class FormCurves
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCurves));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnMovement = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnBeizers = new System.Windows.Forms.Button();
            this.btnBrokenLine = new System.Windows.Forms.Button();
            this.btnCurve = new System.Windows.Forms.Button();
            this.btnParams = new System.Windows.Forms.Button();
            this.btnPoints = new System.Windows.Forms.Button();
            this.myPictureBox1 = new _2dGraphics.MyPictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Gray;
            this.panelMenu.Controls.Add(this.btnSave);
            this.panelMenu.Controls.Add(this.btnClean);
            this.panelMenu.Controls.Add(this.btnMovement);
            this.panelMenu.Controls.Add(this.btnFill);
            this.panelMenu.Controls.Add(this.btnBeizers);
            this.panelMenu.Controls.Add(this.btnBrokenLine);
            this.panelMenu.Controls.Add(this.btnCurve);
            this.panelMenu.Controls.Add(this.btnParams);
            this.panelMenu.Controls.Add(this.btnPoints);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(254, 757);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(0, 521);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(254, 68);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Сохранение";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClean.Location = new System.Drawing.Point(0, 595);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(254, 71);
            this.btnClean.TabIndex = 7;
            this.btnClean.Text = "Очистить";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnMovement
            // 
            this.btnMovement.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMovement.Location = new System.Drawing.Point(0, 447);
            this.btnMovement.Name = "btnMovement";
            this.btnMovement.Size = new System.Drawing.Size(254, 68);
            this.btnMovement.TabIndex = 6;
            this.btnMovement.Text = "Движение";
            this.btnMovement.UseVisualStyleBackColor = true;
            this.btnMovement.Click += new System.EventHandler(this.btnMovement_Click);
            // 
            // btnFill
            // 
            this.btnFill.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFill.Location = new System.Drawing.Point(-3, 373);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(254, 68);
            this.btnFill.TabIndex = 5;
            this.btnFill.Text = "Заполненная";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnBeizers
            // 
            this.btnBeizers.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBeizers.Location = new System.Drawing.Point(0, 299);
            this.btnBeizers.Name = "btnBeizers";
            this.btnBeizers.Size = new System.Drawing.Size(254, 68);
            this.btnBeizers.TabIndex = 4;
            this.btnBeizers.Text = "Безье";
            this.btnBeizers.UseVisualStyleBackColor = true;
            this.btnBeizers.Click += new System.EventHandler(this.btnBeizers_Click);
            // 
            // btnBrokenLine
            // 
            this.btnBrokenLine.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBrokenLine.Location = new System.Drawing.Point(0, 225);
            this.btnBrokenLine.Name = "btnBrokenLine";
            this.btnBrokenLine.Size = new System.Drawing.Size(254, 68);
            this.btnBrokenLine.TabIndex = 3;
            this.btnBrokenLine.Text = "Ломаная";
            this.btnBrokenLine.UseVisualStyleBackColor = true;
            this.btnBrokenLine.Click += new System.EventHandler(this.btnBrokenLine_Click);
            // 
            // btnCurve
            // 
            this.btnCurve.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCurve.Location = new System.Drawing.Point(0, 151);
            this.btnCurve.Name = "btnCurve";
            this.btnCurve.Size = new System.Drawing.Size(254, 68);
            this.btnCurve.TabIndex = 2;
            this.btnCurve.Text = "Кривая";
            this.btnCurve.UseVisualStyleBackColor = true;
            this.btnCurve.Click += new System.EventHandler(this.btnCurve_Click);
            // 
            // btnParams
            // 
            this.btnParams.AutoSize = true;
            this.btnParams.BackColor = System.Drawing.Color.White;
            this.btnParams.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnParams.Location = new System.Drawing.Point(0, 77);
            this.btnParams.Name = "btnParams";
            this.btnParams.Size = new System.Drawing.Size(254, 68);
            this.btnParams.TabIndex = 1;
            this.btnParams.Text = "Параметры";
            this.btnParams.UseVisualStyleBackColor = false;
            this.btnParams.Click += new System.EventHandler(this.btnParams_Click);
            // 
            // btnPoints
            // 
            this.btnPoints.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPoints.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPoints.Location = new System.Drawing.Point(0, 3);
            this.btnPoints.Name = "btnPoints";
            this.btnPoints.Size = new System.Drawing.Size(254, 68);
            this.btnPoints.TabIndex = 0;
            this.btnPoints.Text = "Точки";
            this.btnPoints.UseVisualStyleBackColor = false;
            this.btnPoints.Click += new System.EventHandler(this.btnPoints_Click);
            // 
            // myPictureBox1
            // 
            this.myPictureBox1.BackColor = System.Drawing.Color.Black;
            this.myPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myPictureBox1.Location = new System.Drawing.Point(254, 0);
            this.myPictureBox1.Name = "myPictureBox1";
            this.myPictureBox1.Size = new System.Drawing.Size(934, 757);
            this.myPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.myPictureBox1.TabIndex = 1;
            this.myPictureBox1.TabStop = false;
            this.myPictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawPoint);
            this.myPictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChoosePoint);
            this.myPictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovePoint);
            this.myPictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShiftPoint);
            // 
            // FormCurves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1188, 757);
            this.Controls.Add(this.myPictureBox1);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCurves";
            this.Text = "Движение кривых";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formСurves_KeyDown);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelMenu;
        private Button btnPoints;
        private Button btnClean;
        private Button btnMovement;
        private Button btnFill;
        private Button btnBeizers;
        private Button btnBrokenLine;
        private Button btnCurve;
        private Button btnParams;
        private Button btnSave;
        internal MyPictureBox myPictureBox1;
    }
}