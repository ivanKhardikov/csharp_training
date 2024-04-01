namespace WebAddressbookTests
{
    public class GroupData
    {
        public string Groupname { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }

        public GroupData(string groupname, string header, string footer)
        {
            Groupname = groupname;
            Header = header;
            Footer = footer;
        }

        
    }
}
