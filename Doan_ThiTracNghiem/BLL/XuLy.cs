using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Doan_ThiTracNghiem.DAL;
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
                TaiKhoan tk = dataContext.TaiKhoans.FirstOrDefault(t=>t.MaUse==pMaUSe);
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
        //public async void luuHinhAnhAsync(Stream stream,string ten,ref string hinh)
        //{

        //    var auth = new FirebaseAuthProvider(new Firebase.Auth.FirebaseConfig("AIzaSyAKZ7K7KmoYFxo88dQRkeAHtngm67KD7t0"));
        //    var a = await auth.SignInWithEmailAndPasswordAsync("trantanhieu1804@gmail.com", "180403");

        //    // Constructr FirebaseStorage, path to where you want to upload the file and Put it there
        //    var task = new FirebaseStorage(
        //        "appphim-dc807.appspot.com",


        //         new FirebaseStorageOptions
        //         {
        //             AuthTokenAsyncFactory = () => Task.FromResult(a.FirebaseToken),
        //             ThrowOnCancel = true,
        //         })
        //        .Child("Image")
        //        .Child(DateTime.Now.Millisecond + ten)
        //        .PutAsync(stream);

        //    // Track progress of the upload
        //    task.Progress.ProgressChanged += (s, e) => Console.WriteLine($"Progress: {e.Percentage} %");

        //    // await the task to wait until upload completes and get the download url
        //    var downloadUrl = await task;
        //    hinh = downloadUrl;

        //}

    }
}
