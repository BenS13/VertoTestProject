using System.Data;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VertoTestProject.Data;
using VertoTestProject.Models;

namespace VertoTestProject.Services
{
    //Define a Class as a Service that exposes methods to list, add and edit content
    //GetContent() retrives all content from DB for example
    //Uses the ContentContext Class to read and write to the DB
    //Registred for dependecy injection in "Pprogram.cs"
    public class ContentService
    {
        private readonly ContentContext _context = default!;

        //Inject the ContentContext class
        public ContentService(ContentContext context)
        {
            _context = context;
        }

        //Method to retrive all content from database
        public IList<Content> GetContent()
        {
            if (_context.Contents != null)//If content exists in the database
            {
                return _context.Contents.ToList();//Rertrive content from the database
            }
            return new List<Content>();//Else return an empty list of type Content
        }

        public Content GetContentById(int id)
        {
            if (_context.Contents != null)
            {
                Content singleContent = _context.Contents.Find(id);
                return singleContent;

            }
            return new Content();

        }


    }
}
