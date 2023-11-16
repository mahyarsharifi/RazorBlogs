using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RazorBlog.Models
{
    public class CreateArticle
    {
        [Required(ErrorMessage = "عنوان مقاله اجباری است")]
        [DisplayName("عنوان")]
        public string Title { get; set; }

        [Required(ErrorMessage = "عکس مقاله اجباری است")]
        [DisplayName("مسیر عکس")]
        public string Picture { get; set; }

        [DisplayName("Alt عکس")]
        public string PictureAlt { get; set; }

        [DisplayName("Title عکس")]
        public string PictureTitle { get; set; }

        [Required(ErrorMessage = "توضیحات کوتاه مقاله اجباری است")]
        [DisplayName("توضیحات کوتاه")]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "متن مقاله اجباری است")]
        [DisplayName("متن مقاله")]
        public string Body { get; set; }
    }
}
