﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKy_Winform
{
    public partial class E_Coupe_Class : Form
    {
        string pathE300_Coupe = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\E300 Coupe.jpg";
        string pathE400_Coupe = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\E400 Coupe.jpg";


        string pathE300_Coupe_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\E300 Coupe.jpg";
        string pathE400_Coupe_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\E400 Coupe.jpg";
        public E_Coupe_Class()
        {
            InitializeComponent();
            E300_Coupe.Image = Image.FromFile(pathE300_Coupe);
            E400_Coupe.Image = Image.FromFile(pathE400_Coupe);


            //E300_Coupe.Image = Image.FromFile(pathE300_Coupe_hau);
            //E400_Coupe.Image = Image.FromFile(pathE400_Coupe_hau);
        }
    }
}