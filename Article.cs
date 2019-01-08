using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLesson
{
    public partial class Article
    {
        private string _title;
        private string _text;
        private string _author;
        private DateTime _creationDate;
        private Comment[] _comments;
        private static string _ownerName;

        //мод_доступа Назв_класса () {} 
        //генератор конструктора ctor

        static Article()
        {
            _ownerName = "Самиздат";
        }

        public Article()
        {
            _creationDate = DateTime.Now;
            _ownerName = "Самиздат";
        }
        //мод доступа:: возвращаемый_тип Имя (параметры){return знач_возвра_тип;}

        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string title)
        {
            _title = title;
        }
        public string GetText()
        {
            return _text;
        }

        public void SetText(string text)
        {
            _text = text;
        }
        public string GetAuthor()
        {
            return _title;
        }

        public void SetAuthor(string author)
        {
            _author = author;
        }
        public DateTime GetCreationDate()
        {
            return _creationDate;
        }

        public void SetCreationDate(DateTime creationDate)
        {
            _creationDate = creationDate;
        }
        public Comment[] GetComment()
        {
            return _comments;
        }

        public void SetComment(Comment[] comment)
        {
            _comments=comment;
        }
    }
}
