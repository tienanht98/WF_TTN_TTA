﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_TTN_TTA.Model
{
    class NguoiDungInfo
    {
        public NguoiDungInfo()
        {

        }

        private String m_MaND;
        public String MaND
        {
            get { return m_MaND; }
            set { m_MaND = value; }
        }

        private Usertype m_LoaiND;
        public Usertype LoaiND
        {
            get { return m_LoaiND; }
            set { m_LoaiND = value; }
        }

        private String m_TenND;
        public String TenND
        {
            get { return m_TenND; }
            set { m_TenND = value; }
        }

        private String m_TenDNhap;
        public String TenDNhap
        {
            get { return m_TenDNhap; }
            set { m_TenDNhap = value; }
        }

        private String m_MatKhau;
        public String MatKhau
        {
            get { return m_MatKhau; }
            set { m_MatKhau = value; }
        }
    }
}

