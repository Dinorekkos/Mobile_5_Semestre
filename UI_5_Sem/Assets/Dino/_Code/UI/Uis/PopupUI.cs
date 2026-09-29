using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

public class PopupUI : UIWindow
{

    #region MyRegion

    [Button("Test Show")]
    private void TestShow()
    {
        Show();
    }
    
    [Button("Test Hide")]
    private void TestHide()
    {
        Hide();
    }


    #endregion
    
}
