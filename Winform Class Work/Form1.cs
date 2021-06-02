using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Class_Work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            checkedListBox1.Items.AddRange(new object[]
                {
                "Action",
                "Comedy",
                "Drama"
            });
            checkedListBox2.Items.AddRange(new object[]
          {
                "SUV",
                "Sedan",
                "Coupe"
            });
            checkedListBox3.Items.AddRange(new object[]
     {
                "English",
                "Russian",
                "Turkish"
       });

        }
        string name;
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label1.Visible = false;
            dateTimePicker1.Visible = false;
            label2.Visible = false;
            checkedListBox1.Visible = true;
            checkedListBox2.Visible = true;
            checkedListBox3.Visible = true;
            button1.Visible = false;
            button2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            if (textBox1.Text != "")
            {
                User user = new User();

                name = textBox1.Text;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            checkedListBox1.Visible = false;
            checkedListBox2.Visible = false;
            checkedListBox3.Visible = false;
            button2.Visible = false;
            maskedTextBox1.Visible = true;
            textBox2.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Visible = false;
            textBox2.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            button4.Visible = false;
            label8.Visible = true;
            label9.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            button3.Visible = true;
        }
    }
}
