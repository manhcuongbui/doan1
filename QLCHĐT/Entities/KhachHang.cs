﻿using System;
using System.Collections.Generic;
using System.Text;

namespace đồ_án_1.Entities
{
    public class KhachHang
    {
        #region Các thành phần dữ liệu
        private string makhachhang;
        private string hoten;
        private string quequan;
        private string diachi;
        private string sodienthoai;
        #endregion

        #region Các thuộc tính
        public string MaKhach
        {
            get { return makhachhang; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    makhachhang = value;
            }
        }
        public string Hoten
        {
            get { return hoten; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    hoten = value;
            }
        }
        public string QueQuan
        {
            get { return quequan; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    quequan = value;
            }
        }
        public string DiaChi
        {
            get { return diachi; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    diachi = value;
            }
        }
        public string SodienThoai
        {
            get { return sodienthoai; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 10)
                    sodienthoai = value;
            }
        }
        #endregion

        #region Các thương thức             
        public KhachHang() { }
        //Phương thức thiết lập sao chép
        public KhachHang(KhachHang kh)
        {
            this.makhachhang = kh.makhachhang;
            this.hoten = kh.hoten;
            this.quequan = kh.quequan;
            this.diachi = kh.diachi;
            this.sodienthoai = kh.sodienthoai;
        }
        public KhachHang(string makhach, string hoten, string quequan, string diachi, string sodienthoai)
        {
            this.makhachhang = makhach;
            this.hoten = hoten;
            this.quequan = quequan;
            this.diachi = diachi;
            this.sodienthoai = sodienthoai;
        }
        #endregion
    }
}
