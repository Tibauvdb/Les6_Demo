using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


//public interface IListener
//{
//    void ClickedAt(Vector3 Position);
//}
[System.Serializable]
public class LocationClickEvent: UnityEvent<Vector3>
{

}
public class ClickLocationEventBehaviour : MonoBehaviour {

    [SerializeField]
    private LocationClickEvent _clickEvent;
   // [SerializeField]
   // private List<IListener> _listeners = new List<IListener>();
   //
   // public void AddListener(IListener listener)
   // {
   //     _listeners.Add(listener);
   // }
	

	void Update () {
        if (Input.GetMouseButtonDown(0))
        {

            Vector3 mousePosition = Input.mousePosition;
            Ray worldRay = Camera.main.ScreenPointToRay(mousePosition);

            RaycastHit hitinfo;
            if (Physics.Raycast(worldRay, out hitinfo))
            {
                _clickEvent.Invoke(hitinfo.point);

               // foreach(IListener listener in _listeners)
               // {
               //     listener.ClickedAt(hitinfo.point);
               // }

            }
        }
    }
}
