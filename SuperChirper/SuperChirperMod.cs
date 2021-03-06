﻿using ColossalFramework.UI;
using ICities;
using System;
using UnityEngine;

/*
 *  I've tried to give credit throughout to the appropriate people, but here is a list of the work used here:
 *  
 * http://www.reddit.com/r/CitiesSkylinesModding/comments/2ymwxe/example_code_using_the_colossal_ui_in_a_user_mod/ 
 * https://gist.github.com/reima/9ba51c69f65ae2da7909
 * https://github.com/skymodteam/skymod-chirpymaid
 * https://github.com/mabako/reddit-for-city-skylines
 * /u/Zuppis and his ChirpFilter mod: http://steamcommunity.com/sharedfiles/filedetails/?id=407871375
 * 
 * 
 */
namespace SuperChirper
{
    public class SuperChirperMod : IUserMod
    {
        private static UIButton clearButtonInstance;
        private static UIButton muteButtonInstance;
        private static UIButton filterButtonInstance;
        private static UIButton optionsButtonInstance;
        private static UIButton hashTagsButtonInstance;
        private static ChirperConfigPanel optionsPanelInstance;

        public static UIButton ClearButtonInstance
        {
            get
            {
                return clearButtonInstance;
            }
            set
            {
                clearButtonInstance = value;
            }
        }

        public static UIButton MuteButtonInstance
        {
            get
            {
                return muteButtonInstance;
            }
            set
            {
                muteButtonInstance = value;
            }
        }

        public static UIButton FilterButtonInstance
        {
            get
            {
                return filterButtonInstance;
            }
            set
            {
                filterButtonInstance = value;
            }
        }

        public static UIButton OptionsButtonInstance
        {
            get
            {
                return optionsButtonInstance;
            }
            set
            {
                optionsButtonInstance = value;
            }
        }

        public static UIButton HashTagsButtonInstance
        {
            get
            {
                return hashTagsButtonInstance;
            }
            set
            {
                hashTagsButtonInstance = value;
            }
        }

        public static ChirperConfigPanel OptionsPanelInstance
        {
            get
            {
                return optionsPanelInstance;
            }
            set
            {
                optionsPanelInstance = value;
            }
        }

        public string Name
        {
            get { return "SuperChirper"; }
        }

        public string Description
        {
            get { return "Adds much more functionality to Chirpy. See workshop for details."; }
        }
    }    
}