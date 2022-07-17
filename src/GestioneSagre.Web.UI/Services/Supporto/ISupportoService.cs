using GestioneSagre.Models.InputModels.InvioEmail;

namespace GestioneSagre.Web.UI.Services.Supporto;

public interface ISupportoService
{
    Task InvioEmailSupporto(InputMailSender input);
}