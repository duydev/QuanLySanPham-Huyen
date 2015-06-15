using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using QLSP.DAO;
using QLSP.BUS;
using QLSP.VO;
using System.Data;

namespace QLSP
{
    class NhapXuat
    {
        SanPhamDAO sanphamDAO;
        public NhapXuat()
        {
            sanphamDAO = new SanPhamDAO();
        }

        public void SaoLuu(string filename)
        {
            DataTable dt = sanphamDAO.laySanPham();

            Encoding utf8noBOM = new UTF8Encoding(false);  
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.Encoding = utf8noBOM;

            XmlWriter writer = XmlWriter.Create(filename, settings);
            writer.WriteStartDocument();
            writer.WriteComment("Copyright 2015 - Tran Nhat Duy");
            writer.WriteStartElement("DanhSachSanPham");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                writer.WriteStartElement("SanPham");
                    writer.WriteElementString("TenSanPham", dt.Rows[i]["TenSanPham"].ToString());
                    writer.WriteElementString("DanhMuc", dt.Rows[i]["TenDanhMuc"].ToString());
                    writer.WriteElementString("ThuongHieu", dt.Rows[i]["TenThuongHieu"].ToString());
                    writer.WriteElementString("Si10", dt.Rows[i]["Si10"].ToString());
                    writer.WriteElementString("Si20", dt.Rows[i]["Si20"].ToString());
                    writer.WriteElementString("Le", dt.Rows[i]["Le"].ToString());                               
                writer.WriteEndElement();
                
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
        }

        public void PhucHoi(string filename)
        {
            sanphamDAO.xoaSanPham();
            SanPhamVO sp = new SanPhamVO(); 

            XmlReaderSettings settings = new XmlReaderSettings();
            using (XmlReader reader = XmlReader.Create(filename,settings))
            {
                while (reader.Read())
                {                 
                    if (reader.IsStartElement())
                    {                        
                        switch (reader.Name)
                        {
                            case "DanhSachSanPham":                               
                                Console.WriteLine("Bat Dau <DanhSachSanPham>.");
                                break;
                            case "SanPham":                                                            
                                Console.WriteLine("Bat dau <SanPham>.");                               
                                break;
                            case "TenSanPham":                               
                                Console.WriteLine("Bat dau <TenSanPham>."); 
                                if (reader.Read())
                                {
                                    sp.Tensanpham = reader.Value.Trim();
                                    Console.WriteLine("  Text node: " + reader.Value.Trim());
                                }
                                break;
                            case "DanhMuc":
                                Console.WriteLine("Bat dau <DanhMuc>.");
                                if (reader.Read())
                                {
                                    sp.Tendanhmuc = reader.Value.Trim();
                                    Console.WriteLine("  Text node: " + reader.Value.Trim());
                                }
                                break;
                            case "ThuongHieu":
                                Console.WriteLine("Bat dau <ThuongHieu>.");
                                if (reader.Read())
                                {
                                    sp.Tenthuonghieu = reader.Value.Trim();
                                    Console.WriteLine("  Text node: " + reader.Value.Trim());
                                }
                                break;
                            case "Si10":
                                Console.WriteLine("Bat dau <Si10>.");
                                if (reader.Read())
                                {
                                    sp.Si10 = int.Parse(reader.Value.Trim());
                                    Console.WriteLine("  Text node: " + reader.Value.Trim());
                                }
                                break;
                            case "Si20":
                                Console.WriteLine("Bat dau <Si20>.");
                                if (reader.Read())
                                {
                                    sp.Si20 = int.Parse(reader.Value.Trim());
                                    Console.WriteLine("  Text node: " + reader.Value.Trim());
                                }
                                break;
                            case "Le":
                                Console.WriteLine("Bat dau <Le>.");
                                if (reader.Read())
                                {
                                    sp.Le = int.Parse(reader.Value.Trim());
                                    Console.WriteLine("  Text node: " + reader.Value.Trim());
                                }
                                SanPhamBUS sanphamBUS = new SanPhamBUS();
                                sanphamBUS.themSanPham(sp);
                                break;
                        }
                    }
                }
            }
        }

    }
}
