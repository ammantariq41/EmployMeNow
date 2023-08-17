using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

public class PrintDocumentClass
{
    private PrintDocument printDocument;

    public PrintDocumentClass()
    {
        printDocument = new PrintDocument();
        printDocument.PrintPage += PrintDocument_PrintPage;
    }

    public void Print()
    {
        PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        printPreviewDialog.Document = printDocument;
        printPreviewDialog.ShowDialog();
    }

    private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
    {
        // Add your printing logic here.
        // This event will be triggered when the PrintPreviewDialog is shown.
        // You can use the 'e.Graphics' object to draw content for printing.
        // For example:
        e.Graphics.DrawString("Hello, PrintPreviewDialog!", new Font("Arial", 12), Brushes.Black, 50, 50);
    }
}
