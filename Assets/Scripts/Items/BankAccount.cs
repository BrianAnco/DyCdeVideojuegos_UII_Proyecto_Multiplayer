using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BankAccount : MonoBehaviour
{
    public float bank;
	public Text bankText;

	public static BankAccount instance;

	private void Start()
	{
		bankText.text = "x " + bank.ToString();    
	}

	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
	}

	public void Money(float cashCollected)
	{
		bank += cashCollected;
		bankText.text = "x " + bank.ToString();
	}
}
