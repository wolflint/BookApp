using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BookApp
{
    struct Books
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;
    };
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SavePressed(object sender, EventArgs e)
        {
            Books book; // declare new book

            // configure book specification
            book.title = inpTitle.Text;
            book.author = inpAuthor.Text;
            book.subject = inptSubject.Text;
            book.book_id = Convert.ToInt32(inpId.Text);

            var json = JsonConvert.SerializeObject(book);
            txtTest.Text = json;
        }
    }
}
