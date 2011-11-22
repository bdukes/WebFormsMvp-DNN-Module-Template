namespace $Namespace$$safeprojectname$.Presenters
{
    using DotNetNuke.UI.Skins.Controls;
    using DotNetNuke.Web.Mvp;
    using Models;
    using Views;

    public class EditPresenter : ModulePresenter<IEditView, EditModel>
    {
        public EditPresenter(IEditView view) : base(view)
        {
            this.View.SaveClick += Save;
        }

        private void Save(object sender, SaveClickEventArgs args)
        {
            // pluck properties from args (save in database?)

            // update the view's model as appropriate (success or error message?)
	    this.ShowMessage(LocalizeString("Success.Text"), ModuleMessage.ModuleMessageType.GreenSuccess);
        }
    }
}
