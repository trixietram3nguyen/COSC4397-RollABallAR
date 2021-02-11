using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : DefaultTrackableEventHandler
{
    public Rigidbody player;

    protected override void OnTrackingLost()
    {
        player.useGravity = false;
    }

    protected override void OnTrackingFound()
    {
        player.useGravity = true;
    }
}
