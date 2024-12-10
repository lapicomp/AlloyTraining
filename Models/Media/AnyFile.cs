using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(DisplayName = "Any File",
        GUID = "24025314-9f1b-4d9d-b94f-a3d249d43be4",
        Description = "Use this to upload any type of file.")]

    public class AnyFile : MediaData
    {
    }
}
