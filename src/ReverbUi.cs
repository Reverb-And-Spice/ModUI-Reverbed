using MelonLoader;
using ModUI_Reverbed;

[assembly: MelonInfo(typeof(ReverbUi),BuildInfo.Name, BuildInfo.Version, BuildInfo.Authors)]
[assembly: MelonGame("Buckethead Entertainment", "RUMBLE")]
[assembly: MelonColor(255, 255, 170, 238)] // #FAE pink :3

namespace ModUI_Reverbed;

public class ReverbUi : MelonMod // Looks better if the classname is ReverbUi, bite me -blank
{
    public override void OnLateInitializeMelon()
    {
        // subscribe to shit here I.e. the match start event from the modding ui

        //relevant comment
        
    }

    public override void OnApplicationQuit()
    {
       // please unsubscribe from events here
    }
    
    // do whatever here
}