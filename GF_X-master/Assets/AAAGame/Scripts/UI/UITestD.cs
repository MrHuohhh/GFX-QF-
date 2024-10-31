using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;
using UnityEngine.UI;
using UnityGameFramework.Runtime;
using Log = UnityGameFramework.Runtime.Log;

public partial class UITestD : UIFormBase
{
    protected override void OnOpen(object userData)
    {
        base.OnOpen(userData);
        var value = Params.Get<VarInt32>("Value");
        Log.Info($"UITestD{value} Open with ");
    }

    protected override void OnButtonClick(object sender, Button btSelf)
    {
        base.OnButtonClick(sender, btSelf);
        if (btSelf == varButton)
        {
            ActionKit.Sequence()
                .Callback(() =>  Log.Error(">>>>>>>>>>>>>>1"))
                .Callback(() =>  Log.Error(">>>>>>>>>>>>>>2"))
                .Delay(0.3f)
                .Callback(() => Log.Error(">>>>>>>>>>>>>>3"))
                .Start(this);
            Log.Error(">>>>>>>>>>>>>>Hello World");
            
            
            GF.DataModel.GetOrCreate<PlayerDataModel>().GAME_LEVEL = 5;
            var menuProcedure = GF.Procedure.CurrentProcedure as MenuProcedure;
            if (null != menuProcedure)
            {
                menuProcedure.ShowLevel();
            }
        }
    }
}