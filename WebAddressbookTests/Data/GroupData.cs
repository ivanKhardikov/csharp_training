namespace WebAddressbookTests
{
    public class GroupData
    {
        private string groupname;
        private string header;
        private string footer;

        public GroupData(string groupname, string header, string footer)
        {
            this.groupname = groupname;
        }

        public string Groupname { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
    }
}
