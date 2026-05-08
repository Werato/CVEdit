using SelectPdf;

var htmlPath = Path.GetFullPath("../../../CV.html");
var html = File.ReadAllText(htmlPath);

var dir = Path.GetDirectoryName(htmlPath)!;
var baseUrl = new Uri(dir + Path.DirectorySeparatorChar).AbsoluteUri;

var converter = new HtmlToPdf();

converter.Options.PdfPageSize = PdfPageSize.A4;
converter.Options.PdfPageOrientation = PdfPageOrientation.Portrait;

converter.Options.MarginTop = 0;
converter.Options.MarginBottom = 0;
converter.Options.MarginLeft = 0;
converter.Options.MarginRight = 0;

converter.Options.WebPageFixedSize = true;
converter.Options.WebPageWidth = 794;
converter.Options.WebPageHeight = 1118; 

converter.Options.AutoFitHeight = HtmlToPdfPageFitMode.NoAdjustment;
converter.Options.AutoFitWidth = HtmlToPdfPageFitMode.NoAdjustment;

converter.Options.DenyLocalFileAccess = false;

var doc = converter.ConvertHtmlString(html, baseUrl);
doc.Save("../../../CV.pdf");
doc.Close();
