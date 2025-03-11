using PerfectRandom.Sulfur.Core;
using PerfectRandom.Sulfur.Core.LevelGeneration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetharNet.Mods.MODCore.Event
{
    public static class StartLevelRoutineGraphEvent 
    {
        public delegate bool BeforeLevelLoadHandler(WorldEnvironment chapterSO, int levelIndex, LoadingMode loadingMode, string spawnIdentifier);
        public delegate void AfterLevelLoadHandler(IEnumerator levelLoadRoutine);
        public static event BeforeLevelLoadHandler OnBeforeLevelLoad;
        public static event AfterLevelLoadHandler OnAfterLevelLoad;

        internal static bool InvokeBeforeLevelLoad(WorldEnvironment chapterSO, int levelIndex, LoadingMode loadingMode, string spawnIdentifier)
        {

            if (OnBeforeLevelLoad != null)
            {
                foreach (BeforeLevelLoadHandler handler in OnBeforeLevelLoad.GetInvocationList())
                {
                    if (!handler.Invoke(chapterSO, levelIndex, loadingMode, spawnIdentifier))
                    {
                        return false; 
                    }
                }
            }
            return true;
        }

        internal static void InvokeAfterLevelLoad(IEnumerator levelLoadRoutine)
        {
            OnAfterLevelLoad?.Invoke(levelLoadRoutine);
        }


    }
}
