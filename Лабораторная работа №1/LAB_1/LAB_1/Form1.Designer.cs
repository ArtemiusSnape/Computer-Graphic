namespace CG_1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackRed = new System.Windows.Forms.TrackBar();
            this.trackGreen = new System.Windows.Forms.TrackBar();
            this.trackBlue = new System.Windows.Forms.TrackBar();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelZ = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.trackBarZ = new System.Windows.Forms.TrackBar();
            this.trackBarY = new System.Windows.Forms.TrackBar();
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.trackBarA = new System.Windows.Forms.TrackBar();
            this.trackBarL = new System.Windows.Forms.TrackBar();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelL = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonColorPicker = new System.Windows.Forms.Button();
            this.buttonRGB = new System.Windows.Forms.Button();
            this.buttonXYZ = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(182, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 124);
            this.panel1.TabIndex = 0;
            // 
            // trackRed
            // 
            this.trackRed.Location = new System.Drawing.Point(182, 160);
            this.trackRed.Maximum = 255;
            this.trackRed.Name = "trackRed";
            this.trackRed.Size = new System.Drawing.Size(370, 45);
            this.trackRed.TabIndex = 1;
            this.trackRed.Scroll += new System.EventHandler(this.trackRed_Scroll);
            // 
            // trackGreen
            // 
            this.trackGreen.Location = new System.Drawing.Point(182, 223);
            this.trackGreen.Maximum = 255;
            this.trackGreen.Name = "trackGreen";
            this.trackGreen.Size = new System.Drawing.Size(370, 45);
            this.trackGreen.TabIndex = 2;
            this.trackGreen.Scroll += new System.EventHandler(this.trackGreen_Scroll);
            // 
            // trackBlue
            // 
            this.trackBlue.BackColor = System.Drawing.SystemColors.Control;
            this.trackBlue.Location = new System.Drawing.Point(182, 280);
            this.trackBlue.Maximum = 255;
            this.trackBlue.Name = "trackBlue";
            this.trackBlue.Size = new System.Drawing.Size(370, 45);
            this.trackBlue.TabIndex = 3;
            this.trackBlue.Scroll += new System.EventHandler(this.trackBlue_Scroll);
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRed.Location = new System.Drawing.Point(121, 169);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(38, 18);
            this.labelRed.TabIndex = 4;
            this.labelRed.Text = "RED";
            this.labelRed.Click += new System.EventHandler(this.labelRed_Click);
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreen.Location = new System.Drawing.Point(121, 223);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(56, 18);
            this.labelGreen.TabIndex = 5;
            this.labelGreen.Text = "GREEN";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlue.Location = new System.Drawing.Point(121, 280);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(46, 18);
            this.labelBlue.TabIndex = 6;
            this.labelBlue.Text = "BLUE";
            // 
            // textBoxRed
            // 
            this.textBoxRed.Location = new System.Drawing.Point(574, 160);
            this.textBoxRed.Multiline = true;
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(50, 30);
            this.textBoxRed.TabIndex = 7;
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Location = new System.Drawing.Point(574, 224);
            this.textBoxGreen.Multiline = true;
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(50, 30);
            this.textBoxGreen.TabIndex = 8;
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Location = new System.Drawing.Point(574, 280);
            this.textBoxBlue.Multiline = true;
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(50, 30);
            this.textBoxBlue.TabIndex = 9;
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(574, 434);
            this.textBoxZ.Multiline = true;
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(50, 30);
            this.textBoxZ.TabIndex = 18;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(574, 380);
            this.textBoxY.Multiline = true;
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(50, 30);
            this.textBoxY.TabIndex = 17;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(574, 324);
            this.textBoxX.Multiline = true;
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(50, 30);
            this.textBoxX.TabIndex = 16;
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZ.Location = new System.Drawing.Point(119, 392);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(17, 18);
            this.labelZ.TabIndex = 15;
            this.labelZ.Text = "Z";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelY.Location = new System.Drawing.Point(119, 358);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(17, 18);
            this.labelY.TabIndex = 14;
            this.labelY.Text = "Y";
            this.labelY.Click += new System.EventHandler(this.labelY_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(119, 324);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(19, 18);
            this.labelX.TabIndex = 13;
            this.labelX.Text = "X";
            this.labelX.Click += new System.EventHandler(this.labelX_Click);
            // 
            // trackBarZ
            // 
            this.trackBarZ.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarZ.Location = new System.Drawing.Point(182, 392);
            this.trackBarZ.Maximum = 108;
            this.trackBarZ.Name = "trackBarZ";
            this.trackBarZ.Size = new System.Drawing.Size(370, 45);
            this.trackBarZ.TabIndex = 21;
            this.trackBarZ.Scroll += new System.EventHandler(this.trackBarZ_Scroll);
            // 
            // trackBarY
            // 
            this.trackBarY.Location = new System.Drawing.Point(182, 358);
            this.trackBarY.Maximum = 100;
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Size = new System.Drawing.Size(370, 45);
            this.trackBarY.TabIndex = 20;
            this.trackBarY.Scroll += new System.EventHandler(this.trackBarY_Scroll);
            // 
            // trackBarX
            // 
            this.trackBarX.Location = new System.Drawing.Point(182, 324);
            this.trackBarX.Maximum = 95;
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Size = new System.Drawing.Size(370, 45);
            this.trackBarX.TabIndex = 19;
            this.trackBarX.Scroll += new System.EventHandler(this.trackBarX_Scroll);
            // 
            // trackBarB
            // 
            this.trackBarB.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarB.Location = new System.Drawing.Point(182, 502);
            this.trackBarB.Maximum = 128;
            this.trackBarB.Minimum = -128;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(370, 45);
            this.trackBarB.TabIndex = 30;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarC_Scroll);
            // 
            // trackBarA
            // 
            this.trackBarA.Location = new System.Drawing.Point(182, 467);
            this.trackBarA.Maximum = 128;
            this.trackBarA.Minimum = -128;
            this.trackBarA.Name = "trackBarA";
            this.trackBarA.Size = new System.Drawing.Size(370, 45);
            this.trackBarA.TabIndex = 29;
            this.trackBarA.Scroll += new System.EventHandler(this.trackBarK_Scroll);
            // 
            // trackBarL
            // 
            this.trackBarL.Location = new System.Drawing.Point(182, 434);
            this.trackBarL.Maximum = 100;
            this.trackBarL.Name = "trackBarL";
            this.trackBarL.Size = new System.Drawing.Size(370, 45);
            this.trackBarL.TabIndex = 28;
            this.trackBarL.Scroll += new System.EventHandler(this.trackBarM_Scroll);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(574, 553);
            this.textBoxB.Multiline = true;
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(50, 30);
            this.textBoxB.TabIndex = 27;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(574, 506);
            this.textBoxA.Multiline = true;
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(50, 30);
            this.textBoxA.TabIndex = 26;
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(574, 470);
            this.textBoxL.Multiline = true;
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(50, 30);
            this.textBoxL.TabIndex = 25;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.Location = new System.Drawing.Point(121, 520);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(17, 18);
            this.labelB.TabIndex = 24;
            this.labelB.Text = "Y";
            this.labelB.Click += new System.EventHandler(this.labelB_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.Location = new System.Drawing.Point(115, 482);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(21, 18);
            this.labelA.TabIndex = 23;
            this.labelA.Text = "M";
            this.labelA.Click += new System.EventHandler(this.labelA_Click);
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelL.Location = new System.Drawing.Point(119, 447);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(17, 18);
            this.labelL.TabIndex = 22;
            this.labelL.Text = "C";
            // 
            // buttonColorPicker
            // 
            this.buttonColorPicker.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonColorPicker.ForeColor = System.Drawing.Color.Red;
            this.buttonColorPicker.Location = new System.Drawing.Point(574, 12);
            this.buttonColorPicker.Margin = new System.Windows.Forms.Padding(2);
            this.buttonColorPicker.Name = "buttonColorPicker";
            this.buttonColorPicker.Size = new System.Drawing.Size(173, 124);
            this.buttonColorPicker.TabIndex = 31;
            this.buttonColorPicker.Text = "Click and choose color";
            this.buttonColorPicker.UseVisualStyleBackColor = false;
            this.buttonColorPicker.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRGB
            // 
            this.buttonRGB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRGB.Location = new System.Drawing.Point(12, 198);
            this.buttonRGB.Name = "buttonRGB";
            this.buttonRGB.Size = new System.Drawing.Size(95, 43);
            this.buttonRGB.TabIndex = 32;
            this.buttonRGB.Text = "Transform";
            this.buttonRGB.UseVisualStyleBackColor = false;
            this.buttonRGB.Click += new System.EventHandler(this.buttonRGB_Click);
            // 
            // buttonXYZ
            // 
            this.buttonXYZ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonXYZ.Location = new System.Drawing.Point(12, 347);
            this.buttonXYZ.Name = "buttonXYZ";
            this.buttonXYZ.Size = new System.Drawing.Size(95, 43);
            this.buttonXYZ.TabIndex = 33;
            this.buttonXYZ.Text = "Transform";
            this.buttonXYZ.UseVisualStyleBackColor = false;
            this.buttonXYZ.Click += new System.EventHandler(this.buttonXYZ_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(12, 470);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 43);
            this.button3.TabIndex = 34;
            this.button3.Text = "Transform";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 688);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 553);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "K";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar1.Location = new System.Drawing.Point(182, 541);
            this.trackBar1.Maximum = 128;
            this.trackBar1.Minimum = -128;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(370, 45);
            this.trackBar1.TabIndex = 37;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonXYZ);
            this.Controls.Add(this.buttonRGB);
            this.Controls.Add(this.buttonColorPicker);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.trackBarA);
            this.Controls.Add(this.trackBarL);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxL);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelL);
            this.Controls.Add(this.trackBarZ);
            this.Controls.Add(this.trackBarY);
            this.Controls.Add(this.trackBarX);
            this.Controls.Add(this.textBoxZ);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxBlue);
            this.Controls.Add(this.textBoxGreen);
            this.Controls.Add(this.textBoxRed);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.trackBlue);
            this.Controls.Add(this.trackGreen);
            this.Controls.Add(this.trackRed);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Convert Color";
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackRed;
        private System.Windows.Forms.TrackBar trackGreen;
        private System.Windows.Forms.TrackBar trackBlue;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TrackBar trackBarZ;
        private System.Windows.Forms.TrackBar trackBarY;
        private System.Windows.Forms.TrackBar trackBarX;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TrackBar trackBarA;
        private System.Windows.Forms.TrackBar trackBarL;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonColorPicker;
        private System.Windows.Forms.Button buttonRGB;
        private System.Windows.Forms.Button buttonXYZ;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

