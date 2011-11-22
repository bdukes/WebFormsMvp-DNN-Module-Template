namespace $Namespace$$safeprojectname$.Views
{
    using System;
    using DotNetNuke.UI.Modules;
    using DotNetNuke.Web.Mvp;
    using Models;
    using Presenters;
    using WebFormsMvp;

    [PresenterBinding(typeof(SettingsPresenter))]
    public partial class Settings : ModuleView<SettingsModel>, ISettingsView, ISettingsControl
    {
        public event EventHandler GetSettings = (_, __) => { };
        public event EventHandler<SaveSettingsEventArgs> SaveSettings = (_, __) => { };

        public void LoadSettings()
        {
            // defer to presenter to set the model with any needed information
            GetSettings(this, EventArgs.Empty);
        }

        public void UpdateSettings()
        {
            // defer to the presenter to update the database based on our model
            SaveSettings(this, new SaveSettingsEventArgs(this.Page.IsValid, this.NameTextBox.Text, this.DescriptionTextBox.Text));
        }
    }
}