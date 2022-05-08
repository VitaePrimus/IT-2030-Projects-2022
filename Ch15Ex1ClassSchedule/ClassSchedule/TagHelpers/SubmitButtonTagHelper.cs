using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassSchedule.TagHelpers
{
    [HtmlTargetElement(Attributes = "[type=submit]")]
    public class SubmitButtonTagHelper : TagHelper{
        public override void Process(TagHelperContext context, TagHelperOutput output){
            output.Attributes.AppendCssClass("btn btn-dark");
        }
    }
}
