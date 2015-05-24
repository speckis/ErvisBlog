namespace ErvisBlog.Migrations
{
    using ErvisBlog.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ErvisBlog.Models.ArticleDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ErvisBlog.Models.ArticleDBContext context)
        {
            context.Articles.AddOrUpdate(i => i.Name,
                new Article
                {
                    Name = "E.Joseph Cossman",
                    Text = "The best way to remember your wife's birthday is to forget it once."
                },
                 new Article
                {
                    Name = "Bill Cosby",
                    Text = "Gray hair is God's graffiti."
                },
                 new Article
                {
                    Name = "Walter Mattbau",
                    Text = "My doctor gave me six months to live, but when I couldn't pay the bill, he gave me six months more."
                },
                 new Article
                {
                    Name = "Steven Pearl",
                    Text = "I can't believe that out of a hundred thousand sperm, you were the quickest."
                },
                 new Article
                {
                    Name = "Michel De Montaigne",
                    Text = "A good marriage would be between a blind wife and a deaf husband."
                },
                 new Article
                {
                    Name = "Les Dawson",
                    Text = "My wife is a sex object - every time I ask for sex, she objects."
                });

        }
    }
}
