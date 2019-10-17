using System;
using System.Collections;
using System.Security;
using Env = System.Environment;

namespace NotifyIconAppTemplate
{
    public enum SpecialFolderInfo
    {
        Desktop,
        Programs,
        Personal,
        MyDocuments,
        Favorites,
        Startup,
        Recent,
        SendTo,
        StartMenu,
        MyMusic,
        MyVideos,
        DesktopDirectory,
        MyComputer,
        NetworkShortcuts,
        Fonts,
        Templates,
        ApplicationData,
        PrinterShortcuts,
        LocalApplicationData,
        InternetCache,
        Cookies,
        History,
        Windows,
        System,
        ProgramFiles,
        MyPictures,
        UserProfile,
        SystemX86,
        ProgramFilesX86,
        AdminTools,
        Resources,
        LocalizedResources
    }

    public enum UserInfo
    {
        General,
        Public,
        Default,
        LoggedUser
    }

    public static class EnvironmentInfo
    {
        internal static class MappingSpecialFolder
        {
            public static Env.SpecialFolder? MappingToEnvironment(UserInfo userInfo, SpecialFolderInfo folderInfo)
            {
                switch (userInfo)
                {
                    case UserInfo.General:
                        switch (folderInfo)
                        {
                            case SpecialFolderInfo.Desktop:
                                return Env.SpecialFolder.Desktop;
                            case SpecialFolderInfo.Programs:
                                return Env.SpecialFolder.CommonPrograms;
                            case SpecialFolderInfo.Personal:
                                return Env.SpecialFolder.Personal;
                            case SpecialFolderInfo.MyDocuments:
                                return Env.SpecialFolder.MyDocuments;
                            case SpecialFolderInfo.Favorites:
                                return Env.SpecialFolder.Favorites;
                            case SpecialFolderInfo.Startup:
                                return Env.SpecialFolder.CommonStartup;
                            case SpecialFolderInfo.Recent:
                                return Env.SpecialFolder.Recent;
                            case SpecialFolderInfo.SendTo:
                                return Env.SpecialFolder.SendTo;
                            case SpecialFolderInfo.StartMenu:
                                return Env.SpecialFolder.CommonStartMenu;
                            case SpecialFolderInfo.MyMusic:
                                return Env.SpecialFolder.MyMusic;
                            case SpecialFolderInfo.MyVideos:
                                return Env.SpecialFolder.MyVideos;
                            case SpecialFolderInfo.DesktopDirectory:
                                return Env.SpecialFolder.CommonDesktopDirectory;
                            case SpecialFolderInfo.MyComputer:
                                return Env.SpecialFolder.MyComputer;
                            case SpecialFolderInfo.NetworkShortcuts:
                                return Env.SpecialFolder.NetworkShortcuts;
                            case SpecialFolderInfo.Fonts:
                                return Env.SpecialFolder.Fonts;
                            case SpecialFolderInfo.Templates:
                                return Env.SpecialFolder.CommonTemplates;
                            case SpecialFolderInfo.ApplicationData:
                                return Env.SpecialFolder.CommonApplicationData;
                            case SpecialFolderInfo.PrinterShortcuts:
                                return Env.SpecialFolder.PrinterShortcuts;
                            case SpecialFolderInfo.LocalApplicationData:
                                return Env.SpecialFolder.LocalApplicationData;
                            case SpecialFolderInfo.InternetCache:
                                return Env.SpecialFolder.InternetCache;
                            case SpecialFolderInfo.Cookies:
                                return Env.SpecialFolder.Cookies;
                            case SpecialFolderInfo.History:
                                return Env.SpecialFolder.History;
                            case SpecialFolderInfo.Windows:
                                return Env.SpecialFolder.Windows;
                            case SpecialFolderInfo.System:
                                return Env.SpecialFolder.System;
                            case SpecialFolderInfo.ProgramFiles:
                                return Env.SpecialFolder.CommonProgramFiles;
                            case SpecialFolderInfo.MyPictures:
                                return Env.SpecialFolder.MyPictures;
                            case SpecialFolderInfo.UserProfile:
                                return Env.SpecialFolder.UserProfile;
                            case SpecialFolderInfo.SystemX86:
                                return Env.SpecialFolder.SystemX86;
                            case SpecialFolderInfo.ProgramFilesX86:
                                return Env.SpecialFolder.CommonProgramFilesX86;
                            case SpecialFolderInfo.AdminTools:
                                return Env.SpecialFolder.CommonAdminTools;
                            case SpecialFolderInfo.Resources:
                                return Env.SpecialFolder.Resources;
                            case SpecialFolderInfo.LocalizedResources:
                                return Env.SpecialFolder.LocalizedResources;
                            default:
                                return null;
                        }

                    case UserInfo.Public:
                        switch (folderInfo)
                        {
                            case SpecialFolderInfo.Desktop:
                                return Env.SpecialFolder.Desktop;
                            case SpecialFolderInfo.Programs:
                                return Env.SpecialFolder.CommonPrograms;
                            case SpecialFolderInfo.Personal:
                                return Env.SpecialFolder.Personal;
                            case SpecialFolderInfo.MyDocuments:
                                return Env.SpecialFolder.MyDocuments;
                            case SpecialFolderInfo.Favorites:
                                return Env.SpecialFolder.Favorites;
                            case SpecialFolderInfo.Startup:
                                return Env.SpecialFolder.CommonStartup;
                            case SpecialFolderInfo.Recent:
                                return Env.SpecialFolder.Recent;
                            case SpecialFolderInfo.SendTo:
                                return Env.SpecialFolder.SendTo;
                            case SpecialFolderInfo.StartMenu:
                                return Env.SpecialFolder.CommonStartMenu;
                            case SpecialFolderInfo.MyMusic:
                                return Env.SpecialFolder.MyMusic;
                            case SpecialFolderInfo.MyVideos:
                                return Env.SpecialFolder.MyVideos;
                            case SpecialFolderInfo.DesktopDirectory:
                                return Env.SpecialFolder.CommonDesktopDirectory;
                            case SpecialFolderInfo.MyComputer:
                                return Env.SpecialFolder.MyComputer;
                            case SpecialFolderInfo.NetworkShortcuts:
                                return Env.SpecialFolder.NetworkShortcuts;
                            case SpecialFolderInfo.Fonts:
                                return Env.SpecialFolder.Fonts;
                            case SpecialFolderInfo.Templates:
                                return Env.SpecialFolder.CommonTemplates;
                            case SpecialFolderInfo.ApplicationData:
                                return Env.SpecialFolder.CommonApplicationData;
                            case SpecialFolderInfo.PrinterShortcuts:
                                return Env.SpecialFolder.PrinterShortcuts;
                            case SpecialFolderInfo.LocalApplicationData:
                                return Env.SpecialFolder.LocalApplicationData;
                            case SpecialFolderInfo.InternetCache:
                                return Env.SpecialFolder.InternetCache;
                            case SpecialFolderInfo.Cookies:
                                return Env.SpecialFolder.Cookies;
                            case SpecialFolderInfo.History:
                                return Env.SpecialFolder.History;
                            case SpecialFolderInfo.Windows:
                                return Env.SpecialFolder.Windows;
                            case SpecialFolderInfo.System:
                                return Env.SpecialFolder.System;
                            case SpecialFolderInfo.ProgramFiles:
                                return Env.SpecialFolder.CommonProgramFiles;
                            case SpecialFolderInfo.MyPictures:
                                return Env.SpecialFolder.MyPictures;
                            case SpecialFolderInfo.UserProfile:
                                return Env.SpecialFolder.UserProfile;
                            case SpecialFolderInfo.SystemX86:
                                return Env.SpecialFolder.SystemX86;
                            case SpecialFolderInfo.ProgramFilesX86:
                                return Env.SpecialFolder.CommonProgramFilesX86;
                            case SpecialFolderInfo.AdminTools:
                                return Env.SpecialFolder.CommonAdminTools;
                            case SpecialFolderInfo.Resources:
                                return Env.SpecialFolder.Resources;
                            case SpecialFolderInfo.LocalizedResources:
                                return Env.SpecialFolder.LocalizedResources;
                            default:
                                return null;
                        }

                    case UserInfo.LoggedUser:
                        switch (folderInfo)
                        {
                            case SpecialFolderInfo.Desktop:
                                return Env.SpecialFolder.Desktop;
                            case SpecialFolderInfo.Programs:
                                return Env.SpecialFolder.Programs;
                            case SpecialFolderInfo.Personal:
                                return Env.SpecialFolder.Personal;
                            case SpecialFolderInfo.MyDocuments:
                                return Env.SpecialFolder.MyDocuments;
                            case SpecialFolderInfo.Favorites:
                                return Env.SpecialFolder.Favorites;
                            case SpecialFolderInfo.Startup:
                                return Env.SpecialFolder.Startup;
                            case SpecialFolderInfo.Recent:
                                return Env.SpecialFolder.Recent;
                            case SpecialFolderInfo.SendTo:
                                return Env.SpecialFolder.SendTo;
                            case SpecialFolderInfo.StartMenu:
                                return Env.SpecialFolder.StartMenu;
                            case SpecialFolderInfo.MyMusic:
                                return Env.SpecialFolder.MyMusic;
                            case SpecialFolderInfo.MyVideos:
                                return Env.SpecialFolder.MyVideos;
                            case SpecialFolderInfo.DesktopDirectory:
                                return Env.SpecialFolder.DesktopDirectory;
                            case SpecialFolderInfo.MyComputer:
                                return Env.SpecialFolder.MyComputer;
                            case SpecialFolderInfo.NetworkShortcuts:
                                return Env.SpecialFolder.NetworkShortcuts;
                            case SpecialFolderInfo.Fonts:
                                return Env.SpecialFolder.Fonts;
                            case SpecialFolderInfo.Templates:
                                return Env.SpecialFolder.Templates;
                            case SpecialFolderInfo.ApplicationData:
                                return Env.SpecialFolder.ApplicationData;
                            case SpecialFolderInfo.PrinterShortcuts:
                                return Env.SpecialFolder.PrinterShortcuts;
                            case SpecialFolderInfo.LocalApplicationData:
                                return Env.SpecialFolder.LocalApplicationData;
                            case SpecialFolderInfo.InternetCache:
                                return Env.SpecialFolder.InternetCache;
                            case SpecialFolderInfo.Cookies:
                                return Env.SpecialFolder.Cookies;
                            case SpecialFolderInfo.History:
                                return Env.SpecialFolder.History;
                            case SpecialFolderInfo.Windows:
                                return Env.SpecialFolder.Windows;
                            case SpecialFolderInfo.System:
                                return Env.SpecialFolder.System;
                            case SpecialFolderInfo.ProgramFiles:
                                return Env.SpecialFolder.ProgramFiles;
                            case SpecialFolderInfo.MyPictures:
                                return Env.SpecialFolder.MyPictures;
                            case SpecialFolderInfo.UserProfile:
                                return Env.SpecialFolder.UserProfile;
                            case SpecialFolderInfo.SystemX86:
                                return Env.SpecialFolder.SystemX86;
                            case SpecialFolderInfo.ProgramFilesX86:
                                return Env.SpecialFolder.ProgramFilesX86;
                            case SpecialFolderInfo.AdminTools:
                                return Env.SpecialFolder.AdminTools;
                            case SpecialFolderInfo.Resources:
                                return Env.SpecialFolder.Resources;
                            case SpecialFolderInfo.LocalizedResources:
                                return Env.SpecialFolder.LocalizedResources;
                            default:
                                return null;
                        }

                    case UserInfo.Default:
                    default:
                        switch (folderInfo)
                        {
                            case SpecialFolderInfo.Desktop:
                                return Env.SpecialFolder.Desktop;
                            case SpecialFolderInfo.Programs:
                                return Env.SpecialFolder.CommonPrograms;
                            case SpecialFolderInfo.Personal:
                                return Env.SpecialFolder.Personal;
                            case SpecialFolderInfo.MyDocuments:
                                return Env.SpecialFolder.MyDocuments;
                            case SpecialFolderInfo.Favorites:
                                return Env.SpecialFolder.Favorites;
                            case SpecialFolderInfo.Startup:
                                return Env.SpecialFolder.CommonStartup;
                            case SpecialFolderInfo.Recent:
                                return Env.SpecialFolder.Recent;
                            case SpecialFolderInfo.SendTo:
                                return Env.SpecialFolder.SendTo;
                            case SpecialFolderInfo.StartMenu:
                                return Env.SpecialFolder.CommonStartMenu;
                            case SpecialFolderInfo.MyMusic:
                                return Env.SpecialFolder.MyMusic;
                            case SpecialFolderInfo.MyVideos:
                                return Env.SpecialFolder.MyVideos;
                            case SpecialFolderInfo.DesktopDirectory:
                                return Env.SpecialFolder.CommonDesktopDirectory;
                            case SpecialFolderInfo.MyComputer:
                                return Env.SpecialFolder.MyComputer;
                            case SpecialFolderInfo.NetworkShortcuts:
                                return Env.SpecialFolder.NetworkShortcuts;
                            case SpecialFolderInfo.Fonts:
                                return Env.SpecialFolder.Fonts;
                            case SpecialFolderInfo.Templates:
                                return Env.SpecialFolder.CommonTemplates;
                            case SpecialFolderInfo.ApplicationData:
                                return Env.SpecialFolder.CommonApplicationData;
                            case SpecialFolderInfo.PrinterShortcuts:
                                return Env.SpecialFolder.PrinterShortcuts;
                            case SpecialFolderInfo.LocalApplicationData:
                                return Env.SpecialFolder.LocalApplicationData;
                            case SpecialFolderInfo.InternetCache:
                                return Env.SpecialFolder.InternetCache;
                            case SpecialFolderInfo.Cookies:
                                return Env.SpecialFolder.Cookies;
                            case SpecialFolderInfo.History:
                                return Env.SpecialFolder.History;
                            case SpecialFolderInfo.Windows:
                                return Env.SpecialFolder.Windows;
                            case SpecialFolderInfo.System:
                                return Env.SpecialFolder.System;
                            case SpecialFolderInfo.ProgramFiles:
                                return Env.SpecialFolder.CommonProgramFiles;
                            case SpecialFolderInfo.MyPictures:
                                return Env.SpecialFolder.MyPictures;
                            case SpecialFolderInfo.UserProfile:
                                return Env.SpecialFolder.UserProfile;
                            case SpecialFolderInfo.SystemX86:
                                return Env.SpecialFolder.SystemX86;
                            case SpecialFolderInfo.ProgramFilesX86:
                                return Env.SpecialFolder.CommonProgramFilesX86;
                            case SpecialFolderInfo.AdminTools:
                                return Env.SpecialFolder.CommonAdminTools;
                            case SpecialFolderInfo.Resources:
                                return Env.SpecialFolder.Resources;
                            case SpecialFolderInfo.LocalizedResources:
                                return Env.SpecialFolder.LocalizedResources;
                            default:
                                return null;
                        }
                }
            }
        }

