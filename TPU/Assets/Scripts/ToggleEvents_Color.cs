using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections;
using TMPro;


public class ToggleEvents_Color : ToggleEvents
{
	public Type			_ColorType	= Type.ColorImage;
	public Color		_OnColorText	= Color.red;
	public Color		_OffColorText	= Color.white;
    [Space]
    public Color _OnColorImage = Color.red;
    public Color _OffColorImage = Color.white;
    [Space]
    public Sprite       _Sprite;
           Sprite       _SpriteBase;

    public enum Type
    {
        ColorImage,
        ColorText,
        ColorTextAndImage,
        ColorTextAndSpriteImage
    }


	public Image				m_image;
	public TextMeshProUGUI   	m_text;

	void Awake()
	{
		if(!m_image) m_image		= GetComponent<Image>();
		if(!m_text) m_text		= GetComponentInChildren<TextMeshProUGUI>();
	    if (m_image) _SpriteBase = m_image.sprite;
        Toggle t = GetComponent<Toggle>();
		if (t)
			UpdateColor(t.isOn);
	}

	protected override void OnToggleInt(bool isOn)
	{
		UpdateColor(isOn);
	}

	void UpdateColor(bool isOn)
	{
		Color colorText = isOn ? _OnColorText : _OffColorText;
        Color colorImage = isOn ? _OnColorImage : _OffColorImage;
        switch (_ColorType)
	    {
	        
            case Type.ColorText:
                if (m_text) m_text.color = colorText;
                break;

            case Type.ColorImage:
	            if (m_image) m_image.color = colorImage;
	            break;

            case Type.ColorTextAndImage:
                {
                    if (m_text) m_text.color = colorText;
                    if (m_image) m_image.color = colorImage;
                    break;
                }
	        case Type.ColorTextAndSpriteImage:
	        {
	            if (m_text) m_text.color = colorText;
	            if (m_image&&_Sprite) m_image.sprite = isOn ? _Sprite : _SpriteBase;
	            break;

	        }


	    }
	}

}
