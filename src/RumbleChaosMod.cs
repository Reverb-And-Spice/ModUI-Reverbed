using MelonLoader;
using RumbleChaos;

[assembly: MelonInfo(typeof(RumbleChaosMod),BuildInfo.Name, BuildInfo.Version, BuildInfo.Authors)]
[assembly: MelonGame("Buckethead Entertainment", "RUMBLE")]
[assembly: MelonColor(255, 255, 170, 238)] // #FAE pink :3

namespace RumbleChaos;

public class RumbleChaosMod : MelonMod // Looks better if the classname is RumbleChaosMod, bite me -blank
{
    public override void OnLateInitializeMelon()
    {
        // subscribe to shit here I.e. the match start event from the modding ui

        // i REALLY HATE turtles
        //EVEN MORE RELEVANT COMMNET!!!
        //Less relevant arbitrary one to test
    }

    public override void OnApplicationQuit()
    {
       // please unsubscribe from events here
    }
    
    // do whatever here
}