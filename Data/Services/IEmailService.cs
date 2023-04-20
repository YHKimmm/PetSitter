using PetSitter.Models;
using SendGrid;

namespace PetSitter.Data.Services
{
    public interface IEmailService
    {
        Task<Response> SendSingleEmail(ComposeEmailModel payload);
    }
}
