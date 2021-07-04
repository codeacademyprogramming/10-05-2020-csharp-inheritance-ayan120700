using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace ctors
{
    class Program
    {
        static void Main(string[] args)
        {
     
            Console.WriteLine("Enter keyword");
            string key = Console.ReadLine();
            DocumentProgram document = new DocumentProgram();
            
            switch (key)
            {
                case "basic":
                    document = new DocumentProgram();
                    Console.WriteLine("Document Program");
                    break;
                case "pro":
                    document = new ProDocumentProgram();
                    Console.WriteLine("ProDocument Program");
                    break;
                case "expert":
                    document = new ExpertDocument();
                    Console.WriteLine("ExpertDocument Program");
                    break;
                default:
                    Console.WriteLine("Sehv");
                    break;
            }

            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();

        }

    }
    class DocumentProgram
        {
            public void OpenDocument()
            {
                Console.WriteLine("Document opened");
            }
            public virtual void EditDocument()
            {
                Console.WriteLine("Can Edit in Pro and Expert versions");
            }
            public virtual void SaveDocument()
            {
                Console.WriteLine("Can Save in Pro and Expert versions");
            }

        }
        class ProDocumentProgram : DocumentProgram
        {
        public sealed override void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc");
        }
    }
        class ExpertDocument : ProDocumentProgram
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format");
        }
    }
    }

   
