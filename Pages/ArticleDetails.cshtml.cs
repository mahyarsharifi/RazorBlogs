using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBlog.Models;

namespace RazorBlog.Pages
{
    public class ArticleDetailsModel : PageModel
    {
        public ArticleViewModel Article { get; set; }
        private readonly BlogContext _context;

        public ArticleDetailsModel(BlogContext context)
        {
            _context = context;
        }

        public void OnGet(int id, string title)
        {
            Article = _context.Articles.Select(x => new ArticleViewModel
            {
                Id = x.Id,
                Picture = x.Picture,
                Title = x.Title,
                Body = x.Body,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
            }).FirstOrDefault(x => x.Id == id);
        }
    }
}
