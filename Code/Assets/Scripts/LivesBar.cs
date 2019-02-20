using UnityEngine;
using System.Collections;

public class LivesBar : MonoBehaviour
{
    private Transform[] heal = new Transform[7];

    private Character character;


    private void Awake()
    {
        character = FindObjectOfType<Character>();

        for (int i = 0; i < heal.Length; i++)
        {
            heal[i] = transform.GetChild(i);
            Debug.Log(heal[i]);
        }
    }

    public void Refresh()
    {
        for (int i = 0; i < heal.Length; i++)
        {
            if (i < character.Lives) heal[i].gameObject.SetActive(true);
            else heal[i].gameObject.SetActive(false);
        }
    }
}
