using UnityEngine;
using System.Collections;

public class ValidatedThing : MonoBehaviour
{
	public int refVal;
	int i = 0;

	void OnValidate ()
	{
		i = refVal;
	}

	void OnGUI ()
	{
		GUI.Label (new Rect (10, 10, 100, 200), string.Format ("refVal is {0}; i is {1}", refVal, i));
	}
}
