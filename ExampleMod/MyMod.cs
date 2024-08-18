using FarewellCore;
using Harmony;
using MelonLoader;

namespace ExampleMod
{
    public class ExampleMod : FarewellMod
    {
        public static MelonLogger.Instance Logger => Melon<ExampleMod>.Logger;

        public override void OnInitializeMelon()
        {
            // Post-initialisation method
        }
    }
}
