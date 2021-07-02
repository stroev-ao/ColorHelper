using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace ColorHelper
{
    public partial class Form1 : Form
    {
        const string TITLE = "Color Helper";
        //KeyboardHook keyboardHook;
        CHotKeyManager keyManager;
        Color lastColor;
        bool initialize;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //keyboardHook = new KeyboardHook();
            keyManager = new CHotKeyManager(this.Handle);
            keyManager.Register(Keys.PrintScreen, CHotKeyManager.MOD_CONTROL, GetText);

            // register the event that is fired after the key press.
            //keyboardHook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);

            //// register the control + alt + F12 combination as hot key.
            //keyboardHook.RegisterHotKey(ColorHelper.ModifierKeys.Control | ColorHelper.ModifierKeys.Alt, Keys.C);

            tb_Color1RGB.Text = "255, 255, 255";
            tb_Color2RGB.Text = "0, 0, 0";
        }

        //void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        //{
        //    this.Activate();
        //    this.Focus();

        //    if (Clipboard.ContainsText())
        //    {
        //        string text = Clipboard.GetText();

        //        if (text.Contains(","))
        //            SetNewColor(text);
        //        else
        //            SetNewColor1(text);
        //    }
        //}

        private Brush GetBrushFromText(string text, bool first = false)
        {
            Brush brush = new HatchBrush(HatchStyle.BackwardDiagonal, Color.FromArgb(127, 255, 0, 0), Color.FromArgb(127, 0, 0, 0));
            byte[] rgb = new byte[3];
            string[] parts = null;

            try
            {
                parts = text.Replace(" ", "").Split(',');
            }
            catch
            {
                return brush;
            }

            if (parts.Length != 3)
                return brush;

            for (int i = 0; i < parts.Length; i++)
                if (!byte.TryParse(parts[i], out rgb[i]))
                    return brush;

            if (first)
            {
                lastColor = Color.FromArgb(rgb[0], rgb[1], rgb[2]);
                brush = new SolidBrush(lastColor);
            }
            else
                brush = new SolidBrush(Color.FromArgb(rgb[0], rgb[1], rgb[2]));

            return brush;
        }

        private Brush GetBrushFromHext(string text, bool first = false)
        {
            Brush brush = new HatchBrush(HatchStyle.BackwardDiagonal, Color.FromArgb(127, 255, 0, 0), Color.FromArgb(127, 0, 0, 0));
            byte[] rgb = new byte[3];
            string[] parts = null;

            try
            {
                parts = text.Replace(" ", "").Split(2);
            }
            catch
            {
                return brush;
            }

            if (parts.Length != 3)
                return brush;

            for (int i = 0; i < parts.Length; i++)
                try
                {
                    rgb[i] = byte.Parse(parts[i], System.Globalization.NumberStyles.HexNumber);
                }
                catch
                {
                    return brush;
                }

            if (first)
            {
                lastColor = Color.FromArgb(rgb[0], rgb[1], rgb[2]);
                brush = new SolidBrush(lastColor);
            }
            else
                brush = new SolidBrush(Color.FromArgb(rgb[0], rgb[1], rgb[2]));

            return brush;
        }

        private void DrawColor(PictureBox pictureBox, Brush brush)
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(brush, 0, 0, bmp.Width, bmp.Height);
            g.Dispose();
            pictureBox.Image = bmp;
        }

        private void tb_Color1_TextChanged(object sender, EventArgs e)
        {
            if (initialize)
                return;

            initialize = true;

            DrawColor(pb_Color1, GetBrushFromText(tb_Color1RGB.Text, true));
            tb_Color1HEX.Text = ByteToHex(lastColor);

            initialize = false;
        }

        private void b_Clear1_Click(object sender, EventArgs e)
        {
            tb_Color1RGB.Text = "";
            tb_Color1RGB.Focus();
        }

        private void b_Palette_Click(object sender, EventArgs e)
        {
            initialize = true;

            using (ColorDialog dialog = new ColorDialog())
            {
                if (DialogResult.OK != dialog.ShowDialog())
                {
                    initialize = false;

                    return;
                }

                initialize = false;

                SetNewColor(dialog.Color.GetText());

                initialize = true;
            }
        }

        private void SetNewColor(string color)
        {
            tb_Color2RGB.Text = lastColor.GetText();
            tb_Color2HEX.Text = ByteToHex(lastColor);
            tb_Color1RGB.Text = color;
        }

        private void SetNewColor1(string color)
        {
            tb_Color2RGB.Text = lastColor.GetText();
            tb_Color2HEX.Text = ByteToHex(lastColor);
            tb_Color1HEX.Text = color;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            SetOpacity(1, 0.2);
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if (initialize)
                return;

            SetOpacity(0.2, 0.1);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Deactivate -= Form1_Deactivate;
        }

        private void SetOpacity(double opacity, double delta = 0.05)
        {
            double oldValue = this.Opacity;
            double difference = opacity - oldValue;

            if (difference == 0)
                return;

            while (this.Opacity != opacity)
            {
                this.Opacity = Math.Round(this.Opacity + Math.Sign(difference) * delta, 2);
                Application.DoEvents();
                Thread.Sleep(33);
            }

            if (opacity == 1)
                this.Opacity = opacity;
        }

        private string ByteToHex(Color color)
        {
            return string.Format("{0}{1}{2}", get(color.R.ToString("X")), get(color.G.ToString("X")), get(color.B.ToString("X"))).ToLower();

            string get(string value)
            {
                if (value == "0")
                    value += "0";
                
                return value;
            }
        }

        private void b_Clear1HEX_Click(object sender, EventArgs e)
        {
            tb_Color1HEX.Text = "";
            tb_Color1HEX.Focus();
        }

        private void tb_Color1HEX_TextChanged(object sender, EventArgs e)
        {
            if (initialize)
                return;

            initialize = true;

            DrawColor(pb_Color1, GetBrushFromHext(tb_Color1HEX.Text, true));
            tb_Color1RGB.Text = lastColor.GetText();

            initialize = false;
        }

        private void b_Copy1RGB_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tb_Color1RGB.Text);
        }

        private void b_Copy1HEX_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tb_Color1HEX.Text);
        }

        private void b_Copy2RGB_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tb_Color2RGB.Text);
        }

        private void b_Copy2HEX_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tb_Color2HEX.Text);
        }

        private void tb_Color2RGB_TextChanged(object sender, EventArgs e)
        {
            DrawColor(pb_Color2, GetBrushFromText(tb_Color2RGB.Text));
            tb_Color2HEX.Text = RGBToHEX(tb_Color2RGB.Text);
        }

        private string RGBToHEX(string text)
        {
            string[] parts = text.Replace(" ", "").Split(',');
            int[] rgb = new int[3];

            for (int i = 0; i < rgb.Length; i++)
                rgb[i] = Convert.ToByte(parts[i], 10);

            return string.Format("{0}{1}{2}", get(rgb[0].ToString("X")), get(rgb[1].ToString("X")), get(rgb[2].ToString("X"))).ToLower();

            string get(string value)
            {
                if (value == "0")
                    value += "0";

                return value;
            }
        }

        void GetText()
        {
            if (ActiveForm == this)
                return;

            Clipboard.Clear();
            InputSimulator ff = new InputSimulator();
            
            bool OldControl = ff.InputDeviceState.IsKeyDown(VirtualKeyCode.CONTROL);
            if (!OldControl)
                ff.Keyboard.KeyDown(VirtualKeyCode.CONTROL);

            ff.Keyboard.KeyDown(VirtualKeyCode.VK_C);
            ff.Keyboard.KeyUp(VirtualKeyCode.VK_C);
            if (!OldControl)
                ff.Keyboard.KeyUp(VirtualKeyCode.CONTROL);

            int tick = Environment.TickCount;
            bool TextContains = false;
            while (Environment.TickCount - tick < 2500)
            {
                try
                {
                    TextContains = Clipboard.ContainsText();
                    if (TextContains)
                        break;

                    Application.DoEvents();
                    Thread.Sleep(1);
                }
                catch { }
            }
            if (TextContains)
            {
                if (this.WindowState == FormWindowState.Minimized)
                    this.WindowState = FormWindowState.Normal;

                this.Activate();
                this.Focus();

                string text = Clipboard.GetText();

                if (text.Contains(","))
                    SetNewColor(text);
                else
                    SetNewColor1(text);
            }
        }

        private void b_ColorTable_Click(object sender, EventArgs e)
        {
            initialize = true;

            Cursor.Current = Cursors.WaitCursor;

            using (FColorTable form = new FColorTable())
            {
                form.ShowDialog();
                if (form.Tag != null)
                {
                    initialize = false;

                    SetNewColor(((Color)form.Tag).GetText());

                    initialize = true;
                }
            }

            initialize = false;
        }
    }
}
