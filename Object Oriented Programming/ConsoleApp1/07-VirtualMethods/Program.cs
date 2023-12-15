namespace _07_VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elektronik elektronik = new Elektronik();
            elektronik.Barkod = "123456789";
            elektronik.RAM = "16GB";
            elektronik.CPU = "Intel i7";

            Console.WriteLine(elektronik.BarkodGetir());
            Console.WriteLine("RAM: " + elektronik.RAM);
            Console.WriteLine("CPU: " + elektronik.CPU);

            elektronik.BarkodYaz();
        }
    }
}
