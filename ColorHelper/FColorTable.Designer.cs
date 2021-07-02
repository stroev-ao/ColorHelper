namespace ColorHelper
{
    partial class FColorTable
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
            this.dgv_Colors = new System.Windows.Forms.DataGridView();
            this.b_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Colors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Colors
            // 
            this.dgv_Colors.AllowUserToAddRows = false;
            this.dgv_Colors.AllowUserToDeleteRows = false;
            this.dgv_Colors.AllowUserToResizeColumns = false;
            this.dgv_Colors.AllowUserToResizeRows = false;
            this.dgv_Colors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Colors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Colors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Colors.Location = new System.Drawing.Point(12, 12);
            this.dgv_Colors.MultiSelect = false;
            this.dgv_Colors.Name = "dgv_Colors";
            this.dgv_Colors.RowHeadersVisible = false;
            this.dgv_Colors.Size = new System.Drawing.Size(440, 548);
            this.dgv_Colors.TabIndex = 0;
            this.dgv_Colors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Colors_CellContentClick);
            // 
            // b_Close
            // 
            this.b_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_Close.Location = new System.Drawing.Point(377, 566);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(75, 23);
            this.b_Close.TabIndex = 1;
            this.b_Close.Text = "Close";
            this.b_Close.UseVisualStyleBackColor = true;
            // 
            // FColorTable
            // 
            this.AcceptButton = this.b_Close;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.b_Close;
            this.ClientSize = new System.Drawing.Size(464, 601);
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.dgv_Colors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FColorTable";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Color Table";
            this.Load += new System.EventHandler(this.FColorTable_Load);
            this.Shown += new System.EventHandler(this.FColorTable_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Colors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Colors;
        private System.Windows.Forms.Button b_Close;
    }
}