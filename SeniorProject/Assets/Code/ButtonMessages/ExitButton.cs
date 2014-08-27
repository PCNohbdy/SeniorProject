using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ExitButton : Button
{
    public override void Start()
    {
        base.Start();
        m_ReleaseMessage = new ExitButtonClickMessage();

        GameEventAggregator.GameMessenger.Subscribe(this);
    }

    public override void OnMouseDown()
    {
        base.OnMouseDown();
    }

    public override void OnMouseUp()
    {
        base.OnMouseUp();
    }

    // Update is called once per frame
    public override void Update()
    {

    }
}

