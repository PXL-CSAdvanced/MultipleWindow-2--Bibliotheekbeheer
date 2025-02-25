namespace BibliotheekApp
{
    public class Book
    {
		private string _isbn;
        private string _title;
        private string _author;
        private Member _member;
		private bool _isAvailable = true;

        public string ISBN
		{
			get { return _isbn; }
			set { _isbn = value; }
		}

        public string Title
		{
			get { return _title; }
			set { _title = value; }
		}

		public string Author
		{
			get { return _author; }
			set { _author = value; }
		}

		public Member Member
		{
			get { return _member; }
			set { _member = value; }
		}

		public bool IsAvailable
		{
			get { return _isAvailable; }
			set { _isAvailable = value; }
		}

		public override string ToString()
		{
			if (this.IsAvailable)
			{
				return $"{_isbn} - {_title} ({_author}) - Beschikbaar";
			} else
			{
                return $"{_isbn} - {_title} ({_author}) - Uitgeleend aan {Member.ToString()}";
            }
        }



    }
}
