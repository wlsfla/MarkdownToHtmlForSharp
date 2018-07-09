using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Markdig;
using MarkdownToHtmlForSharp;

namespace MarkdownToHtmlForSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Example1("result1.html");
            Example2("result2.html");//둘이 별차이 없음

            Console.WriteLine("End");
            //Console.ReadLine();
        }

        private static void FileWriteAndExec(string path, string result)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(path))
            {
                sw.Write(result);
            }
            System.Diagnostics.Process.Start(path);
        }

        private static void Example2(string path)
        {
            // Configure the pipeline with all advanced extensions active
            var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
            var result = Markdown.ToHtml("This is a text with some *emphasis*", pipeline);
            FileWriteAndExec(path, result);
        }

        private static void Example1(string path)
        {
            var result = Markdown.ToHtml("# This is a text with some *emphasis*");
            FileWriteAndExec(path, result);
        }
    }
}
