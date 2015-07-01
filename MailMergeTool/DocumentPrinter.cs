namespace MailMergeTool
{
    using System;

    public class DocumentPrinter : IDocumentPrinter
    {
        public DocumentPrinter(IDocumentFormatter documentFormatter, IPrinter printer)
        {
        }

        public void Print(MergedDocument document)
        {
            // TODO turn document into string, using the formatter, and print
            throw new NotImplementedException();
        }
    }
}