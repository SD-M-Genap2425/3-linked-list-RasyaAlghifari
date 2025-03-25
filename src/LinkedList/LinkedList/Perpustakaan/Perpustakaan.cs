using System.Text;
namespace LinkedList.Perpustakaan
{
    public class Buku
    {
        public string Judul { get; set; }
        public string Penulis { get; set; }
        public int Tahun { get; set; }
        public Buku(string judul, string penulis, int tahun)
        {
            Judul = judul;
            Penulis = penulis;
            Tahun = tahun;
        }
    }
    public class BukuNode
    {
        public Buku Data { get; set; }
        public BukuNode? Next { get; set; }
        public BukuNode(Buku buku)
        {
            Data = buku;
            Next = null;
        }
    }
    public class KoleksiPerpustakaan
    {
        // linked list of BukuNode
        public BukuNode? Head { get; set; }
        public KoleksiPerpustakaan()
        {
            Head = null;
        }
        public void TambahBuku(Buku buku)
        {
            BukuNode newNode = new BukuNode(buku);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                BukuNode current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        public bool HapusBuku(string judul)
        {
            if (Head == null)
            {
                return false;
            }
            if (Head.Data.Judul == judul)
            {
                Head = Head.Next;
                return true;
            }
            BukuNode current = Head;
            while (current.Next != null)
            {
                if (current.Next.Data.Judul == judul)
                {
                    current.Next = current.Next.Next;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public Buku[] CariBuku(string KataKunci)
        {
            BukuNode? current = Head;
            int count = 0;
            while (current != null)
            {
                if (current.Data.Judul.Contains(KataKunci) || current.Data.Penulis.Contains(KataKunci))
                {
                    count++;
                }
                current = current.Next;
            }
            Buku[] result = new Buku[count];
            current = Head;
            int i = 0;
            while (current != null)
            {
                if (current.Data.Judul.Contains(KataKunci) || current.Data.Penulis.Contains(KataKunci))
                {
                    result[i] = current.Data;
                    i++;
                }
                current = current.Next;
            }
            return result;
        }
        public string TampilkanKoleksi()
        {
            StringBuilder sb = new StringBuilder();
            BukuNode? current = Head;
            while (current != null)
            {
                sb.Append($"\"{current.Data.Judul}\"; {current.Data.Penulis}; {current.Data.Tahun}");
                current = current.Next;

            }
            Console.WriteLine(sb.ToString().TrimEnd());
            return sb.ToString();
        }

    }
}