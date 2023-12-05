using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public List<PlayerMovement> PlayerAvatars = new List<PlayerMovement>();
    public PlayerMovement ActivePlayerAvatar = null;
    public int ActiveAvatarID = 0;
    // Start is called before the first frame update
    void Start()
    {
        ActivePlayerAvatar = PlayerAvatars[ActiveAvatarID];
        ActivePlayerAvatar.IsCurrentActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            ActivePlayerAvatar.IsCurrentActive = false;
            ActiveAvatarID++;
            if(ActiveAvatarID >= PlayerAvatars.Count)
            { ActiveAvatarID = 0; }
            ActivePlayerAvatar = PlayerAvatars[ActiveAvatarID];
            ActivePlayerAvatar.IsCurrentActive = true;

        }

    }

}
