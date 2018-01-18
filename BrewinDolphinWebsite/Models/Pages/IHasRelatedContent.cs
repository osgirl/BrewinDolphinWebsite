using EPiServer.Core;

namespace BrewinDolphinWebsite.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
