using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AngleTest : MonoBehaviour {

	public Transform target;
	public Text angleText;

	//case) using input vector
	//public Vector3 cu1;
	//public Vector3 cu2;

	//case) using object
	public GameObject cube1;
	public GameObject cube2;

	public static float GetAngle(Vector3 vStart, Vector3 vEnd){
		Vector3 v = vEnd - vStart;
		return Mathf.Atan2 (v.y, v.x) * Mathf.Rad2Deg;
	}
		

	// Update is called once per frame
	void Update () {
		//Vector3 relative = transform.InverseTransformPoint (target.position);
		//float angle = Mathf.Atan2 (relative.x, relative.z) * Mathf.Rad2Deg;

		angleText.text = "Angle: " + GetAngle (cube1.transform.InverseTransformPoint (target.position), cube2.transform.InverseTransformPoint (target.position)).ToString ();
	}
}