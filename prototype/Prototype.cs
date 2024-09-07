using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignCreational
{
    public interface IDocumentPrototype
    {
        IDocumentPrototype Clone();
        void ShowInfo();
    }
    internal class Book : IDocumentPrototype
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public IDocumentPrototype Clone()
        {
            return (IDocumentPrototype)this.MemberwiseClone();
        }
        public void ShowInfo()
        {
            Console.WriteLine("My book (Document) title " +
                Title + " with content " + Content);
        }

        public Book(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }

    internal class Resume : IDocumentPrototype
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public Resume(string name, string address, string phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }
        public IDocumentPrototype Clone()
        {
            return (IDocumentPrototype)this.MemberwiseClone();
        }
        public void ShowInfo()
        {
            Console.WriteLine("My resume (Document) name " +
                Name + " with address " + Address + " and phone " + Phone);
        }
    }
}