using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorHelper
{
    public partial class FColorTable : Form
    {
        public FColorTable()
        {
            InitializeComponent();
        }

        private void FColorTable_Load(object sender, EventArgs e)
        {
            dgv_Colors.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Color", HeaderText = "Color", ReadOnly = true });
            dgv_Colors.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ColorName", HeaderText = "Color Name", ReadOnly = true });
            dgv_Colors.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ColorRGB", HeaderText = "RGB", ReadOnly = true });
            dgv_Colors.Columns.Add(new DataGridViewButtonColumn() { Name = "Copy", HeaderText = "Operation" });

            var colors = Enum.GetValues(typeof(KnownColor));
            foreach (KnownColor color in colors)
            {
                Color c = Color.FromKnownColor(color);
                dgv_Colors.Rows.Add(new object[] { "", c.Name, string.Format("{0}, {1}, {2}", c.R, c.G, c.B), "Copy" });
                dgv_Colors.Rows[dgv_Colors.Rows.Count - 1].Cells[0].Style.BackColor = c;
                dgv_Colors.Rows[dgv_Colors.Rows.Count - 1].Tag = c;
            }
        }

        private void FColorTable_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void dgv_Colors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Colors.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Clipboard.SetText(dgv_Colors.Rows[e.RowIndex].Cells[1].Value.ToString());
                this.Tag = dgv_Colors.Rows[e.RowIndex].Tag;
                //Close();
            }
        }
    }
}
