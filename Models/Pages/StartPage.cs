using System.ComponentModel.DataAnnotations;
using Castle.Components.DictionaryAdapter;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace AlloyTraining.Models.Pages;

[ContentType(DisplayName = "Start",
    GUID = "EDC4ED27-ED1E-470D-9629-ABD9B1C9F7E6",
    Description = "The home page for a website with an area for blocks and partial pages.”",
    GroupName = SiteGroupNames.Specialized, Order = 10)]
public class StartPage : PageData
{
    [CultureSpecific]
    [Display(Name = "Heading",
        Description = "If the Heading is not set, the page falls back to showing the Name.",
        GroupName = SystemTabNames.Content, Order = 10,
        Prompt = "Enter the heading for the page.")]
    public virtual string Heading { get; set; }

    [CultureSpecific]
    [Display(Name = "Main body",
        Description = "The main body uses the XHTML-editor so you can insert, for example text, images, and tables.",
        GroupName = SystemTabNames.Content, Order = 20)]
    public virtual XhtmlString MainBody { get; set; }

    [Display(Name = "Main content area",
        Description = "The main content area contains an ordered collection to content references, for example blocks, media assets, and pages.",
        GroupName = SystemTabNames.Content, Order = 30)]
    public virtual ContentArea MainContentArea { get; set; }
}

