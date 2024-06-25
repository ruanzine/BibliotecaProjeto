using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO.controls
{
    [DefaultEvent("OnSelectedIndexChanged")]
    public class UC_ComboBox : UserControl
    {
        // Fields
        private Color backColor = Color.WhiteSmoke;
        private Color iconColor = Color.MediumSlateBlue;
        private Color listBackColor = Color.FromArgb(230, 228, 245);
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.MediumSlateBlue;
        private Color hoverColor = Color.MediumPurple;
        private int borderSize = 1;
        private float listFontSize = 10F;

        // Items
        private ComboBox cmbList;
        private Label lblText;
        private Button btnIcon;

        // Events
        public event EventHandler OnSelectedIndexChanged; // Default event

        // Properties
        public new Color BackColor
        {
            get { return backColor; }
            set
            {
                backColor = value;
                lblText.BackColor = backColor;
                btnIcon.BackColor = backColor;
            }
        }

        public Color IconColor
        {
            get { return iconColor; }
            set
            {
                iconColor = value;
                btnIcon.Invalidate();
            }
        }

        public Color ListBackColor
        {
            get { return listBackColor; }
            set
            {
                listBackColor = value;
                cmbList.BackColor = listBackColor;
            }
        }

        public Color ListTextColor
        {
            get { return listTextColor; }
            set
            {
                listTextColor = value;
                cmbList.ForeColor = listTextColor;
            }
        }

        public Color HoverColor
        {
            get { return hoverColor; }
            set
            {
                hoverColor = value;
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                base.BackColor = borderColor;
            }
        }

        public string Texts
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize);
                AdjustComboBoxDimensions();
            }
        }

        public float ListFontSize
        {
            get { return listFontSize; }
            set
            {
                listFontSize = value;
                cmbList.Font = new Font(cmbList.Font.Name, listFontSize);
            }
        }

        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                lblText.Font = value;
                cmbList.Font = new Font(value.FontFamily, listFontSize); // Optional
            }
        }

        public ComboBoxStyle DropDownStyle
        {
            get { return cmbList.DropDownStyle; }
            set
            {
                if (cmbList.DropDownStyle != ComboBoxStyle.Simple)
                    cmbList.DropDownStyle = value;
            }
        }

        public object DataSource
        {
            get { return cmbList.DataSource; }
            set { cmbList.DataSource = value; }
        }

        public string DisplayMember
        {
            get { return cmbList.DisplayMember; }
            set { cmbList.DisplayMember = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get { return cmbList.Items; }
        }

        // Constructor
        public UC_ComboBox()
        {
            cmbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            // ComboBox: Dropdown list
            cmbList.BackColor = listBackColor;
            cmbList.Font = new Font(this.Font.Name, listFontSize);
            cmbList.ForeColor = listTextColor;
            cmbList.DrawMode = DrawMode.OwnerDrawFixed; // Add this line
            cmbList.DrawItem += new DrawItemEventHandler(ComboBox_DrawItem); // Add this line
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            cmbList.TextChanged += new EventHandler(ComboBox_TextChanged);
            cmbList.DropDown += new EventHandler(ComboBox_DropDown); // Add this line

            // Button: Icon
            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Click); // Open dropdown list
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);

            // Label: Text
            lblText.Dock = DockStyle.Fill;
            lblText.AutoSize = false;
            lblText.BackColor = backColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(8, 0, 0, 0);
            lblText.Font = new Font(this.Font.Name, 10F);
            lblText.Click += new EventHandler(Surface_Click);

            // User Control
            this.Controls.Add(lblText);
            this.Controls.Add(btnIcon);
            this.Controls.Add(cmbList);
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize);
            base.BackColor = borderColor;
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }

        // Private methods
        private void AdjustComboBoxDimensions()
        {
            cmbList.Width = this.Width - btnIcon.Width - 1; // Ajusta a largura da combo box
            cmbList.Location = new Point(this.Padding.Left, lblText.Bottom - cmbList.Height);

            lblText.Width = this.Width - btnIcon.Width;
            lblText.Height = this.Height;
        }

        // Event methods
        //-> Default event
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);
            // Refresh text
            lblText.Text = cmbList.Text;
        }

        private void Surface_Click(object sender, EventArgs e)
        {
            // Select combo box
            cmbList.Select();
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
                cmbList.DroppedDown = true;
        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            // Fields
            int iconWidth = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidth) / 2,
                (btnIcon.Height - iconHeight) / 2, iconWidth, iconHeight);
            Graphics graph = e.Graphics;

            // Draw arrow down icon
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidth / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        private void Icon_Click(object sender, EventArgs e)
        {
            // Open dropdown list
            cmbList.Select();
            cmbList.DroppedDown = true;
        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            if (cmbList.SelectedItem != null && cmbList.SelectedText != cmbList.Text)
            {
                // Refresh text only when selected item is changed
                lblText.Text = cmbList.Text;
            }
        }

        private void ComboBox_DropDown(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            int width = cmb.DropDownWidth;
            Graphics g = cmb.CreateGraphics();
            Font font = cmb.Font;

            int vertScrollBarWidth = (cmb.Items.Count > cmb.MaxDropDownItems) ? SystemInformation.VerticalScrollBarWidth : 0;

            foreach (var item in cmb.Items)
            {
                int newWidth = (int)g.MeasureString(item.ToString(), font).Width + vertScrollBarWidth;
                if (width < newWidth)
                {
                    width = newWidth;
                }
            }
            cmb.DropDownWidth = width;
        }

        private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            int index = e.Index;
            if (index >= 0 && index < cmbList.Items.Count)
            {
                string text = cmbList.Items[index].ToString();
                Graphics g = e.Graphics;

                // Background color
                SolidBrush backgroundBrush = new SolidBrush(isSelected ? hoverColor : listBackColor);
                g.FillRectangle(backgroundBrush, e.Bounds);

                // Text color
                SolidBrush textBrush = new SolidBrush(isSelected ? Color.White : listTextColor); // Line to set text color to white on hover
                g.DrawString(text, e.Font, textBrush, e.Bounds, StringFormat.GenericDefault);

                backgroundBrush.Dispose();
                textBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        // Adicione este método à classe UC_ComboBox
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // UC_ComboBox
            // 
            this.Name = "UC_ComboBox";
            this.Load += new System.EventHandler(this.UC_ComboBox_Load);
            this.ResumeLayout(false);
        }

        private void UC_ComboBox_Load(object sender, EventArgs e)
        {

        }
    }
}
