using Microsoft.AspNetCore.Components;

namespace Site.Models
{
    public class CardEntry { 

        public string? FrontTitle {get; set;} = null;
        public MarkupString? FrontBody {get; set;} = null;
        public string? FrontImage {get; set;} = null;
        public string? FrontImageDescription {get; set;} = null;

        public string? BackTitle {get; set;} = null;
        public MarkupString? BackBody {get; set;} = null;
        public string? BackImage {get; set;} = null;
        public string? BackImageDescription {get; set;} = null;
    }

}