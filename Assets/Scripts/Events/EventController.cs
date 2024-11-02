using System;

public class EventController 
{
    public Action baseEvent;

    public void AddListner(Action listener) => baseEvent += listener;

    public void RemoveListner(Action listener) => baseEvent -= listener;

    public void InvokeEvent() => baseEvent?.Invoke();
    

}
