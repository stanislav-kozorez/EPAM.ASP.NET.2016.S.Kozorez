using System.Threading;
using System.Threading.Tasks;

namespace AnotherProj.Models
{
    public class RemoteService
    {
        async public Task<string> GetRemoteData()
        {
            return await Task<string>.Factory.StartNew( () =>
            {
                Thread.Sleep(2000);
                return "Hello from the other side of the world";
            });
        }
    }
}