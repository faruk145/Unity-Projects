using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

namespace MirrorBasics {
    public class AutoHostClient : MonoBehaviour
    {
        [SerializeField] NetworkManager networkManager;

        void Start()
        {
            if (!Application.isBatchMode)  //Headless build yani server kendini başlatacak
            {
                Debug.Log($"=== Client Build ===");
                networkManager.StartClient();
            }
            else
            {
                Debug.Log($"=== Server Build ===");
            }
        }

        public void JoinLocal()
        {
            networkManager.networkAddress = "3.64.15.31";
            networkManager.StartClient();
        }
    }
}
