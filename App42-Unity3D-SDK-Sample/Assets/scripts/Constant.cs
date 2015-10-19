using System;
using UnityEngine;
namespace AssemblyCSharp
{
	public class Constant 
	{
		public string apiKey  ="API_KEY";						// API key that you have receieved after the success of app creation from AppHQ
		public string secretKey ="SECRET_KEY";					// SECRET key that you have receieved after the success of app creation from AppHQ
		public string userName  = "TestUser"+DateTime.Now.Millisecond; 	// Name of the user for which you have to save score or create user etc. 
		public string sessionId  = "Session Id of the User";   		// Session id of the user for which you have to have invalidate his session 
		public string emailId  = "TestUser"+DateTime.Now.Millisecond+"@mail.com";    // EmailId for the user creation
		public string updateEmailId   ="Id that has to be upadated";  // EmailId which has to be updated in user profile.
	}  
}
