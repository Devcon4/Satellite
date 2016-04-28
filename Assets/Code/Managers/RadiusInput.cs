using UnityEngine;
using System.Collections;

public class RadiusInput : MonoBehaviour {

    public GameObject satellite;
    public bool IsHeld;
    public float editAmount;

	// Update is called once per frame
	void Update () {
	    var currentPos = satellite.transform.localPosition;
	    currentPos.x = Master.master.Scene1.Radius;
	    satellite.transform.localPosition = currentPos;

	    if (IsHeld) {
            Master.master.Scene1.Radius = Mathf.Clamp(Master.master.Scene1.Radius + editAmount, Master.master.Scene1.MinimusRadius, Master.master.Scene1.MaximumRadius);
        }
    }

    public void UpdateHeldStatus(bool isHeld) {
        IsHeld = isHeld;
    }

    public void UPdateEditAmount(float amount) {
        editAmount = amount;
    }
}
