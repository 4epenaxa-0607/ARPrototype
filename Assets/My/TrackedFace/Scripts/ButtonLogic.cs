using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLogic : MonoBehaviour
{
    [SerializeField]
    private SelectingMask selectingMask;

    public void ClickAroww(int index)
    {
        selectingMask.IndexChange(index);
    }

    public void ClickMenu(float applicationTimeScale)
    {
        Time.timeScale = applicationTimeScale;
    }

    public void ExitApplication()
    {
        Application.Quit();
    }
}
