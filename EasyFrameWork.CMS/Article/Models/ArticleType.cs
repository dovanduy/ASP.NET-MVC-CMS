/* http://www.zkea.net/ Copyright 2016 ZKEASOFT http://www.zkea.net/licenses */
using Easy.Constant;
using Easy.MetaData;
using Easy.Models;

namespace Easy.Web.CMS.Article.Models
{
    [DataConfigure(typeof(ArtycleTypeMetaData))]
    public class ArticleType : EditorEntity
    {
        public int ID { get; set; }

        public int ParentID { get; set; }
    }
    class ArtycleTypeMetaData : DataViewMetaData<ArticleType>
    {
        protected override void DataConfigure()
        {
            DataTable("ArticleType");
            DataConfig(m => m.ID).AsIncreasePrimaryKey();
        }

        protected override void ViewConfigure()
        {
            ViewConfig(m => m.ID).AsHidden();
            ViewConfig(m => m.ParentID).AsHidden();
            ViewConfig(m => m.Title).AsTextBox().MaxLength(200).Required();
            ViewConfig(m => m.Status).AsDropDownList().DataSource(DicKeys.RecordStatus, SourceType.Dictionary);
        }
    }

}