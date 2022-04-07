using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace FakeSys32Delete
{
    internal class Program
    {
        static void Main()
        {
            //0x400023A1
            string fileDeletedTranslation = "Deleted file";
            switch (CultureInfo.CurrentCulture.Name.ToLower())
            {
                case "it-it":
                    fileDeletedTranslation = "File eliminato";
                    break;
                case "ko-kr":
                    fileDeletedTranslation = "파일 삭제";
                    break;
                case "de-de":
                    fileDeletedTranslation = "Datei gelöscht";
                    break;
                case "es-es":
                    fileDeletedTranslation = "Archivo eliminado";
                    break;
                case "fr-fr":
                    fileDeletedTranslation = "Fichier supprimé";
                    break;
                case "ru-ru":
                    fileDeletedTranslation = "Удаленный файл";
                    break;
                case "pt-pt":
                    fileDeletedTranslation = "Arquivo excluído";
                    break;
                case "ja-ja":
                    fileDeletedTranslation = "削除されたファイル";
                        break;
            }
            int wait = 0;
            foreach (string fileName in Directory.GetFileSystemEntries("C:\\windows\\system32"))
            {
                Console.WriteLine($"{fileDeletedTranslation} - {fileName}");
                if (wait > 6)
                {
                    System.Threading.Thread.Sleep(1);
                    wait = 0;
                }
                else wait++;
            } 

#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}
