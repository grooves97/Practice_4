using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Article article = new Article();
            article.SetAuthor("Админ");
            article.SetText("уафцареншлн");

            article.AddAuthors("Модератор1", "Модератор2");

            string numberAssString = "25";

            int number;
            if(int.TryParse(numberAssString,out number))
            {
                //работаем с числом
            }

            int[] numbers = { 1, 2, 3, 4, 5 };
            Array.Resize<int>(ref numbers, 10);
        }
    }
    partial class Article
    {
        public string ReturnData()
        {
            return $"{_author} {_text} {_title}";
        }
        public void AddAuthors(params string[] authors)
        {
            foreach(var author in authors)
            {
                _author += " " + authors;
            }
            _author.Trim();
        }

        public bool IsAuthorSet(ref string author)
        {
            if (String.IsNullOrEmpty(_author))
            {
                return false;
            }
            author = _author;
            return true;
        }
    }
}
