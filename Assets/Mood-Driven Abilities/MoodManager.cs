using UnityEngine;

public class MoodManager : MonoBehaviour
{
	public enum Mood
	{
		Default = 0,
		Happy = 1,
		Sad = 2,
		Angry = 3
	}

	public Mood mood;
	Animator animator;

	void Awake ()
	{
		animator = GetComponent<Animator> ();
	}
	
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			mood = Mood.Happy;
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			mood = Mood.Sad;
		} else if (Input.GetKeyDown (KeyCode.Alpha3)) {
			mood = Mood.Angry;
		} else if (Input.GetKeyDown (KeyCode.Alpha0)) {
			mood = Mood.Default;
		}

		animator.SetInteger ("mood", (int)mood);
	}
}
