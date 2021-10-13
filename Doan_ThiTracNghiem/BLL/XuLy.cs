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
        public struct dulieuThongke
        {
            public string maTK;
            public float diem;
            public string cauChon;
        }
        public struct thongKe
        {
            public string maCau;
            public int soTKtl;
            public string dapAnDung;
            public List<dulieuThongke> danhsach;
        }
        public struct KetquaThongKe
        {
            public int chisokho;
            public float chisophanbiet;
            public string ketqua;
        }
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
        //Lấy một tài khoản theo ma
        public TaiKhoan loadTaiKhoan(string pMaTK)
        {
            return dataContext.TaiKhoans.FirstOrDefault(t => t.MaUse == pMaTK);
        }
        //Lấy danh sách loại tài khoản
        public List<LoaiTaiKhoan> loadLoai()
        {
            return dataContext.LoaiTaiKhoans.ToList();
        }
        //Lấy danh sách các chức năng
        public List<ChucNang> loadChucNangAll()
        {
           return dataContext.ChucNangs.ToList();
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
        //Them ms mon
        public string themMaMon()
        {
            MonThi tk;
            int Ma;
            if (dataContext.MonThis.OrderByDescending(t => t.MaMon).ToList().Count != 0)
            {
                tk = dataContext.MonThis.OrderByDescending(t => t.MaMon).ToList()[0];
                Ma = int.Parse(tk.MaMon.Remove(0, 2));
            }
            else
                Ma = 0;
            if (Ma + 1 < 10)
                return "MT00" + (Ma + 1);
            if (Ma + 1 < 100)
                return "MT0" + (Ma + 1);
            return "MT" + (Ma + 1);
        }
        public bool themMonThi(string pmaMon,string pTenMon)
        {
            try
            {
                MonThi m = new MonThi();
                m.MaMon = pmaMon;
                m.TenMon = pTenMon;
                dataContext.MonThis.InsertOnSubmit(m);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:\n" + ex.Message);
                return false;
            }

        }
        
        public bool suaMonThi(string pmaMon, string pTenMon)
        {
            try
            {
                MonThi m = dataContext.MonThis.FirstOrDefault(t => t.MaMon == pmaMon);
                m.MaMon = pmaMon;
                m.TenMon = pTenMon;
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:\n" + ex.Message);
                return false;
            }

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
        //Xoa cau hoi
        public bool xoaCauHoi(string pmaCh)
        {
            try
            {
                NganHangCauHoi ng = dataContext.NganHangCauHois.FirstOrDefault(t => t.MaCH == pmaCh);
                dataContext.NganHangCauHois.DeleteOnSubmit(ng);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : \n" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool suaCauHoi(string pMaMon, string pMaCau, string pNoiDung, string A, string B, string C, string D, char pDapAn)
        {
            try
            {
                NganHangCauHoi cau = dataContext.NganHangCauHois.FirstOrDefault(c => c.MaCH == pMaCau);
                cau.MaCH = pMaCau;
                cau.NoiDung = pNoiDung;
                cau.A = A;
                cau.B = B;
                cau.C = C;
                cau.D = D;
                cau.DapAn = pDapAn;
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : \n" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // thêm mới mội tài khoản và lưu vào database.
        public async void themUseAsync(string pMaUSe, string pTenDN, string pMatKhau, string pHoTen, string pGioiTinh, DateTime pNgaySinh, string pNoiSinh, OpenFileDialog pHinhAnh, string pLoaiTK,List<ChucNangTaiKhoan> lst)
        {
            try
            {
                Stream stream;
                TaiKhoan tk = new TaiKhoan();
                if (pHinhAnh != null)
                {
                    stream = pHinhAnh.OpenFile();
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
                else
                    tk.HinhAnh = "https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f";

                tk.MaUse = pMaUSe;
                tk.Usename = pTenDN;
                tk.Pass = pMatKhau;
                tk.HoTen = pHoTen;
                tk.GioiTinh = pGioiTinh;
                tk.NgaySinh = pNgaySinh;
                tk.NoiSinh = pNoiSinh;
                
                tk.LoaiTK = pLoaiTK;
                dataContext.TaiKhoans.InsertOnSubmit(tk);
                dataContext.ChucNangTaiKhoans.InsertAllOnSubmit(lst);
                dataContext.SubmitChanges();
                dataContext.SubmitChanges();
                MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : \n" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        // Chỉnh sửa thông tin của một tài khoản
        public async void suaUseAsync(string pMaUSe, string pTenDN, string pMatKhau, string pHoTen, string pGioiTinh, DateTime pNgaySinh, string pNoiSinh, OpenFileDialog pHinhAnh, string pLoaiTK,List<ChucNangTaiKhoan>lst)
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
                List<ChucNangTaiKhoan> lstdata = dataContext.ChucNangTaiKhoans.Where(c => c.MaTK == pMaUSe).ToList();
                dataContext.ChucNangTaiKhoans.DeleteAllOnSubmit(lstdata);
                dataContext.ChucNangTaiKhoans.InsertAllOnSubmit(lst);
                dataContext.SubmitChanges();
                MessageBox.Show("Cập Nhật Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : \n" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        //Xóa tài khoản
        public bool xoaUse(string maTK)
        {
            try
            {
                List<ChucNangTaiKhoan> lstCn = dataContext.ChucNangTaiKhoans.Where(cn => cn.MaTK == maTK).ToList();
                List<BaiLam> lstBailam = dataContext.BaiLams.Where(bl => bl.MaTK == maTK).ToList();
                List<LichSuThi> lstLst = dataContext.LichSuThis.Where(lst => lst.MaTK == maTK).ToList();
                List<LichThi> lstLT = dataContext.LichThis.Where(lt => lt.MaGV == maTK).ToList();
                List<ThamGiaThi> lstTgt = dataContext.ThamGiaThis.Where(tgt => tgt.MaTK == maTK).ToList();
                if (lstCn.Count != 0)
                    dataContext.ChucNangTaiKhoans.DeleteAllOnSubmit(lstCn);
                if (lstBailam.Count != 0)
                    dataContext.BaiLams.DeleteAllOnSubmit(lstBailam);
                if (lstLst.Count != 0)
                    dataContext.LichSuThis.DeleteAllOnSubmit(lstLst);
                if (lstLT.Count != 0)
                    dataContext.LichThis.DeleteAllOnSubmit(lstLT);
                if (lstTgt.Count != 0)
                    dataContext.ThamGiaThis.DeleteAllOnSubmit(lstTgt);
                TaiKhoan tk = dataContext.TaiKhoans.FirstOrDefault(t => t.MaUse == maTK);
                if (tk.MaUse != null)
                    dataContext.TaiKhoans.DeleteOnSubmit(tk);
                dataContext.SubmitChanges();
                return true;

            }
            catch (Exception ex)
            {
                    MessageBox.Show("Lỗi : \n" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        //Them use từ excel
        public bool themTkExcel(string pMaLoai,DataGridViewRow dgv, List<ChucNangTaiKhoan> lst)
        {
            try
            {

                TaiKhoan tk = new TaiKhoan();
                tk.HinhAnh = "https://firebasestorage.googleapis.com/v0/b/appphim-dc807.appspot.com/o/error-image-generic.png?alt=media&token=85cfc89f-68f8-4500-8cf9-df9de3b92b3f";
                tk.MaUse = themMaUse();
                tk.Usename = tk.MaUse;
                tk.HoTen = dgv.Cells[1].Value.ToString();
                tk.GioiTinh = dgv.Cells[4].Value.ToString();
                tk.NgaySinh = DateTime.Parse(dgv.Cells[2].Value.ToString());
                tk.Pass = tk.NgaySinh.Value.ToShortDateString().Replace("/", "");
                tk.NoiSinh = dgv.Cells[3].Value.ToString();
                tk.LoaiTK = pMaLoai;

                dataContext.TaiKhoans.InsertOnSubmit(tk);
                dataContext.ChucNangTaiKhoans.InsertAllOnSubmit(lst);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : \n" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
        //lay danh sach de theo mon
        public List<DeThi> loadDetheoMon(string pMaMon)
        {
            return dataContext.DeThis.Where(d => d.MaMon == pMaMon).ToList();
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
        public List<NganHangCauHoi> loadNoiDungDe(string pMaDe)
        {
            List<NganHangCauHoi> nganHangCauHois = new List<NganHangCauHoi>();
            List<NoiDungDe> lst = dataContext.NoiDungDes.Where(d => d.MaDe == pMaDe).ToList();
            foreach(NoiDungDe item in lst)
            {
                NganHangCauHoi ch = dataContext.NganHangCauHois.FirstOrDefault(c => c.MaCH == item.MaCH);
                nganHangCauHois.Add(ch);
            }
            return nganHangCauHois;
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
        public bool themDe(string pMaDe, string pTenDe, string pMaMon, int pThoiGian,int socau)
        {
            try
            {
                DeThi dt = new DeThi();
                dt.MaDe = pMaDe;
                dt.MaMon = pMaMon;
                dt.TenDe = pTenDe;
                dt.ThoiGian = pThoiGian;
                dt.SoCau = socau;
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
        public List<LichThi> loadLich()
        {
            return dataContext.LichThis.ToList();
        }
        //public List<MonThi> LoadMon(string ma)
        //{
        //    LichThi lich = dataContext.LichThis.FirstOrDefault(s => s.MaLT == ma);
        //    return dataContext.MonThis.Where(d=>d.MaMon==lich.ma)
        //}
        public List<TaiKhoan> loadngthamgia(string malt)
        {
            List<ThamGiaThi> lst = dataContext.ThamGiaThis.Where(t => t.MaLT == malt).ToList();
            List<TaiKhoan> lsttk = new List<TaiKhoan>();
            foreach(ThamGiaThi item in lst)
            {
                TaiKhoan tk = dataContext.TaiKhoans.FirstOrDefault(t => t.MaUse == item.MaTK);
                lsttk.Add(tk);
            }
            return lsttk;
        }
        public bool suaLichThi(string pMaLT, string pMaGV, string pMaDe, DateTime pNgayThi, string pTenKythi)
        {
            try
            {
                LichThi lt = dataContext.LichThis.FirstOrDefault(t => t.MaLT == pMaLT);
                lt.MaDe = pMaDe;
                lt.MaGV = pMaGV;
                lt.NgayThi = pNgayThi;
                lt.TenKyThi = pTenKythi;
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        public List<DataViewThongKe> loaddulieuThongKe()
        {
            List<thongKe> ls = new List<thongKe>();
            List<DataViewThongKe> data = new List<DataViewThongKe>();
            List<IGrouping<string,BaiLam>> lst = dataContext.BaiLams.GroupBy(t => t.MaCH).ToList();
            foreach(var item in lst)
            {
                DataViewThongKe dataview = new DataViewThongKe();
                dataview.cauA = 0;
                dataview.cauB = 0;
                dataview.cauC = 0;
                dataview.cauD = 0;
                thongKe a = new thongKe();
                a.soTKtl = item.Count();
                List<dulieuThongke> lstdulieu = new List<dulieuThongke>();
                foreach (BaiLam bl in item)
                {
                    dulieuThongke b;
                    a.maCau = bl.MaCH;
                    a.dapAnDung = dataContext.NganHangCauHois.FirstOrDefault(t => t.MaCH == bl.MaCH).DapAn.ToString();
                    b.maTK = bl.MaTK;
                    b.diem = (float)dataContext.LichSuThis.FirstOrDefault(l => l.MaTK == bl.MaTK && l.MaDe == bl.MaDe).Diem;
                    b.cauChon = bl.CauChon.ToString();
                    if (b.cauChon == "A")
                        dataview.cauA++;
                    else
                        if (b.cauChon == "B")
                        dataview.cauB++;
                    else
                        if (b.cauChon == "C")
                        dataview.cauC++;
                    else
                    if (b.cauChon == "D")
                        dataview.cauD++;
                    lstdulieu.Add(b);            
                }
                dataview.MaCH = a.maCau;
                dataview.CauDung = a.dapAnDung;
                a.danhsach = lstdulieu;
                int so = (a.soTKtl*27)/100;

                ls.Add(a);
                data.Add(dataview);
            }

            return data;
        }
        public KetquaThongKe chisoKho(string mach)
        {
            List<BaiLam> lst = dataContext.BaiLams.Where(b => b.MaCH == mach).ToList();
            thongKe a = new thongKe();
            a.soTKtl = lst.Count();
            int so = (a.soTKtl * 27) / 100;
            DataViewThongKe da = new DataViewThongKe();
            List<dulieuThongke> lstdulieu = new List<dulieuThongke>();
            foreach (BaiLam bl in lst)
            {
                dulieuThongke b;
                a.maCau = bl.MaCH;
                a.dapAnDung = dataContext.NganHangCauHois.FirstOrDefault(t => t.MaCH == bl.MaCH).DapAn.ToString();
                b.maTK = bl.MaTK;
                b.diem = (float)dataContext.LichSuThis.FirstOrDefault(l => l.MaTK == bl.MaTK && l.MaDe == bl.MaDe).Diem;
                b.cauChon = bl.CauChon.ToString();
                lstdulieu.Add(b);
            }
            List<dulieuThongke> diemcao =lstdulieu.OrderByDescending(t => t.diem).Take(so).ToList();
            a.danhsach = diemcao;
            int songuoichondungDiemcao = diemcao.Where(k => k.cauChon == a.dapAnDung).Count();
            List<dulieuThongke> diemthap = lstdulieu.OrderBy(t => t.diem).Take(so).ToList();
            int songuoichondungdiemthap = diemthap.Where(k => k.cauChon == a.dapAnDung).Count();
            int chisokho = (songuoichondungDiemcao + songuoichondungdiemthap) * 100 / (2*so);
            float chisophanbiet = (float)(songuoichondungDiemcao - songuoichondungdiemthap) * 2/ (2*so);
            KetquaThongKe kq = new KetquaThongKe();
            kq.chisokho = chisokho;
            kq.chisophanbiet = chisophanbiet;
            if(chisokho>=30&&chisokho<=70&&chisophanbiet>=0.25)
            {
                kq.ketqua = "Câu này rất tốt, nên giữ";
            } 
            else
            {
                if(((chisokho>=15&&chisokho<=30)||(chisokho>=70&&chisokho<=80))&&(chisophanbiet>=0.15&&chisophanbiet<0.25))
                    kq.ketqua = "Câu này nên xem xét hoặc sửa chữa";
                else
                    kq.ketqua = "Câu này không nên dùng, nên loại bỏ";
            }
            return kq;
        }
    }
}
