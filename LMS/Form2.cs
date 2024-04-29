using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();

            listBox1.Items.Add(form3.Name);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Data.Load();
            foreach (Book book in Data.Books)
            {
                listBox1.Items.Add(book.Title);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                title.Text = "";
                author.Text = "";
                publsihingDate.Value = DateTime.Now;
            }
            else
            {
                Book book = Data.Books[listBox1.SelectedIndex];
                title.Text = book.Title;
                author.Text = book.Author;
                publsihingDate.Value = book.PublishDate;
            }
        }

        private void addBook(object sender, EventArgs e)
        {
            Book book = new Book(title.Text, author.Text, publsihingDate.Value);
            Data.AddBook(book);
            listBox1.Items.Add(book.Title);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Data.Save();
        }
    }
}
