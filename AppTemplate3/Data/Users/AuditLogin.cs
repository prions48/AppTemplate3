using System.ComponentModel.DataAnnotations;

namespace AppTemplate3.Data.Users
{
    public class AuditLogin
	{
		[Key] public Guid ID { get; set; }
		public Guid UserID { get; set; }
		public DateTime TimeStamp { get; set; }
		public string AppName { get; set; }
		public AuditLogin()
		{
			ID = Guid.NewGuid();
			AppName = KeyChain.AppCode;
			TimeStamp = DateTime.Now;
		}
	}
}