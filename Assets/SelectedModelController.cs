using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedModelController : MonoBehaviour {

    public void changeChildren(string selectedName)
    {
        for (int i = 0; i < this.transform.childCount; i++)
        {
            var child = this.transform.GetChild(i).gameObject;
            if (child != null)
            {
                UnityEngine.Debug.Log(child.name);
                if (child.name == selectedName)
                {
                    UnityEngine.Debug.Log(child.name + " Should be activeted");
                    child.SetActive(true);
                }
                else
                {
                    child.SetActive(false);
                }
            }
        }
    }
}
