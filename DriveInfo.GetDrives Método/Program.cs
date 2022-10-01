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
/*
Este código produz uma saída semelhante à seguinte:

Unidade A:\
  Tipo de unidade: removível
Unidade C:\
  Tipo de acionamento: Fixo
  Rótulo de volume:
  Sistema de arquivos: FAT32
  Espaço disponível para o usuário atual: 4770430976 bytes
  Espaço total disponível: 4770430976 bytes
  Tamanho total da unidade: 10731683840 bytes
Unidade D:\
  Tipo de acionamento: Fixo
  Rótulo de volume:
  Sistema de arquivos: NTFS
  Espaço disponível para o usuário atual: 15114977280 bytes
  Espaço total disponível: 15114977280 bytes
  Tamanho total da unidade: 25958948864 bytes
Unidade E:\
  Tipo de unidade: CDRom

A saída real deste código varia de acordo com a máquina e as permissões
concedido ao usuário que o executa.
*/