using LinkedList.ManajemenKaryawan;
using LinkedList.Perpustakaan;
using LinkedList.Inventori;
namespace LinkedList;

class Program
{
    static void Main(string[] args)
    {
        // Soal Perpustakaan
        KoleksiPerpustakaan k = new KoleksiPerpustakaan();
        k.TambahBuku(new Buku("The Hobbit", "J.R.R. Tolkien", 1937));
        k.TambahBuku(new Buku("1984", "George Orwell", 1949));
        k.TambahBuku(new Buku("The Catcher in the Rye", "J.D. Salinger", 1951));
        k.TampilkanKoleksi();
        

        // Soal ManajemenKaryawan
        DaftarKaryawan d = new DaftarKaryawan();
        d.TambahKaryawan(new Karyawan("K001", "John Doe", "Manager"));
        d.TambahKaryawan(new Karyawan("K002", "Jane Doe", "HR"));
        d.TambahKaryawan(new Karyawan("K003", "Bob Smith", "IT"));        
        d.TampilkanDaftar();
        // Soal Inventori
        ManajemenInventori m = new ManajemenInventori();
        m.TambahItem(new Item("Apple", 50));
        m.TambahItem(new Item("Orange", 30));
        m.TambahItem(new Item("Banana", 20));
        m.TampilkanInventori();
    }
}
