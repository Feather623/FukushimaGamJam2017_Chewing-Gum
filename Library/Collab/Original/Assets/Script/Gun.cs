using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Gun : MonoBehaviour
{
	public GunData Data;

	public Vector3 TestTarget;

	public void Shoot(Vector3 targetPosition)
	{
		float dictance = Vector3.Distance(transform.position, targetPosition);

		transform.DOMove(targetPosition, dictance / Data.Speed);
	}

	[ContextMenu("TEST")]
	private void TestMoveToTarget()
	{
		Shoot(TestTarget);
	}

	public void Clear()
	{

	}

	void Start(){
		TestMoveToTarget ();
	}

}
