

#region Bai 1 buoi 8

Console.WriteLine("===============BAI TAP 1===============");
int TongCacSoTrongMang = ZBaiTapBuoi8.TongCacSoTrongMang();
Console.WriteLine($"Tong cac so trong mang la: {TongCacSoTrongMang}");

Console.WriteLine("===============END BAI TAP 1===========");
#endregion

#region Tìm hai số trong tổng danh sách số nguyên sao cho tổng của chúng bằng một giá trị target cho trước
Console.WriteLine("===============BAI TAP 2===============");
ZBaiTapBuoi8.tongHaiSo(9);

Console.WriteLine("===============END BAI TAP 2===========");
#endregion

#region Remove duplicates from sorted Array(Easy)
Console.WriteLine("===============BAI TAP 3===============");
List<int> LstSauXoa = ZBaiTapBuoi8.XoaSoTrungNhauTrongMang(ZBaiTapBuoi8.Bai3_IstNumber);
Console.WriteLine($"List sau khi xoa la: [{string.Join(",", LstSauXoa)}]");

Console.WriteLine("===============END BAI TAP 3===========");
#endregion

#region Remove duplicates from sorted Array(Easy)
Console.WriteLine("===============BAI TAP 4===============");
int SoK = 2;
List<int> TimKPhanTuXuatHienNhieuNhatTrongMang = ZBaiTapBuoi8.TimKPhanTuXuatHienNhieuNhatTrongMang(SoK);
Console.WriteLine($"{SoK} Nhieu nhat la: [{string.Join(",", TimKPhanTuXuatHienNhieuNhatTrongMang)}]");

Console.WriteLine("===============END BAI TAP 4===========");
#endregion


#region Remove duplicates from sorted Array(Easy)
Console.WriteLine("===============BAI TAP 5===============");
int Lai = ZBaiTapBuoi8.GioVangMuaCoPhieu();
Console.WriteLine($"Lai Nhieu nhat la: {Lai}");

Console.WriteLine("===============END BAI TAP 5===========");
#endregion

