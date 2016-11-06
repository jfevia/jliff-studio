using System.ComponentModel;
using System.Configuration;

namespace JliffStudio.Properties
{
    public sealed partial class Settings
    {
        public Settings()
        {
            SettingChanging += SettingChangingEventHandler;
            SettingsSaving += SettingsSavingEventHandler;
            PropertyChanged += SettingPropertyChanged;
        }

        private void SettingChangingEventHandler(object sender, SettingChangingEventArgs e)
        {
            // Add code to handle the SettingChangingEvent event here.
        }

        private void SettingPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Default.Save();
        }

        private void SettingsSavingEventHandler(object sender, CancelEventArgs e)
        {
            // Add code to handle the SettingsSaving event here.
        }
    }
}