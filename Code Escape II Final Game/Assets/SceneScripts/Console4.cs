﻿using UnityEngine.SceneManagement;
using UnityEngine;

public class Console4 : MonoBehaviour
{
    public GameObject player;

    void Update()
    {



        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            player.transform.position = new Vector3(-9, 0, 5);
        }

    }

    public void GetInput(string guess)
    {
        Debug.Log("You entered:" + guess);

        if (guess == "The name given to a datatype" || guess == "2")
        {
            SceneManager.LoadScene("Level 5");
        }
        else
        {
            SceneManager.LoadScene("Level 4");
        }

    }
}
