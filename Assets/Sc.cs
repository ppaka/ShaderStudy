using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Sc : MonoBehaviour
{
	public Material material;
	public Transform lightTf, objTf;
	private bool _isDay = true;

	private void Start()
	{
	}

	private void Update()
	{
		objTf.Rotate(new Vector3(0,10*Time.deltaTime,0));
	}

	public void DayOrNight()
	{
		if (!_isDay)
		{
			_isDay = true;
			material.DOKill();
			material.DOColor(new Color(1, 1, 1), 2);
			lightTf.DOKill();
			lightTf.DOLocalRotate(new Vector3(50, -30, 0), 2);
		}
		else
		{
			_isDay = false;
			material.DOKill();
			material.DOColor(new Color(0,0,0), 2);
			lightTf.DOKill();
			lightTf.DOLocalRotate(new Vector3(-10, -30, 0), 2);
		}
	}
}