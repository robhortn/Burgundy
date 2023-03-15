using CefSharp;
using CefSharp.OffScreen;

namespace ProofOfConcepts
{
  internal class ChangeEngine
  {
    public void MergeHtmlAndCss(string htmlFilePath, string cssFilePath, string outputFilePath)
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

    public void ConvertHtmlToPdf(string html, string outputFilePath)
    {
      // Initialize the Chromium-based browser engine
      CefSettings settings = new CefSettings();
      //settings.BrowserSubprocessPath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, Environment.Is64BitProcess ? "x64" : "x86", "CefSharp.BrowserSubprocess.exe");
      settings.BrowserSubprocessPath = "C:\\Users\\robho\\.nuget\\packages\\cefsharp.common.netcore\\111.2.20\\runtimes\\win-x64\\native\\CefSharp.BrowserSubprocess.exe";
      settings.LogSeverity = LogSeverity.Disable;
      settings.DisableGpuAcceleration();
      settings.WindowlessRenderingEnabled = true;
      Cef.Initialize(settings);

      // Create a new ChromiumWebBrowser instance
      using (var browser = new ChromiumWebBrowser())
      {
        // Wait for the browser to finish loading
        browser.LoadingStateChanged += (sender, args) =>
        {
          if (!args.IsLoading)
          {
            // Once the browser has finished loading, take a snapshot of the page and save it as a PDF file
            browser.PrintToPdfAsync(outputFilePath, new PdfPrintSettings()
            {
              Landscape = false,
              MarginType = CefSharp.CefPdfPrintMarginType.Default,
              PrintBackground = true,
              DisplayHeaderFooter = false,
              //PrintBackgroundColors = true,
              //PrintBackgroundImages = true,
              //PrintHeadersAndFooters = false
            }); ;
          }
        };

        // Navigate to the HTML content
        browser.LoadHtml(html);

        // Wait for the PDF to be generated
        while (!File.Exists(outputFilePath))
        {
          System.Threading.Thread.Sleep(10);
        }
      }

      // Shut down the Chromium-based browser engine
      Cef.Shutdown();
    }
  }
}
