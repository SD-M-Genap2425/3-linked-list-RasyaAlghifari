using System.Text;
namespace LinkedList.Inventori{
using LinkedList;
    public class Item{
        public string Nama{get; set;}
        public int Kuantitas{get; set;}
        public Item(string nama, int kuantitas){
            Nama = nama;
            Kuantitas = kuantitas;
        }
    }
    public class ManajemenInventori{
        //use Linkedlist<item> to store the item
        public LinkedList<Item> Items {get; set;}
        public ManajemenInventori(){
            Items = new LinkedList<Item>();
        }
        public void TambahItem(Item item){
            Items.AddLast(item);
        }
        public bool HapusItem(string nama){
            foreach(Item item in Items){
                if(item.Nama == nama){
                    Items.Remove(item);
                    return true;
                }
            }
            return false;
        }
        public string TampilkanInventori(){
            // print to console and return the string in {name}; {quantity} format
            StringBuilder sb = new StringBuilder();
            foreach(Item item in Items){
                sb.Append($"{item.Nama}; {item.Kuantitas}\n");
            }
            Console.WriteLine(sb.ToString());
            return sb.ToString().TrimEnd();
        }
    }
}