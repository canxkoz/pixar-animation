using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aniSpeedViewer : MonoBehaviour
{
	public Animator lampAnimator;
	Color textColor;
	private void Start()
	{
		textColor = Color.white;
	}
	void OnGUI()
	{
		int w = Screen.width, h = Screen.height;

		GUIStyle style = new GUIStyle();

		Rect rect = new Rect(10, 10, w, h * 2 / 100);
		style.alignment = TextAnchor.UpperLeft;
		style.fontSize = 16;
		style.normal.textColor = textColor;
		string text = string.Format("Animation Speed: "+lampAnimator.speed.ToString("F2"));
		GUI.Label(rect, text, style);
	}
}
