using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockhand : MonoBehaviour
{
    [SerializeField]
    Transform hrP, mP, sP;
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

    void Awake(){
        System.DateTime time = System.DateTime.Now;
		hrP.localRotation =
			Quaternion.Euler(0f, 0f, hoursToDegrees * time.Hour);
		mP.localRotation =
			Quaternion.Euler(0f, 0f, minutesToDegrees * time.Minute);
		sP.localRotation =
			Quaternion.Euler(0f, 0f, secondsToDegrees * time.Second);
    }

    	void Update () {
		System.TimeSpan time = System.DateTime.Now.TimeOfDay;
		hrP.localRotation =
			Quaternion.Euler(0f, 0f, (float)(hoursToDegrees * time.TotalHours));
		mP.localRotation =
			Quaternion.Euler(0f, 0f, (float)(minutesToDegrees * time.TotalMinutes));
		sP.localRotation =
			Quaternion.Euler(0f, 0f, (float)(secondsToDegrees * time.TotalSeconds));
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

}
