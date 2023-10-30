using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoveBlur
{
    public static class RespondeAi
    {
        async public static Task<string> RemoveBlur(string page, string CSSclass, string name)
        {
            try
            {
                page = page.Replace(CSSclass, "");
                string path = @$"D:\Codigos\C#\RemoveBlur\Files\{name}.html";
                await File.WriteAllTextAsync(path, page);
                
                return "File Creation Succesful!!";
            }
            catch
            {
                return "File Creation Failed, try again later!";
            }
        }
    }
}