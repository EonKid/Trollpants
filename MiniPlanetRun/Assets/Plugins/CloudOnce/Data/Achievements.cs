// <copyright file="Achievements.cs" company="Jan Ivar Z. Carlsen, Sindri Jóelsson">
// Copyright (c) 2016 Jan Ivar Z. Carlsen, Sindri Jóelsson. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace CloudOnce
{
    using Internal;

    /// <summary>
    /// Provides access to achievements registered via the CloudOnce Editor.
    /// This file was automatically generated by CloudOnce. Do not edit.
    /// </summary>
    public static class Achievements
    {
        private static readonly UnifiedAchievement s_score100 = new UnifiedAchievement("Score100",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_AMAZON
            ""
#else
            "Score100"
#endif
            );

        public static UnifiedAchievement Score100
        {
            get { return s_score100; }
        }

        private static readonly UnifiedAchievement s_score250 = new UnifiedAchievement("Score250",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_AMAZON
            ""
#else
            "Score250"
#endif
            );

        public static UnifiedAchievement Score250
        {
            get { return s_score250; }
        }

        private static readonly UnifiedAchievement s_cherryPicker = new UnifiedAchievement("CherryPicker",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_AMAZON
            ""
#else
            "CherryPicker"
#endif
            );

        public static UnifiedAchievement CherryPicker
        {
            get { return s_cherryPicker; }
        }

        private static readonly UnifiedAchievement s_cherryHarvester = new UnifiedAchievement("CherryHarvester",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_AMAZON
            ""
#else
            "CherryHarvester"
#endif
            );

        public static UnifiedAchievement CherryHarvester
        {
            get { return s_cherryHarvester; }
        }

        private static readonly UnifiedAchievement s_cherryHoarder = new UnifiedAchievement("CherryHoarder",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_AMAZON
            ""
#else
            "CherryHoarder"
#endif
            );

        public static UnifiedAchievement CherryHoarder
        {
            get { return s_cherryHoarder; }
        }

        private static readonly UnifiedAchievement s_moreTheMerrier = new UnifiedAchievement("MoreTheMerrier",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_AMAZON
            ""
#else
            "MoreTheMerrier"
#endif
            );

        public static UnifiedAchievement MoreTheMerrier
        {
            get { return s_moreTheMerrier; }
        }

        private static readonly UnifiedAchievement s_runnersAssemble = new UnifiedAchievement("RunnersAssemble",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_AMAZON
            ""
#else
            "RunnersAssemble"
#endif
            );

        public static UnifiedAchievement RunnersAssemble
        {
            get { return s_runnersAssemble; }
        }

        private static readonly UnifiedAchievement s_skilledDodger = new UnifiedAchievement("SkilledDodger",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_AMAZON
            ""
#else
            "SkilledDodger"
#endif
            );

        public static UnifiedAchievement SkilledDodger
        {
            get { return s_skilledDodger; }
        }

        private static readonly UnifiedAchievement s_expertDodger = new UnifiedAchievement("ExpertDodger",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_AMAZON
            ""
#else
            "ExpertDodger"
#endif
            );

        public static UnifiedAchievement ExpertDodger
        {
            get { return s_expertDodger; }
        }

        private static readonly UnifiedAchievement s_cherryPie = new UnifiedAchievement("CherryPie",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_AMAZON
            ""
#else
            "CherryPie"
#endif
            );

        public static UnifiedAchievement CherryPie
        {
            get { return s_cherryPie; }
        }

        private static readonly UnifiedAchievement s_cherryBomb = new UnifiedAchievement("CherryBomb",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_AMAZON
            ""
#else
            "CherryBomb"
#endif
            );

        public static UnifiedAchievement CherryBomb
        {
            get { return s_cherryBomb; }
        }

        public static readonly UnifiedAchievement[] All =
        {
            s_score100,
            s_score250,
            s_cherryPicker,
            s_cherryHarvester,
            s_cherryHoarder,
            s_moreTheMerrier,
            s_runnersAssemble,
            s_skilledDodger,
            s_expertDodger,
            s_cherryPie,
            s_cherryBomb,
        };
    }
}