﻿using System;
using System.Collections.Generic;
using System.Text;
using Demo.Utility;

namespace Demo.Presenation
{
    //Trình bày dữ liệu cho đẹp
    public class MenuDemo : Menu
    {
        public MenuDemo(string[] mn) : base(mn) { }
        public override void ThucHien(int vitri)
        {
            FormHocSinh hocsinh = new FormHocSinh();
            switch (vitri)
            {
                case 0:
                    hocsinh.NhapHS();
                    break;
                case 1:
                    hocsinh.TimHS();
                    break;
                case 2:
                    hocsinh.XoaHS();
                    break;
                case 3:
                    hocsinh.HienHS20();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
