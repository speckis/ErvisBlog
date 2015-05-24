using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ErvisBlog.Models
{
    public class Article
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
    }

    public class ArticleDBContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
    }
}