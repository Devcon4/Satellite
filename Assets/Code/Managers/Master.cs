using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour {

    public static Master master;
    public Scene1 Scene1;

    void Awake() {
        if (master == null) {
            DontDestroyOnLoad(gameObject);
            master = this;
            Scene1 = GetComponent<Scene1>().GetThis();

        } else if (master != this) {
            Destroy(gameObject);
        }
    }
}
