﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO
{
    public partial class UC_textbox : UserControl
    {
        public UC_textbox()
        {
            InitializeComponent();
        }

        //[DefaultEvent ("_TextChanged")]
        //Fields 
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;

        //Constructor 
        [Category("TextBox Coding")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("TextBox Coding")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("TextBox Coding")]
        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("TextBox Coding")]
        public string Texts
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }


        [Category("TextBox Coding")]
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }

        }

        [Category("TextBox Coding")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        [Category("TextBox Coding")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category("TextBox Coding")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode) UpdateControlHeight();
            }

        }



        //Overriden methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //Draw border
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (underlinedStyle)
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);

            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode) UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        //Events
        //public event EventHandler _TextChanged; 
        //Private Methods 
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) => this.OnKeyPress(e);

    }
}
