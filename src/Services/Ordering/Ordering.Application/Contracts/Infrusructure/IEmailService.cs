
using Ordering.Application.Models;
using System.Threading.Tasks;

namespace Ordering.Application.Contracts.Infrusructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
