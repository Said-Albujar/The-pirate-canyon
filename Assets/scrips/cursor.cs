using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{
    public class cursor : MonoBehaviour
    {
        private bool iscursorbloqueado;

       
        void Start()
        {
            ToggleCursorState();
        }

         
        void Update()
        {
            CheckForInput();
            Checkofcursorshouldbelocked();
        }
        void ToggleCursorState()
        {
            iscursorbloqueado = !iscursorbloqueado;
        }
        void CheckForInput()
        {
           if (Input.GetKeyDown(KeyCode.Escape))
          {
               ToggleCursorState();
           }
        }
        void Checkofcursorshouldbelocked()
        {
           if(iscursorbloqueado)
           {
           //  Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
            else
            {
             //   Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = true;
          }
        }
    }
}

