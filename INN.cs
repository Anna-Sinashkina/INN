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
using Interface;

namespace INNForm
{
    public partial class INN : Form,ITest
    {
        public INN()
        {
            InitializeComponent();
        }
        public string date = "22.01.1998";
        public string ID = "25154788";
        public string Seriya = "5877888";
        public string Inn = "545464561";
        public Dictionary<TextBox, string> value = new Dictionary<TextBox, string>();
        public void AddInformation(TextBox textbox, String text)
        {

            textbox.Text = text;

        }
        public Dictionary<TextBox, string> GetDictionary()
        {


            value.Add(DateInn, date);
            value.Add(IDInn, ID);
            value.Add(InnInForm, Seriya);
            value.Add(SeriyaInn, Inn);

            return value;

        }
        public void CompareString(TextBox u, String tt)
        {
            string path = @"C:\Users\guest2\Documents\Visual Studio 2015\TestProject\INNForm\INNForm\LogINNForm.txt";




            using (FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(file))

                {


                    if (u.Text != tt)
                    {


                        sw.WriteLine(" No converge the value:" + tt);
                    }

                    else
                    {
                        sw.WriteLine("Converge the value:" + tt);
                    }
                }
            }
        }
        
        public void doTest()
        {
            GetDictionary();
            foreach (KeyValuePair<TextBox, string> keyvalue in value)
            {
                AddInformation(keyvalue.Key, keyvalue.Value);
                
            }

         
            this.ShowDialog();
            foreach (KeyValuePair<TextBox, string> keyvalue in value)
            {
              
                CompareString(keyvalue.Key, keyvalue.Value);
            }

            this.Close();

        }

         

        private void INN_Load(object sender, EventArgs e)
        {

        }

        public void dotestModal()
        {
          
             




        }


    }
}
