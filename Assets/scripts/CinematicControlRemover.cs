using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Core;
using RPG.Control;


namespace RPG.Cinematics
{


    public class CinematicControlRemover : MonoBehaviour
    {

        GameObject player;
        void Start()
        {
            player = GameObject.FindWithTag("Player");
        }

        void DisableControl()
        {

            player.GetComponent<ActionScheduler>().CancelCurrentAction();
            player.GetComponent<PlayerController>().enabled = false;
        }

        void EnableControl()
        {
            player.GetComponent<PlayerController>().enabled = true;
        }



    }

}
