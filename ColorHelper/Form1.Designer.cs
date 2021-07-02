namespace ColorHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_Color1RGB = new System.Windows.Forms.TextBox();
            this.b_Clear1RGB = new System.Windows.Forms.Button();
            this.b_Palette = new System.Windows.Forms.Button();
            this.tb_Color2RGB = new System.Windows.Forms.TextBox();
            this.tb_Color1HEX = new System.Windows.Forms.TextBox();
            this.tb_Color2HEX = new System.Windows.Forms.TextBox();
            this.b_Clear1HEX = new System.Windows.Forms.Button();
            this.b_ColorTable = new System.Windows.Forms.Button();
            this.pb_Color2 = new System.Windows.Forms.PictureBox();
            this.b_Copy2HEX = new System.Windows.Forms.Button();
            this.b_Copy2RGB = new System.Windows.Forms.Button();
            this.b_Copy1HEX = new System.Windows.Forms.Button();
            this.b_Copy1RGB = new System.Windows.Forms.Button();
            this.pb_Color1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Color2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Color1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Color1RGB
            // 
            this.tb_Color1RGB.Location = new System.Drawing.Point(64, 12);
            this.tb_Color1RGB.Margin = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.tb_Color1RGB.Name = "tb_Color1RGB";
            this.tb_Color1RGB.Size = new System.Drawing.Size(100, 20);
            this.tb_Color1RGB.TabIndex = 0;
            this.tb_Color1RGB.TextChanged += new System.EventHandler(this.tb_Color1_TextChanged);
            // 
            // b_Clear1RGB
            // 
            this.b_Clear1RGB.BackColor = System.Drawing.Color.White;
            this.b_Clear1RGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Clear1RGB.Location = new System.Drawing.Point(163, 12);
            this.b_Clear1RGB.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.b_Clear1RGB.Name = "b_Clear1RGB";
            this.b_Clear1RGB.Size = new System.Drawing.Size(20, 20);
            this.b_Clear1RGB.TabIndex = 1;
            this.b_Clear1RGB.TabStop = false;
            this.b_Clear1RGB.Text = "X";
            this.b_Clear1RGB.UseVisualStyleBackColor = false;
            this.b_Clear1RGB.Click += new System.EventHandler(this.b_Clear1_Click);
            // 
            // b_Palette
            // 
            this.b_Palette.Location = new System.Drawing.Point(215, 11);
            this.b_Palette.Name = "b_Palette";
            this.b_Palette.Size = new System.Drawing.Size(75, 47);
            this.b_Palette.TabIndex = 6;
            this.b_Palette.Text = "Palette";
            this.b_Palette.UseVisualStyleBackColor = true;
            this.b_Palette.Click += new System.EventHandler(this.b_Palette_Click);
            // 
            // tb_Color2RGB
            // 
            this.tb_Color2RGB.Location = new System.Drawing.Point(64, 64);
            this.tb_Color2RGB.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.tb_Color2RGB.Name = "tb_Color2RGB";
            this.tb_Color2RGB.ReadOnly = true;
            this.tb_Color2RGB.Size = new System.Drawing.Size(119, 20);
            this.tb_Color2RGB.TabIndex = 7;
            this.tb_Color2RGB.TabStop = false;
            this.tb_Color2RGB.TextChanged += new System.EventHandler(this.tb_Color2RGB_TextChanged);
            // 
            // tb_Color1HEX
            // 
            this.tb_Color1HEX.Location = new System.Drawing.Point(64, 38);
            this.tb_Color1HEX.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.tb_Color1HEX.Name = "tb_Color1HEX";
            this.tb_Color1HEX.Size = new System.Drawing.Size(100, 20);
            this.tb_Color1HEX.TabIndex = 3;
            this.tb_Color1HEX.TextChanged += new System.EventHandler(this.tb_Color1HEX_TextChanged);
            // 
            // tb_Color2HEX
            // 
            this.tb_Color2HEX.Location = new System.Drawing.Point(64, 90);
            this.tb_Color2HEX.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.tb_Color2HEX.Name = "tb_Color2HEX";
            this.tb_Color2HEX.ReadOnly = true;
            this.tb_Color2HEX.Size = new System.Drawing.Size(119, 20);
            this.tb_Color2HEX.TabIndex = 9;
            this.tb_Color2HEX.TabStop = false;
            // 
            // b_Clear1HEX
            // 
            this.b_Clear1HEX.BackColor = System.Drawing.Color.White;
            this.b_Clear1HEX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Clear1HEX.Location = new System.Drawing.Point(163, 38);
            this.b_Clear1HEX.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.b_Clear1HEX.Name = "b_Clear1HEX";
            this.b_Clear1HEX.Size = new System.Drawing.Size(20, 20);
            this.b_Clear1HEX.TabIndex = 4;
            this.b_Clear1HEX.TabStop = false;
            this.b_Clear1HEX.Text = "X";
            this.b_Clear1HEX.UseVisualStyleBackColor = false;
            this.b_Clear1HEX.Click += new System.EventHandler(this.b_Clear1HEX_Click);
            // 
            // b_ColorTable
            // 
            this.b_ColorTable.Location = new System.Drawing.Point(215, 61);
            this.b_ColorTable.Name = "b_ColorTable";
            this.b_ColorTable.Size = new System.Drawing.Size(75, 49);
            this.b_ColorTable.TabIndex = 11;
            this.b_ColorTable.Text = "Color Table";
            this.b_ColorTable.UseVisualStyleBackColor = true;
            this.b_ColorTable.Click += new System.EventHandler(this.b_ColorTable_Click);
            // 
            // pb_Color2
            // 
            this.pb_Color2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Color2.Location = new System.Drawing.Point(12, 64);
            this.pb_Color2.Name = "pb_Color2";
            this.pb_Color2.Size = new System.Drawing.Size(40, 46);
            this.pb_Color2.TabIndex = 4;
            this.pb_Color2.TabStop = false;
            // 
            // b_Copy2HEX
            // 
            this.b_Copy2HEX.BackColor = System.Drawing.Color.White;
            this.b_Copy2HEX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Copy2HEX.Image = global::ColorHelper.Properties.Resources.copy;
            this.b_Copy2HEX.Location = new System.Drawing.Point(189, 90);
            this.b_Copy2HEX.Name = "b_Copy2HEX";
            this.b_Copy2HEX.Size = new System.Drawing.Size(20, 20);
            this.b_Copy2HEX.TabIndex = 10;
            this.b_Copy2HEX.TabStop = false;
            this.b_Copy2HEX.UseVisualStyleBackColor = false;
            this.b_Copy2HEX.Click += new System.EventHandler(this.b_Copy2HEX_Click);
            // 
            // b_Copy2RGB
            // 
            this.b_Copy2RGB.BackColor = System.Drawing.Color.White;
            this.b_Copy2RGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Copy2RGB.Image = global::ColorHelper.Properties.Resources.copy;
            this.b_Copy2RGB.Location = new System.Drawing.Point(189, 64);
            this.b_Copy2RGB.Name = "b_Copy2RGB";
            this.b_Copy2RGB.Size = new System.Drawing.Size(20, 20);
            this.b_Copy2RGB.TabIndex = 8;
            this.b_Copy2RGB.TabStop = false;
            this.b_Copy2RGB.UseVisualStyleBackColor = false;
            this.b_Copy2RGB.Click += new System.EventHandler(this.b_Copy2RGB_Click);
            // 
            // b_Copy1HEX
            // 
            this.b_Copy1HEX.BackColor = System.Drawing.Color.White;
            this.b_Copy1HEX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Copy1HEX.Image = global::ColorHelper.Properties.Resources.copy;
            this.b_Copy1HEX.Location = new System.Drawing.Point(189, 38);
            this.b_Copy1HEX.Name = "b_Copy1HEX";
            this.b_Copy1HEX.Size = new System.Drawing.Size(20, 20);
            this.b_Copy1HEX.TabIndex = 5;
            this.b_Copy1HEX.TabStop = false;
            this.b_Copy1HEX.UseVisualStyleBackColor = false;
            this.b_Copy1HEX.Click += new System.EventHandler(this.b_Copy1HEX_Click);
            // 
            // b_Copy1RGB
            // 
            this.b_Copy1RGB.BackColor = System.Drawing.Color.White;
            this.b_Copy1RGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Copy1RGB.Image = global::ColorHelper.Properties.Resources.copy;
            this.b_Copy1RGB.Location = new System.Drawing.Point(189, 12);
            this.b_Copy1RGB.Name = "b_Copy1RGB";
            this.b_Copy1RGB.Size = new System.Drawing.Size(20, 20);
            this.b_Copy1RGB.TabIndex = 2;
            this.b_Copy1RGB.TabStop = false;
            this.b_Copy1RGB.UseVisualStyleBackColor = false;
            this.b_Copy1RGB.Click += new System.EventHandler(this.b_Copy1RGB_Click);
            // 
            // pb_Color1
            // 
            this.pb_Color1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Color1.Location = new System.Drawing.Point(12, 12);
            this.pb_Color1.Name = "pb_Color1";
            this.pb_Color1.Size = new System.Drawing.Size(40, 46);
            this.pb_Color1.TabIndex = 1;
            this.pb_Color1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 122);
            this.Controls.Add(this.b_ColorTable);
            this.Controls.Add(this.tb_Color2HEX);
            this.Controls.Add(this.tb_Color1HEX);
            this.Controls.Add(this.tb_Color2RGB);
            this.Controls.Add(this.pb_Color2);
            this.Controls.Add(this.b_Palette);
            this.Controls.Add(this.b_Clear1HEX);
            this.Controls.Add(this.b_Copy2HEX);
            this.Controls.Add(this.b_Copy2RGB);
            this.Controls.Add(this.b_Copy1HEX);
            this.Controls.Add(this.b_Copy1RGB);
            this.Controls.Add(this.b_Clear1RGB);
            this.Controls.Add(this.pb_Color1);
            this.Controls.Add(this.tb_Color1RGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Helper";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Color2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Color1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Color1RGB;
        private System.Windows.Forms.PictureBox pb_Color1;
        private System.Windows.Forms.Button b_Clear1RGB;
        private System.Windows.Forms.Button b_Palette;
        private System.Windows.Forms.PictureBox pb_Color2;
        private System.Windows.Forms.TextBox tb_Color2RGB;
        private System.Windows.Forms.TextBox tb_Color1HEX;
        private System.Windows.Forms.TextBox tb_Color2HEX;
        private System.Windows.Forms.Button b_Clear1HEX;
        private System.Windows.Forms.Button b_Copy1RGB;
        private System.Windows.Forms.Button b_Copy1HEX;
        private System.Windows.Forms.Button b_Copy2RGB;
        private System.Windows.Forms.Button b_Copy2HEX;
        private System.Windows.Forms.Button b_ColorTable;
    }
}

