﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackMates
{
    class MainForm : Form
    {
        LoginForm Login = new LoginForm();
       

       public MainForm()
        {
            this.Controls.Add(Login.RootPanel);
            this.Size = new System.Drawing.Size(500, 500);
            
        }
    }
}
