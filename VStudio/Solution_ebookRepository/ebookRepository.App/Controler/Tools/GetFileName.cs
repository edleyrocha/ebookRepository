using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ebookRepository.App.Controler.Tools
{
    class GetFileName
    {
        public static string GetFileName_From_PatchFile(String File_Full_Patch)
        {
            File_Full_Patch = (Path.GetFileName(File_Full_Patch));
            return (File_Full_Patch);
        }
    }
}
