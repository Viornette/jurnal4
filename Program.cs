using modul4_103022300145;

internal class program
{
    public static void Main(string[] args)
    {
        Console.Write("Masukkan Nama Produk Elektronik : ");
        string produk = Console.ReadLine();
        Console.WriteLine("Kode Produk : " + KodeProduk.getKodeProduk(produk));
    }
}