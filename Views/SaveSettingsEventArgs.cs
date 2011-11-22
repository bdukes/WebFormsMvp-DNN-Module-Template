namespace $Namespace$$safeprojectname$.Views
{
    using System;

    public class SaveSettingsEventArgs : EventArgs
    {
        public SaveSettingsEventArgs(bool isValid, string name, string description)
        {
            this.IsValid = isValid;
            this.Name = name;
            this.Description = description;
        }
        
        public bool IsValid { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
    }
}