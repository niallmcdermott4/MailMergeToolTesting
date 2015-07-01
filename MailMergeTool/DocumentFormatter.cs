namespace MailMergeTool
{
    using System;

    public class DocumentFormatter : IDocumentFormatter
    {
        public DocumentFormatter(IAddressFormatter addressFormatter, IPersonFormatter personFormatter)
        {
        }

        public string DocumentToString(MergedDocument document)
        {
            // TODO read the document and replace any tokens using their respective formatter
            throw new NotImplementedException();
        }
    }
}