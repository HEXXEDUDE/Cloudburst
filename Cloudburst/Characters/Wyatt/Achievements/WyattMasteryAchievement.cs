﻿using RoR2;
using RoR2.Achievements;
using System.Text;

namespace Cloudburst.Characters.Wyatt.Achievements
{
    [RegisterAchievement("CloudburstWyattClearGameMonsoon", "cloudburst.skins.wyatt.mastery", null, null)]
    public class WyattMasteryAchievement : BasePerSurvivorClearGameMonsoonAchievement
    {
        public override BodyIndex LookUpRequiredBodyIndex()
        {
            return BodyCatalog.FindBodyIndex("WyattBody");
        }
    }
}
