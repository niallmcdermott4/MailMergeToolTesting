namespace UnitTests
{
    using MailMergeTool;
    using NSubstitute;
    using Xunit;

    public class When_I_call_document_printer
    {
        IDocumentFormatter documentFormatter;
        IPrinter printer;
        DocumentPrinter documentPrinter;

        public When_I_call_document_printer()
        {
            documentFormatter = Substitute.For<IDocumentFormatter>();
            printer = Substitute.For<IPrinter>();
            documentPrinter = new DocumentPrinter(documentFormatter, printer);
        }

        [Fact]
        public void It_should_call_DocumentToString()
        {

        }
    }
}
