using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateSkill1Data : MonoBehaviour {

	public int LevelUpNeedMoney;

	public Text NeedMoneyText;

	// Use this for initialization
	void Start () {
		CountLevelUpNeedMoney ();
		NeedMoneyText.text = LevelUpNeedMoney.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LevelUp()
	{
		if (GlobelData.Instance.Gold < LevelUpNeedMoney) 
			return;

		GlobelData.Instance.Gold -= LevelUpNeedMoney;
		GlobelData.Instance.Skill1Level++;
		CountLevelUpNeedMoney ();
		NeedMoneyText.text = LevelUpNeedMoney.ToString();


	}

	private void CountLevelUpNeedMoney()
	{
		LevelUpNeedMoney = (int)(50 * Mathf.Pow (1.05f, (float)GlobelData.Instance.Skill1Level) + GlobelData.Instance.Skill1Level * 5 + 1);
	}
}
