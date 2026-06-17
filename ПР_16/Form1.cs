using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PZ
{
    using System;
    using System.Windows.Forms;
    using System.Xml.Linq;

    public partial class Form1 : Form
    {

        private Books[] inventory = new Books[1];
            private int bookCount = 0;

            public Form1()
            {
                InitializeComponent();
            }

           
            private void btnAdd_Click(object sender, EventArgs e)
            {
                try
                {
          
                 

                    string name = txtName.Text;
                    double price = double.Parse(txtPrice.Text);
                    int kol = int.Parse(txtQuantity.Text);

              
                    Books newBook = new Books(name, price);
                    newBook.Kol = kol;

                Array.Resize(ref inventory, bookCount + 1);
                    inventory[bookCount] = newBook;
                    bookCount++;

                    txtLog.Text = $"{newBook.Print()} Total: {newBook.Total()}";

                  
                    ClearInputs();
                }
                catch (Exception ex)
                {
                
                    MessageBox.Show("Ошибка заполнения: " + ex.Message);
                }
            }

           
            private void ClearInputs()
            {
                txtName.Clear();
                txtPrice.Clear();
                txtQuantity.Clear();
            
                txtName.Focus();
            }

         
            private void btnShowAll_Click(object sender, EventArgs e)
            {
             
                WarehouseHelper.ShowFullInfo(inventory, bookCount, listBoxStore, lblTotalSum);
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
