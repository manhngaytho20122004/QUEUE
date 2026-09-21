/* 
 
-- Queue(Hàng đợi) trong C# là một cấu trúc dữ liệu quan trọng
-- Queue là cấu trúc dữ liệu FIFO(fisrt in fisrt out)  vào trước xử lý trước vào  sau xử lý sau, giống như việc bạn xếp hàng
xếp hàng trước được mua trước, xếp hàng sau được mua sau.
--- Cú pháp:   Queue<T> name = new Queue<T>();
--- Các phương thức cơ bản làm việc với Queue.

.Count      -->   lấy tổng số phần tử
.Enqueue	-->   vào xếp hàng - đưa phần tử vào cuối hàng đợi
.Dequeue	-->   lấy phần tử ở đầu hàng đợi và xóa nó khỏi queue - lỗi nếu hàng đợi không có phần tử nào
                  (Việc lấy phần tử ra cũng như việc xóa phần tử vậy)
.Peek	    -->   đọc phần tử đầu hàng đợi
 
 
 */
using System.Reflection.Metadata;

internal class Program
{
    
    private static void Main(string[] args)
    {
       Queue<string> hoso = new Queue<string>();
        // Thêm các hồ sơ vào hàng để xử lý
        hoso.Enqueue("Ho so A");
        hoso.Enqueue("Ho so B");
        hoso.Enqueue("Ho so C");
        hoso.Enqueue("Ho so D");
        // Lấy từng phần tử trong hàng ra
        while (hoso.Count > 0)
        {
           var hs = hoso.Dequeue();
           Console.WriteLine($"Lay {hs} ra khoi queue");
           Console.WriteLine("So luong ho so con lai: "+ hoso.Count);
            Console.WriteLine("------------------------");
        }
        Console.WriteLine("XIn chao cac ban");
        Console.WriteLine("XIn chao cac ban");
        Console.WriteLine("XIn chao cac ban");
        Console.WriteLine("XIn chao cac ban");
        Console.WriteLine("XIn chao cac ban");
        Console.WriteLine("XIn chao cac ban");
        Console.WriteLine("XIn chao cac ban");

        Console.WriteLine("XIn chao cac ban");

        Console.WriteLine("XIn chao cac ban");



    }
}