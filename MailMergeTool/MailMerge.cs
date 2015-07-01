namespace MailMergeTool
{
    using System;

    public class MailMerge
    {
        public MailMerge(IPersonRepository repository, IDocumentPrinter documentPrinter)
        {
        }

        public void MergeAndPrint(Document document)
        {
            // TODO enumerate repository.Persons and send to printer
            throw new NotImplementedException();
        }
    }
}