﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24hr_Game_Challenge
{
    public partial class Map : Form
    {

       bool right, left;
       
        //bool jump;

        public Map()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (right == true) {player.Left += 5; }
            if (left == true) { player.Left -= 5; }
        }

      

        private void Map_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right) { right = true; }
            if(e.KeyCode == Keys.Left) { left = true; }
        }

        private void Map_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }



    }
}
