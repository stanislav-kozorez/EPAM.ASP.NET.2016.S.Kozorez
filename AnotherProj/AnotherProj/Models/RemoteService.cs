using System.Threading;
using System.Threading.Tasks;

namespace AnotherProj.Models
{
    public class RemoteService
    {
        async public Task<string> GetRemoteData()
        {
            Thread.Sleep(2000);
            return await new  Task<string>( () => "Hello from the other side of the world");
        }
    }
}