using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WF_TTN_TTA.Model;

namespace WF_TTN_TTA.component
{
    #region Utilities
    public static class Utilities
    {
         static NguoiDungInfo nguoiDung;
        public static String DatabaseName;
    }
    #endregion

    public class QuyDinh
    {
         static QuyDinhInfo LayThongTinTruong()
        {
            QuyDinhInfo m_Truong = new QuyDinhInfo();
            DataService dS = new DataService();

            dS.Load(new SqlCommand("SELECT TenTruong, DiaChiTruong FROM QUYDINH"));

            if (dS.Rows.Count > 0)
            {
                m_Truong.TenTruong = dS.Rows[0]["TenTruong"].ToString();
                m_Truong.DiaChiTruong = dS.Rows[0]["DiaChiTruong"].ToString();
            }

            return m_Truong;
        }

        public String ArrayToString(String[] array, int n)
        {
            String str = "";
            for (int i = 0; i < n; i++)
            {
                if (i != n - 1)
                    str += array[i] + ";";
                else
                    str += array[i];
            }
            return str;
        }

        public Boolean KiemTraDiem(String diemSo)
        {
            IList<String> gioiHanDiem = new List<String>();

            DataService dS = new DataService();
            dS.Load(new SqlCommand("SELECT ThangDiem FROM QUYDINH"));

            int thangDiem = Convert.ToInt32(dS.Rows[0]["ThangDiem"]);
            float nacDiemTrongGioiHan = 0;

            if (thangDiem == 10)
            {
                for (int i = 0; i <= 1010; i++)
                {
                    gioiHanDiem.Add(nacDiemTrongGioiHan.ToString());
                    nacDiemTrongGioiHan += 0.01F;
                    nacDiemTrongGioiHan = (float)Math.Round(nacDiemTrongGioiHan, 2);
                }

                if (gioiHanDiem.Contains(diemSo) == true)
                    return true;
                else
                    return false;
            }
            else
            {
                for (int i = 0; i <= 100; i++)
                {
                    gioiHanDiem.Add(nacDiemTrongGioiHan.ToString());
                    nacDiemTrongGioiHan += 1;
                }

                if (gioiHanDiem.Contains(diemSo) == true)
                    return true;
                else
                    return false;
            }
        }

        public Boolean KiemTraSiSo(int siSo)
        {
            DataService dS = new DataService();
            dS.Load(new SqlCommand("SELECT SiSoCanDuoi, SiSoCanTren FROM QUYDINH"));

            int siSoMin = Convert.ToInt32(dS.Rows[0]["SiSoCanDuoi"]);
            int siSoMax = Convert.ToInt32(dS.Rows[0]["SiSoCanTren"]);

            if (siSo >= siSoMin && siSo <= siSoMax)
                return true;
            else
                return false;
        }

        public Boolean KiemTraDoTuoi(DateTime ngaySinh)
        {
            DataService dS = new DataService();
            dS.Load(new SqlCommand("SELECT TuoiCanDuoi, TuoiCanTren FROM QUYDINH"));

            int doTuoiMin = Convert.ToInt32(dS.Rows[0]["TuoiCanDuoi"]);
            int doTuoiMax = Convert.ToInt32(dS.Rows[0]["TuoiCanTren"]);

            int doTuoi = DateTime.Today.Year - ngaySinh.Year;

            if (doTuoi >= doTuoiMin && doTuoi <= doTuoiMax)
                return true;
            else
                return false;
        }

        public String LaySTT(int autoNum)
        {
            if (autoNum < 10)
                return "000" + autoNum;

            else if (autoNum >= 10 && autoNum < 100)
                return "00" + autoNum;

            else if (autoNum >= 100 && autoNum < 1000)
                return "0" + autoNum;

            else if (autoNum >= 1000 && autoNum < 10000)
                return "" + autoNum;

            else
                return "";
        }
    }
   
    public static class ThamSo
    {
       
        public class XML
        {
            public static XmlDocument XMLReader(String filename)
            {
                XmlDocument xmlR = new XmlDocument();
                try
                {
                    xmlR.Load(filename);
                }
                catch
                {
                    MessageBox.Show("Không đọc được hoặc không tồn tại tập tin cấu hình " + filename, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return xmlR;
            }

            public static void XMLWriter(String filename, String servname, String database, String costatus)
            {
                XmlTextWriter xmlW = new XmlTextWriter(filename, null);
                xmlW.Formatting = Formatting.Indented;

                xmlW.WriteStartDocument();
                xmlW.WriteComment("\nKhong duoc thay doi noi dung file nay!\n" +
                                    "Thong so co ban:\n\t" +
                                    "costatus = true : quyen Windows\n\t" +
                                    "costatus = false: quyen SQL Server\n\t" +
                                    "servname: ten server\n\t" +
                                    "username: ten dang nhap he thong\n\t" +
                                    "password: mat khau dang nhap he thong\n\t" +
                                    "database: ten co so du lieu\n");
                xmlW.WriteStartElement("config");

                xmlW.WriteStartElement("costatus");
                xmlW.WriteString(costatus);
                xmlW.WriteEndElement();

                xmlW.WriteStartElement("servname");
                xmlW.WriteString(servname);
                xmlW.WriteEndElement();

                xmlW.WriteStartElement("username");
                xmlW.WriteString("");
                xmlW.WriteEndElement();

                xmlW.WriteStartElement("password");
                xmlW.WriteString("");
                xmlW.WriteEndElement();

                xmlW.WriteStartElement("database");
                xmlW.WriteString(database);
                xmlW.WriteEndElement();

                xmlW.WriteEndElement();
                xmlW.WriteEndDocument();

                xmlW.Close();
            }

            public static void XMLWriter(String filename, String servname, String username, String password, String database, String costatus)
            {
                XmlTextWriter xmlW = new XmlTextWriter(filename, null);
                xmlW.Formatting = Formatting.Indented;

                xmlW.WriteStartDocument();
                xmlW.WriteComment("\nKhong duoc thay doi noi dung file nay!\n" +
                                    "Thong so co ban:\n\t" +
                                    "costatus = true : quyen Windows\n\t" +
                                    "costatus = false: quyen SQL Server\n\t" +
                                    "servname: ten server\n\t" +
                                    "username: ten dang nhap he thong\n\t" +
                                    "password: mat khau dang nhap he thong\n\t" +
                                    "database: ten co so du lieu\n");
                xmlW.WriteStartElement("config");

                xmlW.WriteStartElement("costatus");
                xmlW.WriteString(costatus);
                xmlW.WriteEndElement();

                xmlW.WriteStartElement("servname");
                xmlW.WriteString(servname);
                xmlW.WriteEndElement();

                xmlW.WriteStartElement("username");
                xmlW.WriteString(username);
                xmlW.WriteEndElement();

                xmlW.WriteStartElement("password");
                xmlW.WriteString(password);
                xmlW.WriteEndElement();

                xmlW.WriteStartElement("database");
                xmlW.WriteString(database);
                xmlW.WriteEndElement();

                xmlW.WriteEndElement();
                xmlW.WriteEndDocument();

                xmlW.Close();
            }
        }
    }
}
