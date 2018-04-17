﻿using Akumina.Interchange.Core.Interfaces;
using System.Web.Mvc;
using Akumina.Interchange.Core.Entities;
using Akumina.Interchange.Core.Entities.Item;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace SimpleContentApp.Areas.Simple
{
    [Export(typeof(IContentApp))]
    public class Simple : IContentApp
    {
      
        public Simple()
        {
            Title = "My SimpleControl";
            AdminGroup = "akdev1trainingIC40 Owners";
            SharepointURL = "https://akuminademo.sharepoint.com/sites/akdev1trainingIC40";
            ListName = "CoolDemo_AK";
            ListId = "908700CE-3E05-4090-8818-DFAC0193E689";

            UserSettings = new List<CustomSettingsField>();
            UserSettings.Add(new CustomSettingsField() { Name = "SIMPLE FIELD 1", HelpText = "SIMPLE HELP TEXT 1", Value = "SIMPLE HARNESS 1" });
            UserSettings.Add(new CustomSettingsField() { Name = "SIMPLE FIELD 2", HelpText = "SIMPLE HELP TEXT 2", Value = "SIMPLE HARNESS 2" });
            UserSettings.Add(new CustomSettingsField() { Name = "SIMPLE FIELD 3", HelpText = "SIMPLE HELP TEXT 3", Value = "SIMPLE HARNESS 3" });
           

        }
        public string AdminGroup
        {
            get;
            set;
        }

        public string Layout
        {
            get;
            set;
        }

        public string ListId
        {
            get;
            set;
        }

        public string ListName
        {
            get;
            set;
        }

        public List<CustomNavigationItem> Navigation
        {
            get
            {
                List<CustomNavigationItem> t = new List<CustomNavigationItem>() { new CustomNavigationItem() { Title = "Item List", Url = String.Format("/Simple/{0}/", ListId) } };
                return t;

            }
        }

        public IContentAppService Service
        {
            get; set;
        }

        public string SharepointURL
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public List<CustomSettingsField> UserSettings
        {
            get;
            set;
        }
    }
}