namespace Inhu.Authentication {
	public class UserSession {
		public string Name { get; set; }

		public string Role { get; set; }

		public string Email { get; set; } = string.Empty;

		public string Uid { get; set; }
	}
}
