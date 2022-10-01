using System;
using System.IO;

class Test
{
    public static void Main()
    {
        DriveInfo[] allDrives = DriveInfo.GetDrives();

        foreach (DriveInfo d in allDrives)
        {
            Console.WriteLine("Unidade {0}", d.Name);
            Console.WriteLine("  Tipo de unidade: {0}", d.DriveType);
            if (d.IsReady == true)
            {
                Console.WriteLine("  Rótulo de volume: {0}", d.VolumeLabel);
                Console.WriteLine("  Sistema de arquivos: {0}", d.DriveFormat);
                Console.WriteLine(
                    "  Espaço disponível para o usuário atual:{0, 15} bytes",
                    d.AvailableFreeSpace);

                Console.WriteLine(
                    "  Espaço total disponível:               {0, 15} bytes",
                    d.TotalFreeSpace);

                Console.WriteLine(
                    "  Tamanho total da unidade:              {0, 15} bytes ",
                    d.TotalSize);
            }
        }

        Console.ReadKey();
    }
}
