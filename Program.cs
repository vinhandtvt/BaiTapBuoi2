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

