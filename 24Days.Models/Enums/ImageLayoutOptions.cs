using Umbraco.Community.Contentment.DataEditors;

namespace _24Days.Models.Enums
{
    public enum ImageLayoutOptions
    {
        [DataListItem(Name = "Left", Value = "left", Icon = "icon-navigation-left")]
        Left = 0,

        [DataListItem(Name = "Right", Value = "right", Icon = "icon-navigation-right")]
        Right = 1,
    }
}
