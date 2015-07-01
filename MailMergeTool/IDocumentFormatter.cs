namespace MailMergeTool
{
    public interface IDocumentFormatter
    {
        string DocumentToString(MergedDocument document);
    }
}