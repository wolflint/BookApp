using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BookApp
{
    public struct Books
    {
        public int book_id;
        public string title;
        public string author;
        public string subject;
    };
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DisplayJson();
            LoadBooks();
        }

        public void DisplayJson()
        {
            if (File.Exists(@"book.json"))
            {
            string json_text = File.ReadAllText(@"book.json");
            txtTest.Text = json_text;
            }
        }

        //public Books[] LoadBooks()
        public void LoadBooks()

        {
            //Books[] books;
            if (File.Exists(@"book.json"))
            {
                int line_count = File.ReadLines(@"book.json").Count();
                lblTotal.Text ="Total Saved Books: " + Convert.ToString(line_count);
                //return books;
            }
            else
            {
                lblTotal.Text = "Total Saved Books: 0";
            }
        }

        private void SavePressed(object sender, EventArgs e)
        {
            Books book; // declare new book

            // configure book specification
            book.title = inpTitle.Text;
            book.author = inpAuthor.Text;
            book.subject = inptSubject.Text;
            book.book_id = Convert.ToInt32(inpId.Text);

            string json = JsonConvert.SerializeObject(book);
            if (!File.Exists(@"book.json"))
            {
                File.AppendAllText(@"book.json", json);
            }
            else
            {
                File.AppendAllText(@"book.json", "\n" + json);
            }
            DisplayJson();
            LoadBooks();
        }
    }
}
