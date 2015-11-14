using Microsoft.AspNet.Mvc.Rendering;
 using Microsoft.AspNet.Razor.Runtime.TagHelpers;
 using System;
 using System.Collections;
 using System.Reflection;
 
 namespace DemoApp
 {
   [TargetElement("cats")]
   public class CatstagHelper: TagHelper
   {

		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
		TagBuilder builder = new TagBuilder("img");
		builder.MergeAttribute("src", "http://www.edgecats.net");
		output.Content.Append(builder.ToHtmlString(TagRenderMode.Normal).ToString());
		}
   }
 
 }