namespace TCP_Client
{
    public class UnreadMessage
    {
        private string message;
        private string date;
        public UnreadMessage(string message, string date)
        {
            this.message = message;
            this.date = date;
        }

        public string getMessage() { return message; }
        public string getDate() { return date; }
    }
}
