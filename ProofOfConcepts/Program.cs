// See https://aka.ms/new-console-template for more information
using System.Runtime.ConstrainedExecution;
using ProofOfConcepts;

var htmlFile = "D:\\src\\Burgundy\\ProofOfConcepts\\index.html";
var cssFileName = "215";
var cssFile = $"D:\\src\\Burgundy\\ProofOfConcepts\\templates\\{cssFileName}.css";

var timeStamp = DateTime.Now.ToString("yyyyMMddHHmmss");
var outputFileHTML = $"D:\\src\\Burgundy\\ProofOfConcepts\\templates\\outputfile_{cssFileName}_{timeStamp}.html";

var changeEngine = new ChangeEngine();
changeEngine.MergeHtmlAndCss(htmlFile, cssFile, outputFileHTML);

// Output the PDF version
var outputFilePDF = $"D:\\src\\Burgundy\\ProofOfConcepts\\templates\\outputfile_{cssFileName}_{timeStamp}.pdf";
changeEngine.ConvertHtmlToPdf(outputFileHTML, outputFilePDF);

