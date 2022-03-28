using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ASPCore.Pages
{
    [HtmlTargetElement("SyncButton")]
    public class SyncButton : Syncfusion.EJ2.Buttons.Button
    {
        public string className = "e-control e-btn";

        public ButtonStyles Styles { get; set; }

        public enum ButtonStyles
        {
            Basic,
            Success,
            Info,
            Warning,
            Danger
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Content.SetContent(Content);
            if(Disabled)
            {
                output.Attributes.SetAttribute("disabled", Disabled);
            }
            if (IsPrimary)
            {
                className += " e-primary";
            }
            else if (Styles == ButtonStyles.Success)
            {
                className += " e-success";
            }
            else if (Styles == ButtonStyles.Info)
            {
                className += " e-info";
            }
            else if (Styles == ButtonStyles.Warning)
            {
                className += " e-warning";
            }
            else
            {
                className += " e-danger";
            }
            output.Attributes.SetAttribute("Class", className);
        }
    }
}
