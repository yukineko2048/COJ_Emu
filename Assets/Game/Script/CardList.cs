﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * これつかってなくね？
 */

public class CardList : MonoBehaviour
{
	public List<Card> cardList = new List<Card>();

	public void Add(Card _card)
	{
		//GameObject deck = this.transform.Find("Content_Deck").gameObject;
		_card.transform.SetParent(transform, false);
		cardList.Add(_card);
	}

	public Card Pull(int _position)
	{
		Card card = cardList[_position];
		cardList.Remove(card);
		return card;
	}
}
