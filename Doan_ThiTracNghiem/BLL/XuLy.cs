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
using Accord.MachineLearning;

namespace Doan_ThiTracNghiem.BLL
{
    public class XuLy
    {
        QLThiTracNghiemDataContext dataContext = new QLThiTracNghiemDataContext();
        QL_ThiTracNghiemDataSet dataSet = new QL_ThiTracNghiemDataSet();
       //Kiểm tra đăng nhập
        public TaiKhoan ktDangNhap(string pUse, string pPass)
        {
            
            TaiKhoan tk = dataContext.TaiKhoans.FirstOrDefault(u => u.Usename == pUse && u.Pass == pPass);
            return tk;

        }
       //Load tất cả tài khoản
        public List<TaiKhoan> loadUse()
        {
            return dataContext.TaiKhoans.ToList();
        }
        //loai danh sách tài khoản theo mã loại nhập vạo
        public List<TaiKhoan> loadTaiKhoanTheoLoai(string pMaLoai)
        {
            return dataContext.TaiKhoans.Where(t => t.LoaiTK == pMaLoai).ToList();
        }
       //tạo mới chó một tài khoản.
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
        //tạo mã mới cho một câu hỏi
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
        // thêm mới mội tài khoản và lưu vào database.
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
        // Chỉnh sửa thông tin của một tài khoản
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
        //Lấy danh sách các chức năng của tài khoản nhập vào
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
        // lấy dach sách môn thi
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
        // lấy danh sách câu hỏi theo môn nhập vào
        public List<NganHangCauHoi> loadNganHangCauHoi(string pMaMon)
        {
            return dataContext.NganHangCauHois.Where(ch => ch.MaMon == pMaMon).ToList();
        }
        // tạo đè với môn và số câu nhập vào
        public List<NganHangCauHoi> taoDeNgauNhieu(string pMaMon, int pSocau)
        {
            List<NganHangCauHoi> lst = dataContext.NganHangCauHois.Where(t=>t.MaMon==pMaMon).ToList();
            return lst.OrderBy(emp => Guid.NewGuid()).Take(pSocau).ToList();
        }
        // tạo mã đề mới.
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
        // thêm dề vào database.
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
        //câu các câu hỏi vào đề với mã đề và mã câu hỏi nhập vào.
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
            }
            catch { return false; }
        }
        // tạo mã lịch thi
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
        // thêm lịch thi mới
        public bool themLichThi(string pMaLT, string pMaGV, string pMaDe, DateTime pNgayThi,string pTenKythi)
        {
            try
            {
                LichThi lt = new LichThi();
                lt.MaLT = pMaLT;
                lt.MaDe = pMaDe;
                lt.MaGV = pMaGV;
                lt.NgayThi = pNgayThi;
                lt.TenKyThi = pTenKythi;
                dataContext.LichThis.InsertOnSubmit(lt);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }
        //Thêm ngời tham gia thi vào lịch thi
        public bool themNguoiThamGiaThi(string pMaLT, string pMaTK)
        {
            try
            {
                ThamGiaThi thamGiaThi = new ThamGiaThi();
                thamGiaThi.MaLT = pMaLT;
                thamGiaThi.MaTK = pMaTK;
                dataContext.ThamGiaThis.InsertOnSubmit(thamGiaThi);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:\n" + ex.Message);
                return false;
            }

        }
        //xóa bớt người tham gia vào kì thi
        public bool xoaNguoiThamGiaThi(string pMaTK)
        {
            try
            {
                ThamGiaThi thamGiaThi = dataContext.ThamGiaThis.FirstOrDefault(t => t.MaTK == pMaTK);
                dataContext.ThamGiaThis.DeleteOnSubmit(thamGiaThi);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:\n" + ex.Message);
                return false;
            }

        }

        public List<TaiKhoan> loadTkThamGiaThi()
        {
            List<TaiKhoan> data = new List<TaiKhoan>();
            List<ThamGiaThi> matk = dataContext.ThamGiaThis.ToList();
            foreach(ThamGiaThi item in matk)
            {
                data.Add(dataContext.TaiKhoans.FirstOrDefault(t => t.MaUse == item.MaTK));
            }
            return data;
        }
        // lấy danh môn mà tài khoản được thi trog ngày cần tìm.
        public List<LichThi> loadMonThi(string pMaUse,DateTime pNgayCanTim)
        {
            List<LichThi> lst = new List<LichThi>();
            List<ThamGiaThi> lstThamGia = dataContext.ThamGiaThis.Where(t => t.MaTK == pMaUse).ToList();
            foreach(ThamGiaThi item in lstThamGia)
            {
                LichThi lich = dataContext.LichThis.FirstOrDefault(lt => lt.MaLT == item.MaLT);
                DeThi de = dataContext.DeThis.FirstOrDefault(d => d.MaDe == lich.MaDe);
                double phut = (double)de.ThoiGian;
                if (lich.NgayThi.Value.AddMinutes(phut) > pNgayCanTim)
                    lst.Add(lich);
            }    
            return lst;

        }
        // lấy môn thi tải khoản được phép thi trong ngày hiện tại
        public List<LichThi> loadMonThi(string pMaUse)
        {
            List<LichThi> lst = new List<LichThi>();
            List<ThamGiaThi> lstThamGia = dataContext.ThamGiaThis.Where(t => t.MaTK == pMaUse).ToList();
            foreach (ThamGiaThi item in lstThamGia)
            {
                LichThi lich = dataContext.LichThis.FirstOrDefault(lt => lt.MaLT == item.MaLT && lt.NgayThi.Value.Day == DateTime.Now.Day);
                if (lich != null)
                    lst.Add(lich);
            }
            return lst;

        }
        // trộn đề thi
        public List<Sapxepde> tronDe(string pMaDe)
        {
            List<NoiDungDe> nd = dataContext.NoiDungDes.Where(t => t.MaDe == pMaDe).ToList();
            List<NoiDungDe> lst = nd.OrderBy(n => Guid.NewGuid()).ToList();
            List<Sapxepde> lsttron = new List<Sapxepde>();
            int i = 1;
            foreach(NoiDungDe item in lst)
            {
                Sapxepde sp = new Sapxepde();
                NganHangCauHoi ch = dataContext.NganHangCauHois.FirstOrDefault(c => c.MaCH == item.MaCH);
                sp.STT = i;
                sp.MaCH = item.MaCH;
                sp.NoiDung = ch.NoiDung;
                sp.A = ch.A;
                sp.B = ch.B;
                sp.C = ch.C;
                sp.D = ch.D;
                sp.DapAn = ch.DapAn;
                lsttron.Add(sp);
                i++;

            }
            return lsttron;


        }
        // tính điểm bài làm
        public float tinhDiem(List<Sapxepde> sapxepde)
        {
            int tongCau = sapxepde.Count;
            float diem = (float)10 / tongCau;
            int cauDung = 0;
            foreach(Sapxepde item in sapxepde)
            {
                if (item.DapAn == item.dapanchon.ToCharArray()[0])
                    cauDung++;
            }
            return (float)diem * cauDung;
        }
        // lưu bài làm
        public bool luuBaiLam(List<Sapxepde> ds , string pmaTK, string maDe,string maLT, DateTime ngayThi)
        {
            try
            {
                List<BaiLam> lst = new List<BaiLam>();
                int tongCau = ds.Count;
                float diem = (float)10 / tongCau;
                int cauDung = 0;
                foreach (Sapxepde item in ds)
                {
                    BaiLam bl = new BaiLam();
                    bl.MaTK = pmaTK;
                    bl.MaDe = maDe;
                    bl.MaCH = item.MaCH;
                    bl.CauChon = item.dapanchon.ToCharArray()[0];
                    if (item.DapAn == item.dapanchon.ToCharArray()[0])
                        cauDung++;
                    lst.Add(bl);
                }
                dataContext.BaiLams.InsertAllOnSubmit(lst);
                diem = (float)diem * cauDung;
                LichSuThi l = new LichSuThi();
                l.MaLT = maLT;
                l.MaTK = pmaTK;
                l.Diem = diem;
                l.MaDe = maDe;
                l.NgayThi = ngayThi;
                l.SoCauDung = cauDung;
                dataContext.LichSuThis.InsertOnSubmit(l);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:\n" + ex.Message);
                return false;
            }
        }
        //Load lịch sử thi
        public List<View_LichSuThi> loadLichSuThi(string pMaTK)
        {
            return dataContext.View_LichSuThis.Where(t=>t.MaTK==pMaTK).ToList();
        }
    }
}
