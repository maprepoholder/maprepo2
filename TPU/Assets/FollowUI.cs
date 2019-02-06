using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FollowUI : MonoBehaviour
{
    public Camera cam;
    public TextMeshProUGUI textMesh;
    public Transform positionText;


    [HideInInspector]
    public Transform thisTransforn;

    public int currentCount;
    Vector3 positionDisable = new Vector3(2000,2000,-2000);

    private string _text;
    public string Text
    {
        get { return _text; }
        set
        {
            if (textMesh) textMesh.text = value;
            _text = value;
            Debug.LogError(_text +" - " +gameObject.name);
            StartCoroutine(WaiteAnHide());
            positionText.SetAsLastSibling();
        }
        
    }

    private IEnumerator WaiteAnHide()
    {
        if(_text == "Hide") yield  break;

        yield return new WaitForSeconds(10);
        Close();
    }

    public void Close()
    {
        StopAllCoroutines();
        thisTransforn.position = positionDisable;
        Text = "Hide";

        var myItemCopy = ControlText.Instance.Listfollow[currentCount - 1];
        ControlText.Instance.Listfollow.Remove(ControlText.Instance.Listfollow[currentCount - 1]);
        ControlText.Instance.Listfollow.Insert(ControlText.Instance.Listfollow.Count, myItemCopy);
    }

    void Awake()
    {
        thisTransforn = transform;
        thisTransforn.position = positionDisable;
    }
	void LateUpdate ()
	{
	    if (positionText/* && thisTransforn.position != positionDisable*/)
	    {
	        Vector3 pos = cam.WorldToScreenPoint(this.transform.position);
	        positionText.position = pos;
	    }
	}
}
