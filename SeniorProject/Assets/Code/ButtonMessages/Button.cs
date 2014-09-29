using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	// Use this for initialization

    public Sprite Enabled;
    public Sprite Clicked;
    public Sprite Hover;
    public string ClickSound;
    public ButtonClickMessage m_ClickMessage;
    public ButtonClickMessage m_ReleaseMessage;

    public bool Visible
    {
        get
        {
            return enabled;
        }
        set
        {
            enabled = value;
        }
    }

    public enum ButtonState
    {
        DePressed,
        Pressed,
        Disabled,
    }
    protected ButtonState m_State;



    public virtual void Start()
    {
        Enabled = gameObject.GetComponent<SpriteRenderer>().sprite;
        m_State = ButtonState.DePressed;
    }

    public virtual void OnMouseDown()
    {
        Debug.Log("Button Down");
        if (m_State != ButtonState.Disabled && enabled == true)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Clicked;

            if (m_State != ButtonState.Pressed)
            {

                m_State = ButtonState.Pressed;
                EventAggregatorManager.Publish(new PlaySoundMessage(ClickSound, false));
                if (m_ClickMessage != null)
                    EventAggregatorManager.Publish(m_ClickMessage);

            }
        }
    }

    public virtual void OnMouseUp()
    {
        Debug.Log("Button Up");
        if (m_State != ButtonState.Disabled && enabled == true)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Enabled;
            if (m_State != ButtonState.DePressed)
            {

                m_State = ButtonState.DePressed;
                if (m_ReleaseMessage != null)
                    EventAggregatorManager.Publish(m_ReleaseMessage);

            }
        }
    }

    public virtual void OnMouseOver()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = Hover;
    }

    public virtual void OnMouseExit()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = Enabled;
    }

    public void ChangeState(ButtonState buttonState)
    {
        m_State = buttonState;

        if (m_State == ButtonState.Disabled)
            gameObject.GetComponent<SpriteRenderer>().sprite = Enabled;
        else
            gameObject.GetComponent<SpriteRenderer>().sprite = Enabled;
    }

    // Update is called once per frame
    public virtual void Update()
    {

    }
}