        #region System Informations...

        public static Version AppVersion => Env.Version;
        public static Version WinVersion => Env.Version;
        public static OperatingSystem OSVersion => Env.OSVersion;
        public static string NewLine => Env.NewLine;
        public static string StackTrace => Env.StackTrace;
        public static bool Is64BitProcess => Env.Is64BitProcess;
        public static bool Is64BitOperatingSystem => Env.Is64BitOperatingSystem;
        public static bool HasShutdownStarted => Env.HasShutdownStarted;
        public static string UserDomainName => Env.UserDomainName;
        public static string UserName => Env.UserName;
        public static bool UserInteractive => Env.UserInteractive;
        public static string MachineName => Env.MachineName;

        #endregion

        #region Paths...

        public static string PathCurrent => Env.CurrentDirectory;
        public static string PathSystem => Env.SystemDirectory;

        public static string PathAppData => Env.ExpandEnvironmentVariables("%AppData%");
        public static string PathAppDataCommon => PathAppData.Replace(Env.UserName.ToLowerInvariant(), "Default");
        public static string PathTaskBar => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.ApplicationData), @"Microsoft\Internet Explorer\Quick Launch\User Pinned\TaskBar");
        public static string PathTaskBarCommon => PathTaskBar.Replace(Env.UserName.ToLowerInvariant(), "Default");
        public static string PathStartMenu => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.StartMenu));
        public static string PathStartMenuCommon => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.CommonStartMenu));
        public static string PathStartMenuPrograms => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.StartMenu), "Programs");
        public static string PathStartMenuProgramsCommon => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.CommonStartMenu), "Programs");

        public static string PathAdminToolsCommon => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.CommonAdminTools));
        public static string PathApplicationDataCommon => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.CommonApplicationData));
        public static string PathDesktopDirectoryCommon => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.CommonDesktopDirectory));
        public static string PathProgramFilesCommon => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.CommonProgramFiles));
        public static string PathProgramFilesX86Common => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.CommonProgramFilesX86));
        public static string PathProgramsCommon => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.CommonPrograms));
        public static string PathStartupCommon => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.CommonStartup));
        public static string PathTemplatesCommon => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.CommonTemplates));
        public static string PathCookies => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.Cookies));
        public static string PathDesktop => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.Desktop));
        public static string PathFavorites => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.Favorites));
        public static string PathFonts => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.Fonts));
        public static string PathHistory => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.History));
        public static string PathInternetCache => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.InternetCache));
        public static string PathLocalApplicationData => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.LocalApplicationData));
        public static string PathLocalizedResources => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.LocalizedResources));
        public static string PathMyComputer => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.MyComputer));
        public static string PathMyDocuments => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.MyDocuments));
        public static string PathMyMusic => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.MyMusic));
        public static string PathMyPictures => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.MyPictures));
        public static string PathMyVideos => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.MyVideos));
        public static string PathNetworkShortcuts => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.NetworkShortcuts));
        public static string PathPersonal => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.Personal));
        public static string PathPrinterShortcuts => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.PrinterShortcuts));
        public static string PathRecent => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.Recent));
        public static string PathResources => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.Resources));
        public static string PathSendTo => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.SendTo));
        public static string PathSystemX86 => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.SystemX86));
        public static string PathUserProfile => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.UserProfile));
        public static string PathWindows => System.IO.Path.Combine(Env.GetFolderPath(Env.SpecialFolder.Windows));

        #endregion

        [SecuritySafeCritical]
        public static void Exit(int exitCode)
        {
            Env.Exit(exitCode);
        }

        [SecuritySafeCritical]
        public static string[] GetCommandLineArgs()
        {
            return Env.GetCommandLineArgs();
        }

        [SecuritySafeCritical]
        public static string GetEnvironmentVariable(string variable, EnvironmentVariableTarget? target = null)
        {
            return target.HasValue ? Env.GetEnvironmentVariable(variable, target.Value) : Env.GetEnvironmentVariable(variable);
        }

        [SecuritySafeCritical]
        public static IDictionary GetEnvironmentVariables(EnvironmentVariableTarget? target = null)
        {
            return target.HasValue ? Env.GetEnvironmentVariables(target.Value) : Env.GetEnvironmentVariables();
        }

        [SecuritySafeCritical]
        public static string GetFolderPath(SpecialFolderInfo folder, Env.SpecialFolderOption? option = null)
        {
            return option.HasValue ? Env.GetFolderPath((Env.SpecialFolder)folder, option.Value) : Env.GetFolderPath((Env.SpecialFolder)folder);
        }

        [SecuritySafeCritical]
        public static void SetEnvironmentVariable(string variable, string value, EnvironmentVariableTarget? target = null)
        {
            if (target.HasValue)
                Env.SetEnvironmentVariable(variable, value, target.Value);
            else
                Env.SetEnvironmentVariable(variable, value);
        }
    }
}