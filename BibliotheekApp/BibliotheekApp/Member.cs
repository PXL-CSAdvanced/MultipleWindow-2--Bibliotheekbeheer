namespace BibliotheekApp
{
    public class Member
    {
		private string _memberId;
        private string _name;

		public Member (string memberId, string name)
		{
			MemberId = memberId;
			Name = name;
		}
        public string MemberId
		{
			get { return _memberId; }
			set { _memberId = value; }
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

        public override string ToString()
        {
			return Name.ToString();
        }
    }
}