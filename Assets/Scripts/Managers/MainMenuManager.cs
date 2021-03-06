using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public void PlayButtonPressed()
    {
        GameManager.Instance.SwitchState(GameManager.Instance.LoreState);
    }

    public void QuitButtonPressed()
    {
        GameManager.Instance.SwitchState(GameManager.Instance.QuitState);
    }
}
