using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System;

public class Dropdown : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	public RectTransform container;
	public bool isOpen;

	private float h = 0.0f;
	private float V = 0.0f;

	void Start()
	{
		container = this.transform.FindChild("Container").GetComponent<RectTransform>();
		isOpen = false;
	}

	void Update()
	{
		Vector3 scale = container.localScale;
		scale.y = Mathf.Lerp(scale.y, isOpen ? 1 : 0, Time.deltaTime * 12);
		container.localScale = scale;
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		h = Input.GetAxis("Horizontal");
		Debug.Log("H = " + h.ToString());
		isOpen = true;

	}

	public void OnPointerExit(PointerEventData eventData)
	{
		isOpen = false;
	}
}
