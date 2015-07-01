namespace MailMergeTool
{
    public class Document
    {
        public string AdressToken { get; set; } = "<<Address>>";
        public string GreetingToken { get; set; } = "<<Greeting>>";
        public string TokenizedDocument { get; set; }
    }
}