using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour {

	public Gun gun;
	public GameObject Bullet;
	public Camera camera;
	public Vector3 TargetPos;

	void Start()
	{
		Input.multiTouchEnabled = true;
	}

	// Update is called once per frame
	bool deteTouch(Vector3 pos)
	{

		return true;
	}

	void Update()
	{
		
		foreach (Touch touch in Input.touches)
		{
			if (touch.phase == TouchPhase.Began)
			{
				if (deteTouch(touch.position))
				{

					GameObject newBullet =  Instantiate (Bullet, new Vector3(-14.9f, -1f, 0f), Bullet.transform.rotation);
					newBullet.GetComponent<Gun> ().TestTarget = camera.ScreenToWorldPoint(touch.position);
					Debug.Log (newBullet.GetComponent<Gun> ().TestTarget);
				}
			}
		}

	}
}
