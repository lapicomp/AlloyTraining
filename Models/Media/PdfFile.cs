using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(DisplayName = "Portable Document Format",
        Description = "Use this to upload Portable Document Format (PDF) files.")]
    [MediaDescriptor(ExtensionString = "pdf")]

    public class PdfFile : MediaData 
    {
        [Display(Name = "Render preview image")]
        public virtual bool RenderPreviewImage { get; set; }

        [Display(Name = "Thumbnail image")]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ThumbnailImage { get; set; }
    }
}
