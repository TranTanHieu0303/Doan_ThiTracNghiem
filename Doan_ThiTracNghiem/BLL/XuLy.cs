using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Doan_ThiTracNghiem.DAL;
using ExcelDataReader;
using Firebase.Auth;
using Firebase.Storage;

namespace Doan_ThiTracNghiem.BLL
{
    public class XuLy
    {
        QLThiDataContext dataContext = new QLThiDataContext();
        public TaiKhoan ktDangNhap(string pUse, string pPass)
        {

            TaiKhoan tk = dataContext.TaiKhoans.FirstOrDefault(u => u.Usename == pUse && u.Pass == pPass);
            return tk;

        }
        public List<TaiKhoan> loadUse()
        {
            return dataContext.TaiKhoans.ToList();
        }
        public List<TaiKhoan> loadTaiKhoanTheoLoai(string pMaLoai)
        {
            return dataContext.TaiKhoans.Where(t => t.LoaiTK == pMaLoai).ToList();
        }
        public string themMaUse()
        {
            TaiKhoan tk;
            int Ma;
            if (dataContext.TaiKhoans.OrderByDescending(t => t.MaUse).ToList().Count != 0)
            {
                tk = dataContext.TaiKhoans.OrderByDescending(t => t.MaUse).ToList()[0];
                Ma = int.Parse(tk.MaUse.Remove(0, 2));
            }
            else
                Ma = 0;
            if (Ma + 1 < 10)
                return "TK00" + (Ma + 1);
            if (Ma + 1 < 100)
                return "TK0" + (Ma + 1);
            return "TK" + (Ma + 1);
        }
        public string themMaCauHoi()
        {
            NganHangCauHoi ch;
            int Ma;
            if (dataContext.NganHangCauHois.OrderByDescending(t => t.MaCH).ToList().Count != 0)
            {
                ch = dataContext.NganHangCauHois.OrderByDescending(t => t.MaCH).ToList()[0];
                Ma = int.Parse(ch.MaCH.Remove(0, 2));
            }
            else
                Ma = 0;
            if (Ma + 1 < 10)
                return "CH00" + (Ma + 1);
            if (Ma + 1 < 100)
                return "CH0" + (Ma + 1);
            return "CH" + (Ma + 1);
        }
        public async void themUseAsync(string pMaUSe, string pTenDN, string pMatKhau, string pHoTen, string pGioiTinh, DateTime pNgaySinh, string pNoiSinh, OpenFileDialog pHinhAnh, string pLoaiTK)
        {
            try
            {
                Stream stream = pHinhAnh.OpenFile();
                TaiKhoan tk = new TaiKhoan();
                var auth = new FirebaseAuthProvider(new Firebase.Auth.FirebaseConfig("AIzaSyAKZ7K7KmoYFxo88dQRkeAHtngm67KD7t0"));
                var a = await auth.SignInWithEmailAndPasswordAsync("trantanhieu1804@gmail.com", "180403");

                // Constructr FirebaseStorage, path to where you want to upload the file and Put it there
                var task = new FirebaseStorage(
                    "appphim-dc807.appspot.com",


                     new FirebaseStorageOptions
                     {
                         AuthTokenAsyncFactory = () => Task.FromResult(a.FirebaseToken),
                         ThrowOnCancel = true,
                     })
                    .Child("Image")
                    .Child(DateTime.Now.Millisecond + Path.GetFileName(pHinhAnh.FileName).Trim())
                    .PutAsync(stream);

                // Track progress of the upload
                task.Progress.ProgressChanged += (s, e) => Console.WriteLine($"Progress: {e.Percentage} %");

                // await the task to wait until upload completes and get the download url
                var downloadUrl = await task;
                tk.MaUse = pMaUSe;
                tk.Usename = pTenDN;
                tk.Pass = pMatKhau;
                tk.HoTen = pHoTen;
                tk.GioiTinh = pGioiTinh;
                tk.NgaySinh = pNgaySinh;
                tk.NoiSinh = pNoiSinh;
                tk.HinhAnh = downloadUrl;
                tk.LoaiTK = pLoaiTK;
                dataContext.TaiKhoans.InsertOnSubmit(tk);
                dataContext.SubmitChanges();
                MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : \n" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        public async void suaUseAsync(string pMaUSe, string pTenDN, string pMatKhau, string pHoTen, string pGioiTinh, DateTime pNgaySinh, string pNoiSinh, OpenFileDialog pHinhAnh, string pLoaiTK)
        {
            try
            {
                TaiKhoan tk = dataContext.TaiKhoans.FirstOrDefault(t => t.MaUse == pMaUSe);
                if (pHinhAnh != null)
                {
                    Stream stream = pHinhAnh.OpenFile();

                    var auth = new FirebaseAuthProvider(new Firebase.Auth.FirebaseConfig("AIzaSyAKZ7K7KmoYFxo88dQRkeAHtngm67KD7t0"));
                    var a = await auth.SignInWithEmailAndPasswordAsync("trantanhieu1804@gmail.com", "180403");

                    // Constructr FirebaseStorage, path to where you want to upload the file and Put it there
                    var task = new FirebaseStorage(
                        "appphim-dc807.appspot.com",


                         new FirebaseStorageOptions
                         {
                             AuthTokenAsyncFactory = () => Task.FromResult(a.FirebaseToken),
                             ThrowOnCancel = true,
                         })
                        .Child("Image")
                        .Child(DateTime.Now.Millisecond + Path.GetFileName(pHinhAnh.FileName).Trim())
                        .PutAsync(stream);

                    // Track progress of the upload
                    task.Progress.ProgressChanged += (s, e) => Console.WriteLine($"Progress: {e.Percentage} %");

                    // await the task to wait until upload completes and get the download url
                    var downloadUrl = await task;
                    tk.HinhAnh = downloadUrl;
                }
                tk.Usename = pTenDN;
                tk.Pass = pMatKhau;
                tk.HoTen = pHoTen;
                tk.GioiTinh = pGioiTinh;
                tk.NgaySinh = pNgaySinh;
                tk.NoiSinh = pNoiSinh;
                tk.LoaiTK = pLoaiTK;
                dataContext.SubmitChanges();
                MessageBox.Show("Cập Nhật Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : \n" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        public List<ChucNangTaiKhoan> loadQuyen(string pMaUse)
        {
            return dataContext.ChucNangTaiKhoans.Where(cn => cn.MaTK == pMaUse).ToList();
        }
        public DataSet loadExcel(OpenFileDialog ofd)
        {
            DataSet ds = new DataSet();

            using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
            {
                IExcelDataReader reader;
                if (ofd.FilterIndex == 2)
                {
                    reader = ExcelReaderFactory.CreateBinaryReader(stream);
                }
                else
                {
                    reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                }

                ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                    {
                        UseHeaderRow = true
                    }
                });

            }

            return ds;
        }
        public List<MonThi> loadMon()
        {
            return dataContext.MonThis.ToList();
        }
        //Them cau hoi vào ngan hang de
        public bool Them_CauHoi(string pMaMon, string pMaCau, string pNoiDung, string A, string B, string C, string D, char pDapAn)
        {
            try
            {
                NganHangCauHoi cau = new NganHangCauHoi();
                cau.MaMon = pMaMon;
                cau.MaCH = pMaCau;
                cau.NoiDung = pNoiDung;
                cau.A = A;
                cau.B = B;
                cau.C = C;
                cau.D = D;
                cau.DapAn = pDapAn;
                dataContext.NganHangCauHois.InsertOnSubmit(cau);
                dataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<NganHangCauHoi> loadNganHangCauHoi(string pMaMon)
        {
            return dataContext.NganHangCauHois.Where(ch => ch.MaMon == pMaMon).ToList();
        }
        public List<NganHangCauHoi> taoDeNgauNhieu(string pMaMon, int pSocau)
        {
            return dataContext.NganHangCauHois.OrderBy(t => Guid.NewGuid()).ToList();
        }
        public string themMaDe()
        {
            DeThi dt;
            int Ma;
            if (dataContext.DeThis.OrderByDescending(t => t.MaDe).ToList().Count != 0)
            {
                dt = dataContext.DeThis.OrderByDescending(t => t.MaDe).ToList()[0];
                Ma = int.Parse(dt.MaDe.Remove(0, 2));
            }
            else
                Ma = 0;
            if (Ma + 1 < 10)
                return "DT00" + (Ma + 1);
            if (Ma + 1 < 100)
                return "DT0" + (Ma + 1);
            return "DT" + (Ma + 1);
        }
        public bool themDe(string pMaDe, string pTenDe, string pMaMon, int pThoiGian)
        {
            try
            {
                DeThi dt = new DeThi();
                dt.MaDe = pMaDe;
                dt.MaMon = pMaMon;
                dt.TenDe = pTenDe;
                dt.ThoiGian = pThoiGian;
                dataContext.DeThis.InsertOnSubmit(dt);
                dataContext.SubmitChanges();
                return true;
            }
            catch
            { return false; }
        }
        public bool themNoidungDe(string pMaDe, string pMaCH)
        {
            try
            {
                NoiDungDe nd = new NoiDungDe();
                nd.MaDe = pMaDe;
                nd.MaCH = pMaCH;
                dataContext.NoiDungDes.InsertOnSubmit(nd);
                dataContext.SubmitChanges();
                return true;
            }catch { return false; }
        }
        public string themMaLichThi()
        {
            LichThi lichThi;
            int Ma;
            if (dataContext.LichThis.OrderByDescending(t => t.MaLT).ToList().Count != 0)
            {
                lichThi = dataContext.LichThis.OrderByDescending(t => t.MaLT).ToList()[0];
                Ma = int.Parse(lichThi.MaLT.Remove(0, 2));
            }
            else
                Ma = 0;
            if (Ma + 1 < 10)
                return "LT00" + (Ma + 1);
            if (Ma + 1 < 100)
                return "LT0" + (Ma + 1);
            return "LT" + (Ma + 1);
        }
        public bool themLichThi(string pMaLT, string pMaGV, string pMaDe, DateTime pNgayThi)
        {
            try
            {
                LichThi lt = new LichThi();
                lt.MaLT = pMaLT;
                lt.MaDe = pMaDe;
                lt.MaGV = pMaGV;
                lt.NgayThi = pNgayThi;
                dataContext.LichThis.InsertOnSubmit(lt);
                dataContext.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false; 
            }
        }

    }
}
