using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFactory : MonoBehaviour
{
	[SerializeField]
	private Character _clone;

	private static CharacterFactory _instance;

	public static CharacterFactory Instance
	{
		get
		{
			return _instance;
		}
	}

	public Character NewChar(int Id)
	{
		return NewChar(Id, Vector3.zero);
	}

	public Character NewChar(int Id, Vector3 position)
	{
		//TODO Find Character Form ID
		Character clone = Instantiate(_clone, position, transform.rotation);
		return clone;
	}

	private void Awake()
	{
		_instance = this;
	}
}
