using System;
namespace simpleapp.AddClass
{
    public class CustomClass:ApplicationException
    {
        private string messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }
        public CustomClass(string message,string cause,DateTime time)
        {
            messageDetails = message;
            ErrorTimeStamp = time;
            CauseOfError = cause;
        }

        public override string Message
        {
            get 
            {
                return string.Format("car error message:{0}", messageDetails); 
            }
        }
	}
}
