using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{

	public Gun gun;
	public GameObject Bullet;
	public Camera camera;
	public Vector3 TargetPos;

	public Vector3 ShootBullPos = new Vector3(-14.9f, -1f, 0f);

	public bool isOnPhone;

	private List<Gun> onFlyGun = new List<Gun>();

	void Start()
	{
		Input.multiTouchEnabled = true;

		EventSystem.OnGunTouchMonster += OnTouch;
	}

	private void OnTouch(Gun g, Monster m)
	{
		onFlyGun.Remove(g);
		Destroy(g.gameObject);
		Destroy(m.gameObject);

		GlobelData.Instance.Gold += 1;
	}



	// Update is called once per frame
	bool deteTouch(Vector3 pos)
	{

		return true;
	}


	void Update()
	{
		//		if (onFlyGun.Count > GlobelData.Instance.Max_Bullet)
		//			return;

		if (isOnPhone)
		{
			foreach (Touch touch in Input.touches)
			{
				if (touch.phase == TouchPhase.Began)
				{
					if (deteTouch(touch.position))
					{

						Gun g = GunFactory.Instance.New(0);
						g.transform.position = gameObject.transform.position;
						g.gameObject.AddComponent<Stayfloor>();

						Vector3 newPos = new Vector3(touch.position.x, touch.position.y, g.transform.position.z);

						g.Shoot(camera.ScreenToWorldPoint(touch.position));

						onFlyGun.Add(g);
					}
				}
			}
		}
		else
		{
			if (Input.GetMouseButtonDown(0))
			{
				Gun g = GunFactory.Instance.New(0);
				g.transform.position = gameObject.transform.position;
				g.gameObject.AddComponent<Stayfloor>();

				var worldPos = camera.ScreenToWorldPoint(Input.mousePosition);

				Vector3 newPos = new Vector3(worldPos.x, worldPos.y, transform.position.z);

				g.Shoot(newPos);
				onFlyGun.Add(g);

			}
		}
	}

}
