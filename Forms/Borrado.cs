﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo_en_uno.Forms
{
    public partial class Borrado : Form
    {
        public Borrado()
        {
            InitializeComponent();
        }

        public Borrado(string mensaje)
        {
            InitializeComponent();
            label1.Text = mensaje;
        }
    }
}
