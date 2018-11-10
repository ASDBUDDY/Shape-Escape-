using UnityEngine.UI;
using UnityEngine;

public class resetlevel : MonoBehaviour {

    public levelmanager levelmanage;

    public void resetlevels()
    {
        levelmanage.resetlevel();
    }
}
