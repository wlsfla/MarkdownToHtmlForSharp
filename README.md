# MarkdownToHtmlForSharp
[Go Markdig Nuget](https://github.com/lunet-io/markdig)
```c#
using Markdig.Markdown;
var result = Markdown.ToHtml("This is a text with some *emphasis*");
Console.WriteLine(result);   // prints: <p>This is a text with some <em>emphasis</em></p>
```
