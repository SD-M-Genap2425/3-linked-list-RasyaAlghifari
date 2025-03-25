using System.Text;
namespace LinkedList.ManajemenKaryawan
{
    public class Karyawan
    {
        public string? NomorKaryawan { get; set; }
        public string? Nama { get; set; }
        public string? Posisi { get; set; }
        public Karyawan(string nomorKaryawan, string nama, string posisi)
        {
            NomorKaryawan = nomorKaryawan;
            Nama = nama;
            Posisi = posisi;
        }

    }
    public class KaryawanNode
    {
        public Karyawan Karyawan { get; set; }
        public KaryawanNode? Next { get; set; }
        public KaryawanNode? Prev { get; set; }
        public KaryawanNode(Karyawan karyawan)
        {
            Karyawan = karyawan;
            Next = null;
            Prev = null;
        }
    }
    public class DaftarKaryawan
    {
        //double linked list 
        public KaryawanNode? Head { get; set; }
        public KaryawanNode? Tail { get; set; }
        public DaftarKaryawan()
        {
            Head = null;
            Tail = null;
        }
        public void TambahKaryawan(Karyawan karyawan)
        {
            KaryawanNode newNode = new KaryawanNode(karyawan);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Prev = newNode;
                Head = newNode;
            }
        }
        public bool HapusKaryawan(string nomorKaryawan)
        {
            KaryawanNode current = Head!;
            while (current != null)
            {
                if (current.Karyawan.NomorKaryawan == nomorKaryawan)
                {
                    if (current.Prev == null)
                    {
                        Head = current.Next;
                        if (Head != null)
                        {
                            Head.Prev = null;
                        }
                    }
                    else if (current.Next == null)
                    {
                        Tail = current.Prev;
                        if (Tail != null)
                        {
                            Tail.Next = null;
                        }
                    }
                    else
                    {
                        current.Prev.Next = current.Next;
                        current.Next.Prev = current.Prev;
                    }
                    return true;
                }
                current = current.Next!;
            }
            return false;
        }
        public Karyawan[] CariKaryawan(string KataKunci)
        {
            // Buat metode CariKaryawan yang menerima input parameter kataKunci (string) dan mengembalikan nilai bertipe Karyawan[]. Jika nama atau posisi karyawan mengandung kataKunci maka akan masuk di kembalian Karyawan[]
            KaryawanNode current = Head!;
            Karyawan [] hasil = new Karyawan[0];
            while (current!=null) {
                if (current.Karyawan.Nama!.Contains(KataKunci) || current.Karyawan.Posisi!.Contains(KataKunci))
                {
                    Array.Resize(ref hasil, hasil.Length + 1);
                    hasil[hasil.Length - 1] = current.Karyawan;
                }
                current = current.Next!;    
            } 
            if(hasil!=null){
                return hasil;
            }
            return new Karyawan[0];


        }
        public string TampilkanDaftar()
        {
            StringBuilder sb = new StringBuilder();
            KaryawanNode current = Head!;
            while (current != null)
            {
                sb.Append($"{current.Karyawan.NomorKaryawan}; {current.Karyawan.Nama}; {current.Karyawan.Posisi}\n");
                current = current.Next!;
            }
            Console.WriteLine(sb.ToString().TrimEnd());
            return sb.ToString().TrimEnd();
        }

    }
}