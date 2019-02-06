using System.Collections.Generic;
using UnityEngine;

public class ControlText : Singleton<ControlText> {

    public List<FollowUI> Listfollow;

    public int currentCount;
    public void AssigneObject(ObjectSetup obj,Vector3 position)
    {
        if (Listfollow.Find(ui => ui.Text == obj._scenObjectType.NameLayer))
        {
            Debug.LogError("EXIST");
            return;
        }

        currentCount = currentCount > Listfollow.Count-1 ? 1 : currentCount + 1;

        Listfollow[currentCount - 1].currentCount = currentCount;
        Listfollow[currentCount-1].Text = obj._scenObjectType.NameLayer;
        Listfollow[currentCount-1].thisTransforn.position = position;
    }
}
