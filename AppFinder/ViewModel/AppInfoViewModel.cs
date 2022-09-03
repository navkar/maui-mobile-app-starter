using Microsoft.Maui;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;

namespace AppFinder.ViewModel
{
    public class AppInfoViewModel : BaseViewModel
    {
        public string AppPackageName => AppInfo.PackageName;

        public string AppName => AppInfo.Name;

        public string AppVersion => AppInfo.VersionString;

        public string AppBuild => AppInfo.BuildString;

        public string AppVersionBuild => String.Format("v{0} b{1}", AppInfo.VersionString, AppInfo.BuildString);

        public string AppTheme => AppInfo.RequestedTheme.ToString();

        public Command ShowSettingsUICommand { get; }

        public AppInfoViewModel()
        {
            ShowSettingsUICommand = new Command(() => AppInfo.ShowSettingsUI());
        }
    }
}

