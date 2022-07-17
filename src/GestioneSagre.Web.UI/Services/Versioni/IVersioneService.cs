using GestioneSagre.Models.ViewModels.Versioni;

namespace GestioneSagre.Web.UI.Services.Versioni;

public interface IVersioneService
{
    Task<VersioneViewModel> GetVersione();
}