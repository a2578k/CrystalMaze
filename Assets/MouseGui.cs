using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class MouseGui : MonoBehaviour,IPointerDownHandler,IDragHandler  {
	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
		//throw new System.NotImplementedException ();
		Debug.Log("OnDrag");
	}

	#endregion

	#region IPointerDownHandler implementation
	public void OnPointerDown (PointerEventData eventData)
	{
		//throw new System.NotImplementedException ();
		Debug.Log("OnPointerDown");
	}
	#endregion

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
