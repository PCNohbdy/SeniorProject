using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ButtonClickMessage
{

}

public class LoadLevelButtonMessage : ButtonClickMessage
{
    public string LevelToLoad;
}

public class ExitButtonClickMessage : ButtonClickMessage
{

}

