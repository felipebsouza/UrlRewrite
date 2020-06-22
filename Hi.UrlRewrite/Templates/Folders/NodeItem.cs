using Sitecore.Data.Items;

namespace Hi.UrlRewrite.Templates.Folders
{
    public partial class NodeItem : CustomItem
    {

        public static readonly string TemplateId = "{239F9CF4-E5A0-44E0-B342-0F32CD4C6D8B}";


        #region Boilerplate CustomItem Code

        public NodeItem(Item innerItem)
            : base(innerItem)
        {

        }

        public static implicit operator NodeItem(Item innerItem)
        {
            return innerItem != null ? new NodeItem(innerItem) : null;
        }

        public static implicit operator Item(NodeItem customItem)
        {
            return customItem != null ? customItem.InnerItem : null;
        }

        #endregion //Boilerplate CustomItem Code


        #region Field Instance Methods


        #endregion //Field Instance Methods
    }
}