using UnityEngine;

public class GlobelData : MonoBehaviour {

	public static GlobelData Instance;

	public int Gold;
	public int Hp;
	public int Score;
	public int Curent_Bullet;

	private void Awake()
	{
		Instance = this;
	}
}
