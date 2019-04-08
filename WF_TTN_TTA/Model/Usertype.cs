using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_TTN_TTA.Model
{
    class Usertype
    {
        public Usertype()
        {

        }

        private String m_MaLoai;
        public String MaLoai
        {
            get { return m_MaLoai; }
            set { m_MaLoai = value; }
        }

        private String m_TenLoaiND;
        public String TenLoaiND
        {
            get { return m_TenLoaiND; }
            set { m_TenLoaiND = value; }
        }
    }
}
