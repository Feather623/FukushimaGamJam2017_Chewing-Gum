using UnityEngine;

public class GlobelData : MonoBehaviour {

	public static GlobelData Instance;

	public int Gold;
	public int Hp;
	public int Score;
	public int Max_Bullet= 10;

	private void Awake()
	{
		Instance = this;
	}
}
