using System;
using System.Threading.Tasks;

namespace Suddn.Data
{
    public interface ILoginService
    {
        Task LoginUserAsync(string userName, string passWord);
    }
}
