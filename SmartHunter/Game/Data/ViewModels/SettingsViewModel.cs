using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Windows;
using SmartHunter.Core;
using SmartHunter.Core.Data;
using SmartHunter.Game.Helpers;

namespace SmartHunter.Game.Data.ViewModels
{
    public class SettingsViewModel : Bindable
    {
        static SettingsViewModel s_Instance = null;
        public static SettingsViewModel Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    s_Instance = new SettingsViewModel();
                }

                return s_Instance;
            }
        }

        public List<Setting> Settings { get; }

        private void restartSmartHunter()
        {
            string exec = Assembly.GetEntryAssembly()?.Location;
            if (exec != null)
            {
                Process.Start("SmartHunter.exe");
            }
            Environment.Exit(0);
        }

        private string GetString(string stringId)
        {
            return LocalizationHelper.GetString(stringId);
        }

        public SettingsViewModel()
        {
            Settings = new List<Setting>();

            Settings.Add(new Setting(ConfigHelper.Main.Values.ShutdownWhenProcessExits, GetString("LOC_SETTING_SHUTDOWN_WHEN_PROCESS_EXIT"), GetString("LOC_SETTING_SHUTDOWN_WHEN_PROCESS_EXIT_DESC"), new Command(_ =>
            {
                ConfigHelper.Main.Values.ShutdownWhenProcessExits = !ConfigHelper.Main.Values.ShutdownWhenProcessExits;
                ConfigHelper.Main.Save();
            })));
            Settings.Add(new Setting(ConfigHelper.Main.Values.AutomaticallyCheckAndDownloadUpdates, GetString("LOC_SETTING_AUTO_CHECK_AND_DOWNLOAD_UPDATES"), GetString("LOC_SETTING_AUTO_CHECK_AND_DOWNLOAD_UPDATES_DESC"), new Command(_ =>
            {
                ConfigHelper.Main.Values.AutomaticallyCheckAndDownloadUpdates = !ConfigHelper.Main.Values.AutomaticallyCheckAndDownloadUpdates;
                ConfigHelper.Main.Save();
                if (!ConfigHelper.Main.Values.AutomaticallyCheckAndDownloadUpdates)
                {
                    var result = MessageBox.Show(GetString("LOC_SETTING_RESTART_DESC"), GetString("LOC_SETTING_RESTART"), MessageBoxButton.YesNo, MessageBoxImage.Information);
                    if (result == MessageBoxResult.Yes)
                    {
                        restartSmartHunter();
                    }
                }
            })));

            Settings.Add(new Setting(ConfigHelper.Main.Values.Overlay.HideWhenGameWindowIsInactive, GetString("LOC_SETTING_HIDE_WHEN_GAME_WINDOW_IS_INACTIVE"), GetString("LOC_SETTING_HIDE_WHEN_GAME_WINDOW_IS_INACTIVE_DESC"), new Command(_ =>
            {
                ConfigHelper.Main.Values.Overlay.HideWhenGameWindowIsInactive = !ConfigHelper.Main.Values.Overlay.HideWhenGameWindowIsInactive;
                ConfigHelper.Main.Save();
            })));

            Settings.Add(new Setting(ConfigHelper.Main.Values.Overlay.TeamWidget.IsVisible, GetString("LOC_SETTING_TEAM_WIDGET"), GetString("LOC_SETTING_TEAM_WIDGET_DESC"), new Command(_ =>
            {
                ConfigHelper.Main.Values.Overlay.TeamWidget.IsVisible = !ConfigHelper.Main.Values.Overlay.TeamWidget.IsVisible;
                ConfigHelper.Main.Save();
            })));

            Settings.Add(new Setting(ConfigHelper.Main.Values.Overlay.TeamWidget.DontShowIfAlone, GetString("LOC_SETTING_DONT_SHOW_IF_ALONE"), GetString("LOC_SETTING_DONT_SHOW_IF_ALONE_DESC"), new Command(_ =>
            {
                ConfigHelper.Main.Values.Overlay.TeamWidget.DontShowIfAlone = !ConfigHelper.Main.Values.Overlay.TeamWidget.DontShowIfAlone;
                ConfigHelper.Main.Save();
            })));

            Settings.Add(new Setting(ConfigHelper.Main.Values.Overlay.TeamWidget.ShowBars, GetString("LOC_SETTING_TEAM_WIDGET_SHOW_BARS"), GetString("LOC_SETTING_TEAM_WIDGET_SHOW_BARS_DESC"), new Command(_ =>
            {
                ConfigHelper.Main.Values.Overlay.TeamWidget.ShowBars = !ConfigHelper.Main.Values.Overlay.TeamWidget.ShowBars;
                ConfigHelper.Main.Save();
            })));

            Settings.Add(new Setting(ConfigHelper.Main.Values.Overlay.TeamWidget.ShowNumbers, GetString("LOC_SETTING_TEAM_WIDGET_SHOW_NUMBERS"), GetString("LOC_SETTING_TEAM_WIDGET_SHOW_NUMBERS_DESC"), new Command(_ =>
            {
                ConfigHelper.Main.Values.Overlay.TeamWidget.ShowNumbers = !ConfigHelper.Main.Values.Overlay.TeamWidget.ShowNumbers;
                ConfigHelper.Main.Save();
            })));

            Settings.Add(new Setting(ConfigHelper.Main.Values.Overlay.TeamWidget.ShowPercents, GetString("LOC_SETTING_TEAM_WIDGET_SHOW_PERCENTS"), GetString("LOC_SETTING_TEAM_WIDGET_SHOW_PERCENTS_DESC"), new Command(_ =>
            {
                ConfigHelper.Main.Values.Overlay.TeamWidget.ShowPercents = !ConfigHelper.Main.Values.Overlay.TeamWidget.ShowPercents;
                ConfigHelper.Main.Save();
            })));

            Settings.Add(new Setting(ConfigHelper.Main.Values.Overlay.MonsterWidget.IsVisible, GetString("LOC_SETTING_MONSTER_WIDGET"), GetString("LOC_SETTING_MONSTER_WIDGET_DESC"), new Command(_ =>
            {
                ConfigHelper.Main.Values.Overlay.MonsterWidget.IsVisible = !ConfigHelper.Main.Values.Overlay.MonsterWidget.IsVisible;
                ConfigHelper.Main.Save();
            })));

            Settings.Add(new Setting(ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowUnchangedMonsters, GetString("LOC_SETTING_SHOW_UNCHANGED_MONSTERS"), GetString("LOC_SETTING_SHOW_UNCHANGED_MONSTERS_DESC"), new Command(_ =>
            {
                ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowUnchangedMonsters = !ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowUnchangedMonsters;
                ConfigHelper.Main.Save();
            })));

            Settings.Add(new Setting(ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowUnchangedParts, GetString("LOC_SETTING_SHOW_UNCHANGED_PARTS"), GetString("LOC_SETTING_SHOW_UNCHANGED_PARTS_DESC"), new Command(_ =>
            {
                ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowUnchangedParts = !ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowUnchangedParts;
                ConfigHelper.Main.Save();
            })));

            Settings.Add(new Setting(ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowUnchangedStatusEffects, GetString("LOC_SETTING_SHOW_UNCHANGED_STATUS_EFFECTS"), GetString("LOC_SETTING_SHOW_UNCHANGED_STATUS_EFFECTS_DESC"), new Command(_ =>
            {
                ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowUnchangedStatusEffects = !ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowUnchangedStatusEffects;
                ConfigHelper.Main.Save();
            })));

            Settings.Add(new Setting(ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowSize, GetString("LOC_SETTING_SHOW_MONSTER_SIZE"), GetString("LOC_SETTING_SHOW_MONSTER_SIZE_DESC"), new Command(_ =>
            {
                ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowSize = !ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowSize;
                ConfigHelper.Main.Save();
            })));

            Settings.Add(new Setting(ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowCrown, GetString("LOC_SETTING_SHOW_MONSTER_CROWN"), GetString("LOC_SETTING_SHOW_MONSTER_CROWN_DESC"), new Command(_ =>
            {
                ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowCrown = !ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowCrown;
                ConfigHelper.Main.Save();
            })));

            Settings.Add(new Setting(ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowBars, GetString("LOC_SETTING_MONSTER_WIDGET_SHOW_BARS"), GetString("LOC_SETTING_MONSTER_WIDGET_SHOW_BARS_DESC"), new Command(_ =>
            {
                ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowBars = !ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowBars;
                ConfigHelper.Main.Save();
            })));

            Settings.Add(new Setting(ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowNumbers, GetString("LOC_SETTING_MONSTER_WIDGET_SHOW_NUMBERS"), GetString("LOC_SETTING_MONSTER_WIDGET_SHOW_NUMBERS_DESC"), new Command(_ =>
            {
                ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowNumbers = !ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowNumbers;
                ConfigHelper.Main.Save();
            })));

            Settings.Add(new Setting(ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowPercents, GetString("LOC_SETTING_MONSTER_WIDGET_SHOW_PERCENTS"), GetString("LOC_SETTING_MONSTER_WIDGET_SHOW_PERCENTS_DESC"), new Command(_ =>
            {
                ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowPercents = !ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowPercents;
                ConfigHelper.Main.Save();
            })));

            Settings.Add(new Setting(ConfigHelper.Main.Values.Overlay.MonsterWidget.UseAnimations, GetString("LOC_SETTING_USE_ANIMATIONS"), GetString("LOC_SETTING_USE_ANIMATIONS_DESC"), new Command(_ =>
            {
                ConfigHelper.Main.Values.Overlay.MonsterWidget.UseAnimations = !ConfigHelper.Main.Values.Overlay.MonsterWidget.UseAnimations;
                ConfigHelper.Main.Save();
            })));

            Settings.Add(new Setting(ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowOnlySelectedMonster, GetString("LOC_SETTING_SHOW_ONLY_SELECTED_MONSTER"), GetString("LOC_SETTING_SHOW_ONLY_SELECTED_MONSTER_DESC"), new Command(_ =>
            {
                ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowOnlySelectedMonster = !ConfigHelper.Main.Values.Overlay.MonsterWidget.ShowOnlySelectedMonster;
                ConfigHelper.Main.Save();
            })));

            Settings.Add(new Setting(ConfigHelper.Main.Values.Overlay.MonsterWidget.AlwaysShowParts, GetString("LOC_SETTING_ALWAYS_SHOW_PARTS"), GetString("LOC_SETTING_ALWAYS_SHOW_PARTS_DESC"), new Command(_ =>
            {
                ConfigHelper.Main.Values.Overlay.MonsterWidget.AlwaysShowParts = !ConfigHelper.Main.Values.Overlay.MonsterWidget.AlwaysShowParts;
                ConfigHelper.Main.Save();
            })));

            Settings.Add(new Setting(ConfigHelper.Main.Values.Overlay.PlayerWidget.IsVisible, GetString("LOC_SETTING_PLAYER_WIDGET"), GetString("LOC_SETTING_PLAYER_WIDGET_DESC"), new Command(_ =>
            {
                ConfigHelper.Main.Values.Overlay.PlayerWidget.IsVisible = !ConfigHelper.Main.Values.Overlay.PlayerWidget.IsVisible;
                ConfigHelper.Main.Save();
            })));

            Settings.Add(new Setting(ConfigHelper.Main.Values.Overlay.DebugWidget.IsVisible, GetString("LOC_SETTING_DEGUB_WIDGET"), GetString("LOC_SETTING_DEGUB_WIDGET_DESC"), new Command(_ =>
            {
                ConfigHelper.Main.Values.Overlay.DebugWidget.IsVisible = !ConfigHelper.Main.Values.Overlay.DebugWidget.IsVisible;
                ConfigHelper.Main.Save();
            })));

            Settings.Add(new Setting(ConfigHelper.Main.Values.Debug.ShowServerLogs, GetString("LOC_SETTING_SHOW_SERVER_LOGS"), GetString("LOC_SETTING_SHOW_SERVER_LOGS_DESC"), new Command(_ =>
            {
                ConfigHelper.Main.Values.Debug.ShowServerLogs = !ConfigHelper.Main.Values.Debug.ShowServerLogs;
                ConfigHelper.Main.Save();
            })));
        }
    }
}
