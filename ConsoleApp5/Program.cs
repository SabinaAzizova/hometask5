namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                bool isstock = true; //1 saat qalib deye error sebeblerini tapa bilmedim uzurlu sayin
                NoteBook notebook1 = new NoteBook("asus", 0, 2300, 8,512);
                NoteBook notebook2 = new NoteBook("Lenova", 60, 2400, 8, 512);

                notebook1.Sale();
                notebook2.Showfulldata();
            }

        }
    }
 }

