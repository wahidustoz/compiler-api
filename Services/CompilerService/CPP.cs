using System.Diagnostics;
using System.Threading.Tasks;
using compiler_api.Models;

namespace compiler_api.Services.CompilerService
{
    public class CPP
    {
        public static async Task<Result> Compile(string content)
        {
            var compiler = new Process();
            var startInfo = new ProcessStartInfo();
            
            startInfo.FileName = "g++";
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardOutput = true;

            
        }
    }
}