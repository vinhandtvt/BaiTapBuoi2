class ZBaiTapBuoi8
{
    /*
    Bài 1:
        IstNumber = [20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20]
        Bài Toán: Tính tổng các số trong mảng
        Mô Tả: Bạn được cung cấp 1 mảng số nguyên IstNumber, nhiệm vụ của bạn là tính tổng các số ở trong mảng này
        Input: IstNumber: Một danh sách(Mảng) các số nguyên, đây là mảng bạn cần tính tổng
        Output: Trả về tổng của tất cả các số trong mảng IstNumber

    */

    static List<int> IstNumber = new List<int>() { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };
    public static int TongCacSoTrongMang()
    {
        int sum = 0;
        foreach (int number in IstNumber)
        {
            sum += number;
        }

        return sum;
    }

    /*
    *Bài 2:
        Ist_number = [2, 7, 11, 15]
        Mô Tả: Tìm hai số trong tổng danh sách số nguyên sao cho tổng của chúng bằng một giá trị target cho trước
        Ví dụ:
        Input: Nums = [2, 7, 11, 15], target = 9
        Output: [0, 1] (vì nums[0] + nums[1] = 2 + 7 = 9) ngược lại nếu không có
    */

    static List<int> Ist_number = new List<int>() { 2, 7, 11, 15 };
    public static void tongHaiSo(int target = 0)
    {
        for (int i = 0; i < Ist_number.Count; i++)
        {
            for (int j = i + 1; j < Ist_number.Count; j++)
            {
                if (Ist_number[i] + Ist_number[j] == target)
                {
                    Console.WriteLine($"[{i}, {j}] (vì Ist_number[{i}] + Ist_number[{j}] = {Ist_number[i]} + {Ist_number[j]} = {target})");
                    return;
                }
            }
        }
        Console.WriteLine("khong co so nao");

    }

    /*
        Bài 3:
            IstNumber = [1, 1, 2, 2, 2, 3, 4, 4, 5]
            Bài Toán: Remove duplicates from sorted Array(Easy)
            Mô Tả: Loại bỏ các phần tử trùng lặp từ một mảng đã sắp xếp và trả về chiều dài của mảng mới.
            Ví dụ:
            Input: nums = [1, 1, 2, 2, 2, 3, 4, 4, 5]
            Output: 5(Mảng mới là [1, 2, 3, 4, 5])
    */

    public static List<int> Bai3_IstNumber = new List<int>() { 1, 1, 2, 2, 2, 3, 4, 4, 5 };
    public static List<int> XoaSoTrungNhauTrongMang(List<int> lst)
    {
        List<int> result = new List<int>();

        foreach (int item in lst)
        {
            if (!result.Contains(item))
            {
                result.Add(item);
            }
        }

        return result;
    }

    /*
    Bài 4:
        IstNumber = [1, 1, 1, 2, 2, 3]
        Bài Toán: Remove duplicates from sorted Array(Easy)
        Mô Tả: Cho 1 mảng số nguyên, tìm phần tử k xuất hiện nhiều nhất trong mảng và trả chúng về dưới dạng danh sách. Nếu có nhiều phần tử cùng tần số xuất hiện trả về bất kì trong số chúng.
        Ví dụ:
        Input: nums =[1, 1, 1, 2, 2, 3] k = 2
        Output: [1, 2]
        Giải Thích: trong mảng nums, số 1 xuất hiện 3 lần, số 2 xuất hiện 2 và số 3 xuất hiện 1 lần. Ta cần trả về 2 phần tử xuất hiện nhiều lần nhất chúng có thể là 1 và 2 hoặc ( 2 và 1 )
        Lưu ý: Kết quả được trả về dưới bất kì thứ tự nào. Số lần xuất hiện của các phần tử không cần tuân theo thứ tự tăng dần

    */
    static List<int> Bai4_IstNumber = new List<int>() { 1, 1, 1, 2, 2, 3 };

    public static List<int> TimKPhanTuXuatHienNhieuNhatTrongMang(int k)
    {
        List<int[]> TanSoXuatHien = new List<int[]>();
        List<int> LstXoaSoTrungNhau = XoaSoTrungNhauTrongMang(Bai4_IstNumber);

        // Dem so lan xuat hien
        foreach (int so in LstXoaSoTrungNhau)
        {
            TanSoXuatHien.Add(new int[] { so, DemSoLan(Bai4_IstNumber, so) });
        }

        // Sap xep theo so lan xuat hien
        for (int i = 0; i < TanSoXuatHien.Count; i++)
        {
            for (int j = i + 1; j < TanSoXuatHien.Count; j++)
            {
                if (TanSoXuatHien[i][1] < TanSoXuatHien[j][1])
                {
                    int[] temp = TanSoXuatHien[i];
                    TanSoXuatHien[i] = TanSoXuatHien[j];
                    TanSoXuatHien[j] = temp;
                }
            }
        }

        // ket qua
        List<int> KetQua = new List<int>();
        for (int i = 0; i < k; i++)
        {
            KetQua.Add(TanSoXuatHien[i][0]);
        }
        return KetQua;
    }
    static int DemSoLan(List<int> lst, int num)
    {
        int count = 0;
        foreach (int item in lst)
        {
            if (item == num)
            {
                count += 1;
            }
        }
        return count;
    }

    /*
    Bài 5:
        prices = [7, 1, 5, 3, 6 ,4]
        Bài Toán: Best time to Buy and Sell Stock
        Mô Tả: Cho 1 mảng prices, mỗi phần tử của nó đại diện cho giá của cổ phiếu trong một ngày. Bạn chỉ được mua cổ phiếu 1 lần và bán cổ phiếu 1 lần. Hãy tìm giá trị lớn nhất từ việc mua và bán
        cổ phiếu
        Ví dụ:
        Input: nums =[7, 1, 5, 3, 6, 4]
        Output: 5
        Giải Thích: Bạn mua vào ngày thứ 2 với giá (1) và bán ra vào ngày thứ (5) với giá 6 lãi 6 - 1 = 5
    */
    static List<int> Bai5_Lst = new List<int>() { 7, 1, 5, 3, 6, 4 };

    public static int GioVangMuaCoPhieu()
    {
        int KetQua = 0;
        List<int> LoiNhuan = new List<int>();
        for (int i = 0; i < Bai5_Lst.Count; i++)
        {
            int GiaMua = Bai5_Lst[i];
            int LoiNhuanLonNhatMoiLuotMua = TimHieuLonNhat(Bai5_Lst, i + 1, GiaMua);
            LoiNhuan.Add(LoiNhuanLonNhatMoiLuotMua);
        }
        if (LoiNhuan.Count != 0)
        {
            KetQua = LoiNhuan.Max();
        }
        return KetQua;
    }

    static int TimHieuLonNhat(List<int> lst, int index, int GiaMua)
    {
        int KetQua = 0;
        List<int> lstMoi = new List<int>();
        for (int i = index; i < lst.Count; i++)
        {
            int HieuSo = lst[i] - GiaMua;
            lstMoi.Add(HieuSo);
        }
        if (lstMoi.Count != 0)
        {
            KetQua = lstMoi.Max();
        }
        return KetQua;
    }

}