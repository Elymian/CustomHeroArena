using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouseClickMovement : MonoBehaviour
{

    public MonoBehaviour ScriptToBeEnabled;
    private void Update()
    {
        //A* project grid must start at  0.5;0.0;0.0
        Vector3 tmp;
        tmp.x = Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).x);
        tmp.y = Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        tmp.z = this.transform.position.z;
        //tmp.z = Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).z);
        this.transform.position = tmp;

        if (Input.GetMouseButtonUp(1))
        {
            ScriptToBeEnabled.enabled = true;
            this.enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SpriteRenderer sprite = this.GetComponent<SpriteRenderer>();
        sprite.color = Color.red;
    }
}
