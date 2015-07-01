namespace MailMergeTool
{
    using System.Collections.Generic;

    public interface IPersonRepository
    {
        IEnumerable<Person> Persons();
    }
}