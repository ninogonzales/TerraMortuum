using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class NameManager : MonoBehaviour {
	public static string username;

	void Start ()
	{
		var input = gameObject.GetComponent<InputField>();
		var se= new InputField.SubmitEvent();
		input.characterLimit = 6;
		se.AddListener(SubmitName);
		input.onEndEdit = se;

		//or simply use the line below, 
		//input.onEndEdit.AddListener(SubmitName);  // This also works
	}

	private void SubmitName(string arg0)
	{
		username = arg0;
	}
}