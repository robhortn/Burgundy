// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
SayHey();

static void SayHey() {
  Console.WriteLine("Saying Hey ...");
}

static void MergeHtmlAndCss(string htmlFilePath, string cssFilePath, string outputFilePath)
{
  // Read the contents of the HTML file
  string html = File.ReadAllText(htmlFilePath);

  // Read the contents of the CSS file
  string css = File.ReadAllText(cssFilePath);

  // Find the closing head tag in the HTML
  int headIndex = html.IndexOf("</head>", StringComparison.OrdinalIgnoreCase);

  // Insert the CSS code before the closing head tag
  html = html.Insert(headIndex, $"<style>{css}</style>");

  // Write the modified HTML to a new file
  File.WriteAllText(outputFilePath, html);
}
