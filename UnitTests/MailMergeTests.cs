namespace UnitTests
{
    using MailMergeTool;
    using NSubstitute;
    using Properties;
    using Xunit;

    public class When_merge_a_document
    {
        MailMerge tool;
        IDocumentPrinter printer;
        IPersonRepository repository;

        public When_merge_a_document()
        {
            repository = Substitute.For<IPersonRepository>();
            printer = Substitute.For<IDocumentPrinter>();
            tool = new MailMerge(repository, printer);

            Document document = new Document {TokenizedDocument = Resources.TestDocument};
            tool.MergeAndPrint(document);
        }

        [Fact]
        public void It_should_use_the_persons_in_the_repository()
        {
            repository.Received().Persons();
        }
    }
}
