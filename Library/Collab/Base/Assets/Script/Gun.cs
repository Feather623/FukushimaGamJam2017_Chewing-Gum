using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

[Serializable]
public class GunData
{
	public int Id;
	public Gun Gun;
	public float Speed;
}

public class Gun : MonoBehaviour
{
	public GunData Data;

	public Vector3 TestTarget;

	public void Shoot(Vector3 targetPosition)
	{
		float dictance = Vector3.Distance(transform.position, targetPosition);

		transform.DOMove(targetPosition, dictance / Data.Speed).SetEase(Ease.OutQuint);
	}

	[ContextMenu("TEST")]
	private void TestMoveToTarget()
	{
		Shoot(TestTarget);
	}

	public void Clear()
	{

	}

	private void Awake()
	{
		Data.Gun = this;
	}
}
