using UnityEngine;
using UnityEngine.SocialPlatforms;
using System.Collections;
using System.Collections.Generic;
using System;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.user;
using AssemblyCSharp;

public class UserTest : MonoBehaviour
{
	Constant cons = new Constant ();
	UserService userService = null; // Initializing User Service.
	User createUserObj = null;
	public string password = "password";
	public int max = 2;
	public int offSet = 1;
	public string success, box;
	UserResponse callBack = new UserResponse ();

	void Start ()
	{
		App42API.Initialize(cons.apiKey,cons.secretKey);
		userService = App42API.BuildUserService (); // Initializing UserService.
	}
	

	void OnGUI ()
	{
		
		if (Time.time % 2 < 1) {
			success = callBack.getResult ();
		}
		
		// For Setting Up ResponseBox.
		GUI.TextArea (new Rect (10, 5, 1300, 175), success);
		 
		//=========================================================================	
		if (GUI.Button (new Rect (50, 200, 200, 30), "Create User")) {
			userService.CreateUser (cons.userName, password, cons.emailId, callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (260, 200, 200, 30), "Get User")) {
			userService.GetUser (cons.userName, callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (470, 200, 200, 30), "Get All Users")) {
			userService.GetAllUsers (callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (680, 200, 200, 30), "Update Email")) {
			userService.UpdateEmail (cons.userName, cons.emailId, callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (890, 200, 200, 30), "Delete User")) {
			userService.DeleteUser (cons.userName, callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (50, 250, 200, 30), "Authenticate User")) {
			userService.Authenticate (cons.userName, password, callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (260, 250, 200, 30), "Change UserPassword")) {
			userService.ChangeUserPassword (cons.userName, password, "newPassWord", callBack);
		}
		
		//============================================================================	
		if (GUI.Button (new Rect (470, 250, 200, 30), "Lock User")) {
			userService.LockUser (cons.userName, callBack);
		}
		
		//============================================================================	
		if (GUI.Button (new Rect (680, 250, 200, 30), "Unlock User")) {
			userService.UnlockUser (cons.userName, callBack);
		}
		
		//============================================================================	
		if (GUI.Button (new Rect (890, 250, 200, 30), "Get LockedUsers")) {
			userService.GetLockedUsers (callBack);
		}
		
		//============================================================================	
		if (GUI.Button (new Rect (50, 300, 200, 30), "GetAllUsersByPaging")) {
			userService.GetAllUsers (max, offSet, callBack);
		}
		
		//============================================================================	
		if (GUI.Button (new Rect (260, 300, 200, 30), "GetAllUsersCount")) {
			userService.GetAllUsersCount (callBack);
		}

		//============================================================================	
		if (GUI.Button (new Rect (470, 300, 200, 30), "AssignRoles")) {
			IList<string> roleList = new List<string> ();
			roleList.Add ("Designer");
			roleList.Add ("Architect");
			userService.AssignRoles (cons.userName, roleList, callBack);
		}
		//============================================================================	
		if (GUI.Button (new Rect (680, 300, 200, 30), "ResetUserPassword")) {
			userService.ResetUserPassword (cons.userName, callBack);
		}
		
		//============================================================================	
		if (GUI.Button (new Rect (890, 300, 200, 30), "Log out")) {
			userService.Logout (cons.sessionId, callBack);
		}
		
		//============================================================================	
		if (GUI.Button (new Rect (50, 350, 200, 30), "GetLockedUsersCount")) {
			userService.GetLockedUsersCount (callBack);
		}
		
		//============================================================================	
		if (GUI.Button (new Rect (260, 350, 200, 30), "GetUserByEmailId")) {
			userService.GetUserByEmailId (cons.updateEmailId, callBack);
		}
		
		//============================================================================	
		if (GUI.Button (new Rect (470, 350, 200, 30), "GetLockedUsersByPaging")) {
			userService.GetLockedUsers (max, offSet, callBack);
		}
		
		//============================================================================	
		if (GUI.Button (new Rect (680, 350, 200, 30), "CreateOrUpdateProfile")) {
			User.Profile profileObj = new User.Profile (createUserObj);
			profileObj.SetCountry ("India");
			profileObj.SetCity ("GGN");
			profileObj.SetFirstName ("Akshay");
			profileObj.SetLastName ("Mishra");
			profileObj.SetHomeLandLine ("1234567890");
			profileObj.SetMobile ("12345678900987654321");
			profileObj.SetOfficeLandLine ("0987654321");
			profileObj.SetSex (UserGender.MALE);
			profileObj.SetState ("UP");
			userService.CreateOrUpdateProfile (createUserObj, callBack);
		}
		
		//============================================================================	
		if (GUI.Button (new Rect (890, 350, 200, 30), "CreateUserWithRole")) {
			IList<string> roleList = new List<string> ();
			roleList.Add ("Admin");
			roleList.Add ("Manager");
			roleList.Add ("Programmer");
			roleList.Add ("Tester");
			userService.CreateUser (cons.userName, password, cons.emailId, roleList, callBack);
		}
		
	}
}