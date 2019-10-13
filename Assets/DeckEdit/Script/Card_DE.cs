﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card_DE : MonoBehaviour
{
	public int id;
	public new string name;
	public int section;
	public int cp;
	public int color;
	public int[] race = new int[2];
	public int[] bp = new int[3];
	public string effectText;
	public string flavorText;

	//DeckGeneraterの中でしか起こらないのでレベルに対応したBp変化はいらない
	public void Load(CardData_DE _cardData)
	{
		id = _cardData.id;
		name = _cardData.name;
		section = _cardData.section;
		cp = _cardData.cp;
		color = _cardData.color;
		race[0] = _cardData.race1;
		race[1] = _cardData.race2;
		bp[0] = _cardData.bp1;
		bp[1] = _cardData.bp2;
		bp[2] = _cardData.bp3;
		effectText = _cardData.effectText;
		flavorText = _cardData.flavorText;
	}
}