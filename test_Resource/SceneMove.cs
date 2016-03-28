using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneMove : MonoBehaviour {

	public void Click(){
		SceneManager.LoadScene ("_Scene/MiniGame");	
	}
}
