﻿using P1004.todo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1004
{
    public partial class ControlForm : Form
    {
        private Label[] labels;
        public TextBox[] Texts { get; private set; }
        private Button add;
        private Button cancel;

        public ControlForm()
        {
            InitializeComponent();

            this.labels = new Label[MainForm.Columns.Length];
            this.Texts = new TextBox[MainForm.Columns.Length];

            for (int i = 0; i < MainForm.Columns.Length; i++)
            {
                this.labels[i] = new Label()
                {
                    Parent = this,
                    Text = MainForm.Columns[i],
                    Location = new Point(0, i * this.ClientSize.Height / 6),
                    Size = new Size(this.ClientSize.Width / 2, this.ClientSize.Height / 6),
                };
                this.Texts[i] = new TextBox()
                {
                    Parent = this,
                    Location = new Point(this.ClientSize.Width / 2, i * this.ClientSize.Height / 6),
                    Size = new Size(this.ClientSize.Width / 2, this.ClientSize.Height / 6),
                };
            }

            this.add = new Button()
            {
                Parent = this,
                Location = new Point(0, this.ClientSize.Height * 5 / 6),
                Size = new Size(this.ClientSize.Width / 2, this.ClientSize.Height / 6),
                Text = "ADD",
            };
            this.cancel = new Button()
            {
                Parent = this,
                Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height * 5 / 6),
                Size = new Size(this.ClientSize.Width / 2, this.ClientSize.Height / 6),
                Text = "CANCEL",
            };

            this.add.Click += AddClick;
            this.cancel.Click += CancelClick;
        }

        private void CancelClick(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void AddClick(object? sender, EventArgs e)
        {
            this.ToDo.Name = this.Texts[0].Text;
            this.ToDo.Description = this.Texts[1].Text;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        public Todo ToDo { get; private set; } = new Todo();
    }
}
