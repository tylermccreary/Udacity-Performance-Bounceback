using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private float time = 0f;

	// Update is called once per frame
	void Update () {
        if (gameObject.activeInHierarchy)
        {
            time += Time.deltaTime;

            if (transform.position.y < 0.2f && time > 8.0f)
            {
                gameObject.SetActive(false);
                time = 0;
            }
        }
	}
}
