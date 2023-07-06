using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class ObjectSelection : MonoBehaviour
    {
        Ray ray = new Ray();

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit))
                {
                    hit.collider.GetComponent<Item>().SetColor();
                }
            }
        }
    }
}