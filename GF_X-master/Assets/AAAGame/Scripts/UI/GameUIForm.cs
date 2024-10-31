using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GameFramework;
using GameFramework.Event;
using UnityEngine.EventSystems;
using DG.Tweening;
using System;
using UnityGameFramework.Runtime;
using TMPro;
using UnityEngine.U2D;

public partial class GameUIForm : UIFormBase
{
    protected override void OnOpen(object userData)
    {
        base.OnOpen(userData);
        RefreshCoinsText();
        GF.Event.Subscribe(UserDataChangedEventArgs.EventId, OnUserDataChanged);
    }
    protected override void OnClose(bool isShutdown, object userData)
    {
        GF.Event.Unsubscribe(UserDataChangedEventArgs.EventId, OnUserDataChanged);
    }
    private void OnUserDataChanged(object sender, GameEventArgs e)
    {
        var args = e as UserDataChangedEventArgs;
        switch (args.Type)
        {
            case UserDataType.SCORE:
                RefreshCoinsText();
                break;
            case UserDataType.GAME_LEVEL:

                break;
        }
    }
    private void RefreshCoinsText()
    {
        var playerDm = GF.DataModel.GetOrCreate<PlayerDataModel>();
        coinNumText.text = playerDm.SCORE.ToString();
    }
}
