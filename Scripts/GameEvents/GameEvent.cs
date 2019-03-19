using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Holds the events in the movement of the player
/// </summary>
[CreateAssetMenu (menuName = "UnityInventory/GameEvent")]
public class GameEvent : ScriptableObject {
    
    private List<GameEventListener> listeners = new List<GameEventListener>();

    /// <summary>
    /// Called when the event is risen
    /// </summary>
    public void Raise(object arg = null)
    {
        foreach (GameEventListener listener in listeners)
            listener.OnEventRaised(arg);
    }

    public void RegisterListener(GameEventListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(GameEventListener listener)
    {
        listeners.Remove(listener);
    }
}
