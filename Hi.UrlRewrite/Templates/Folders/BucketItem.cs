using Sitecore.Data.Items;

namespace Hi.UrlRewrite.Templates.Folders
{
    public partial class BucketItem : CustomItem
    {

        public static readonly string TemplateId = "{ADB6CA4F-03EF-4F47-B9AC-9CE2BA53FF97}";


        #region Boilerplate CustomItem Code

        public BucketItem(Item innerItem)
            : base(innerItem)
        {

        }

        public static implicit operator BucketItem(Item innerItem)
        {
            return innerItem != null ? new BucketItem(innerItem) : null;
        }

        public static implicit operator Item(BucketItem customItem)
        {
            return customItem != null ? customItem.InnerItem : null;
        }

        #endregion //Boilerplate CustomItem Code


        #region Field Instance Methods


        #endregion //Field Instance Methods
    }
}