#region Bài 1: Tính số ngày trong tuần và số ngày lẻ.
Console.WriteLine("Hãy nhập vào số ngày? ");
int soNgay = Convert.ToInt32(Console.ReadLine());

int soTuan = soNgay / 7;
int soNgayLe = soNgay % 7;

Console.WriteLine($"{soNgay} ngày tương ứng với {soTuan} tuần và lẻ {soNgayLe} ngày");
#endregion

#region Bài 2: Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá.
// //input: giaTriDonHang: double, phanTramGiamGia: double
// //output: ketQua: double
// double ketQua = 0.0;
// double giaTriGiamGia = 0.0;

// Console.WriteLine("Hãy nhập vào giá trị đơn hàng của bạn: ");
// double giaTriDonHang = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Hãy nhập vào phần % giảm giá: ");
// double phanTramGiamGia = Convert.ToDouble(Console.ReadLine());

// // process 
// giaTriGiamGia = giaTriDonHang * (phanTramGiamGia / 100);
// ketQua = giaTriDonHang - giaTriGiamGia;

// Console.WriteLine($"Giá trị đơn hàng của bạn là: {giaTriDonHang}");
// Console.WriteLine($"Bạn được giảm giá: {giaTriGiamGia}");
// Console.WriteLine($"Tổng phải thanh toán: {ketQua}");
#endregion

#region Bài 3: Chuyển đổi thời gian từ phút sang giờ và phút
// //input: soPhut: int
// Console.WriteLine("Hãy nhập vào số phút: ");
// int soPhut = Convert.ToInt32(Console.ReadLine());
// //process
// int soGio = soPhut / 60;
// int soPhutConLai = soPhut % 60;
// //output
// Console.WriteLine($"{soPhut} phút tương ứng với {soGio} giờ và {soPhutConLai} phút.");

#endregion

#region Bài 4: Tính tổng số tiền sau khi cộng thêm thuế VAT.
// //input: giaTriDonHang: double, vat: double
// double ketQua = 0.0;
// Console.WriteLine("Hãy nhập vào giá trị đơn hàng của bạn: ");
// double giaTriDonHang = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Hãy nhập vào giá trị thuế VAT % (vd 10): ");
// double vat = Convert.ToDouble(Console.ReadLine());

// //process
// double phiVAT = giaTriDonHang * (vat / 100);
// ketQua = giaTriDonHang + phiVAT;

// //output
// Console.WriteLine($"Giá trị đơn hàng của bạn là: {giaTriDonHang}");
// Console.WriteLine($"Phí VAT: {phiVAT}");
// Console.WriteLine($"Tổng phải thanh toán: {ketQua}");

#endregion

#region Bài 5: Chuyển đổi đơn vị tiền tệ.
// //input: soTien: double, tyGia: double
// double vnd = 0.0;
// Console.WriteLine("Hãy nhập vào số tiền USD: ");
// double usd = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Hãy nhập vào tỷ giá VND: ");
// double tyGia = Convert.ToDouble(Console.ReadLine());

// //process
// vnd = usd * tyGia;

// //output
// Console.WriteLine($"{usd} với tỷ giá {tyGia} đổi ra vnd là: {vnd} đồng.");
#endregion

#region Bài 6: Tính số dư sau khi rút tiền từ tài khoản.
// //input: soTien: double, soTienRut: double,
// Console.WriteLine("Hãy nhập vào số dư tài khoản: ");
// double soTien = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Hãy nhập vào số tiền muốn rút: ");
// double soTienRut = Convert.ToDouble(Console.ReadLine());

// //Process
// double soDuTaiKhoan = soTien - soTienRut;

// Console.WriteLine($"Số dư trong tài khoản của bạn là: {soDuTaiKhoan}");

#endregion

#region Bài 7: Tính tốc độ trung bình
// //input: quangDuong: double, thoiGian: double
// Console.WriteLine("Hãy nhập quãng đường bạn đã đi (km): ");
// double quangDuong = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Hãy nhập vào thời gian bạn đã đi (giờ): ");
// double thoiGian = Convert.ToDouble(Console.ReadLine());

// //process
// double tocDoTrungBinh = quangDuong / thoiGian;

// //output
// Console.WriteLine($"Tốc độ trung bình của bạn là: {tocDoTrungBinh} (km/h)");
#endregion

#region Bài 8: Tính tỷ lệ phần trăm
// //input: soPhanTram: double, tong: double
// Console.WriteLine("Hãy nhập vào số cần tính phần trăm: ");
// double soPhanTram = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Hãy nhập vào tổng số: ");
// double tong = Convert.ToDouble(Console.ReadLine());

// //process
// double tyLePhanTram = (soPhanTram / tong) * 100;

// //output
// Console.WriteLine($"Phần trăm là : {Math.Round(tyLePhanTram, 2)}%");
#endregion

#region Bài 9: Chuyển đổi từ km/h ---> m/s 
// //input: tocDoKM: double
// Console.WriteLine("Hãy nhập vào tốc độ (km/h) ");
// double tocDoKM = Convert.ToDouble(Console.ReadLine());

// //process
// double tocDoMS = tocDoKM / 3.6;

// //output
// Console.WriteLine($"{tocDoKM} km/h = {Math.Round(tocDoMS, 2)} m/s");
#endregion

#region Bài 10: Tính lượng calo tiêu thụ


#endregion

