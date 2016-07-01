using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstGUI
{
    public partial class Form1 : Form
    {
        private Form2 secondForm;// 
      

        public Form1()
        {
            InitializeComponent();
            setAllComponentsUnvisible();
            loadDefaultPicture();
           // this.FormClosing += OnFormClosing;
        }


        private void button1_Click(object sender, EventArgs e)
        {

               DialogResult dialogResult = MessageBox.Show("Are you sure to close application", "Exit application", MessageBoxButtons.YesNo);
               if (dialogResult == DialogResult.Yes)
               {
                Application.Exit();
            }
               else if (dialogResult == DialogResult.No)
               {
                   //do something else
               }
       
        }

  


        private void setAllComponentsUnvisible()
        {
            label18.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label14.Visible = false;
            label13.Visible = false;
            label12.Visible = false;
            label11.Visible = false;
            label10.Visible = false;
            label9.Visible = false;
            label8.Visible = false;
            label7.Visible = false;
            label6.Visible = false;
            label5.Visible = false;
            textBox9.Visible = false;
            textBox8.Visible = false;
            textBox7.Visible = false;
            textBox6.Visible = false;
            textBox5.Visible = false;
            textBox4.Visible = false;
            textBox3.Visible = false;
            textBox2.Visible = false;
            textBox1.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            button2.Visible = false;
            button15.Visible = false;
            button16.Visible = false;


        }

        private void searchTextBoxesVisibleAndUnEditable()
        {
            textBox9.Visible = true;
            textBox8.Visible = true;
            textBox7.Visible = true;
            textBox6.Visible = true;
            textBox5.Visible = true;
            textBox4.Visible = true;
            textBox3.Visible = true;
            textBox2.Visible = true;
            textBox1.Visible = true;

            textBox9.ReadOnly = true; 
            textBox8.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox1.ReadOnly = true;
            loadDefaultPicture();
        }

        private void searchTextBoxesVisibleAndEditable()
        {
            textBox9.Visible = true;
            textBox8.Visible = true;
            textBox7.Visible = true;
            textBox6.Visible = true;
            textBox5.Visible = true;
            textBox4.Visible = true;
            textBox3.Visible = true;
            textBox2.Visible = true;
            textBox1.Visible = true;

            textBox9.ReadOnly = true;
            textBox8.ReadOnly = false;
            textBox7.ReadOnly = false;
            textBox6.ReadOnly = false;
            textBox5.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox1.ReadOnly = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        //designe for Search option components visibility
        private void searchVisibility()
        {
            label16.Visible = true;
            label15.Visible = true;
            label14.Visible = true;
            label13.Visible = true;
            label12.Visible = true;
            label11.Visible = true;
            label10.Visible = true;
            label9.Visible = true;
            label8.Visible = true;
            label7.Visible = true;
            label6.Visible = true;
            label5.Visible = true;


            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;

            button2.Visible = true;
        }

        //Search supplier button
        private void button12_Click(object sender, EventArgs e)
        {
            setAllComponentsUnvisible();
            label16.Text = "Search by Id,Name";
            label15.Text = "Search Supplier";
            label14.Text = "SupplierID";
            label13.Text = "Supplier Name";
            label12.Text = "Street";
            label11.Text = "Town";
            label10.Text = "County";
            label9.Text  = "Country";
            label8.Text  = "Post Code";
            label7.Text  = "Email";
            label6.Text  = "Contact";
            label5.Text  = "Products";

            searchTextBoxesVisibleAndUnEditable();

            searchVisibility();

            button2.Text = "Change Supplier Details";   
        }

        //Ad Supplier button
        private void button13_Click(object sender, EventArgs e)
        {
            setAllComponentsUnvisible();
            label16.Text = "Search by Id,Name";
            label15.Text = "Delete Supplier";
            label14.Text = "SupplierID";
            label13.Text = "Supplier Name";
            label12.Text = "Street";
            label11.Text = "Town";
            label10.Text = "County";
            label9.Text = "Country";
            label8.Text = "Post Code";
            label7.Text = "Email";
            label6.Text = "Contact";

            searchTextBoxesVisibleAndEditable();

            searchVisibility();
            label16.Visible = false;
            label5.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;

            button2.Text = "Add Supplier";
        }

        //Delete Supplier button
        private void button10_Click(object sender, EventArgs e)
        {
            setAllComponentsUnvisible();
            label16.Text = "Search by Id,Name";
            label15.Text = "Delete Supplier";
            label14.Text = "SupplierID";
            label13.Text = "Supplier Name";
            label12.Text = "Street";
            label11.Text = "Town";
            label10.Text = "County";
            label9.Text = "Country";
            label8.Text = "Post Code";
            label7.Text = "Email";
            label6.Text = "Contact";
           // label5.Text = "Products";

            searchTextBoxesVisibleAndUnEditable();

            searchVisibility();
            label5.Visible = false;
            comboBox1.Visible = false;

            button2.Text = "Delete Supplier";
        }

        //History button
        private void button11_Click(object sender, EventArgs e)
        {
            secondForm = new Form2();
            secondForm.Show();
            
        }


      

        //Search Customer button
        private void button6_Click(object sender, EventArgs e)
        {
            setAllComponentsUnvisible();
            label16.Text = "Search by Id,Name";
            label15.Text = "Search Customer";
            label14.Text = "CustomerID";
            label13.Text = "Customer Name";
            label12.Text = "Street";
            label11.Text = "Town";
            label10.Text = "County";
            label9.Text = "Country";
            label8.Text = "Post Code";
            label7.Text = "Email";
            label6.Text = "Contact";
            label5.Text = "Bougth Products";

            searchTextBoxesVisibleAndUnEditable();

            searchVisibility();

            button2.Text = "Change Customer Details";
        }

        //Add Customer button
        private void button14_Click(object sender, EventArgs e)
        {
            setAllComponentsUnvisible();
            label16.Text = "Search by Id,Name";
            label15.Text = "Search Customer";
            label14.Text = "CustomerID";
            label13.Text = "Customer Name";
            label12.Text = "Street";
            label11.Text = "Town";
            label10.Text = "County";
            label9.Text = "Country";
            label8.Text = "Post Code";
            label7.Text = "Email";
            label6.Text = "Contact";
            label5.Text = "Bougth Products";

            searchTextBoxesVisibleAndEditable();

            searchVisibility();
            label16.Visible = false;
            label5.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;

            button2.Text = "Add customer";
        }

        //Delete customer button
        private void button5_Click(object sender, EventArgs e)
        {
            setAllComponentsUnvisible();
            label16.Text = "Search by Id,Name";
            label15.Text = "Search Customer";
            label14.Text = "CustomerID";
            label13.Text = "Customer Name";
            label12.Text = "Street";
            label11.Text = "Town";
            label10.Text = "County";
            label9.Text = "Country";
            label8.Text = "Post Code";
            label7.Text = "Email";
            label6.Text = "Contact";
            label5.Text = "Bougth Products";

            searchTextBoxesVisibleAndUnEditable();

            searchVisibility();
            label5.Visible = false;
            comboBox1.Visible = false;

            button2.Text = "Delete customer";
        }
        //Search product button
        private void button8_Click(object sender, EventArgs e)
        {
            setAllComponentsUnvisible();
            label16.Text = "Search by Id,Name";
            label15.Text = "Search Product";
            label14.Text = "ProductID";
            label13.Text = "Product Name";
            label12.Text = "Supplier";
            label11.Text = "Type";
            label10.Text = "Size";
            label9.Text = "Price";
            label8.Text = "Colour";
            label7.Text = "Contact";

            searchTextBoxesVisibleAndUnEditable();

            searchVisibility();
            textBox1.Visible = false;
            label6.Visible = false;
            label5.Visible = false;
            comboBox1.Visible = false;
            button2.Text = "Change Product Details";
        }

        //Add Product button
        private void button4_Click(object sender, EventArgs e)
        {
            setAllComponentsUnvisible();
            label16.Text = "Search by Id,Name";
            label15.Text = "Delete Product";
            label14.Text = "ProductID";
            label13.Text = "Product Name";
            label12.Text = "Supplier";
            label11.Text = "Type";
            label10.Text = "Size";
            label9.Text = "Price";
            label8.Text = "Colour";
            label7.Text = "Contact";

            searchTextBoxesVisibleAndEditable();

            searchVisibility();
            label18.Text = "Select image";
            //label18.Visible = true;
            label16.Visible = false;
            textBox1.Visible = false;
            label6.Visible = false;
            label5.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            button15.Visible = true;
            button2.Text = "Add Product";
        }

        //Delete Product button
        private void button3_Click(object sender, EventArgs e)
        {
            setAllComponentsUnvisible();
            label16.Text = "Search by Id,Name";
            label15.Text = "Delete Product";
            label14.Text = "ProductID";
            label13.Text = "Product Name";
            label12.Text = "Supplier";
            label11.Text = "Type";
            label10.Text = "Size";
            label9.Text = "Price";
            label8.Text = "Colour";
            label7.Text = "Contact";

            searchTextBoxesVisibleAndUnEditable();

            searchVisibility();
            textBox1.Visible = false;
            label6.Visible = false;
            label5.Visible = false;
            comboBox1.Visible = false;
            button2.Text = "Delete Product";
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Delete User button
        private void button7_Click(object sender, EventArgs e)
        {
            setAllComponentsUnvisible();
            label16.Text = "Search by Id,Name";
            label15.Text = "Delete User";
            label14.Text = "User Name";
            label13.Text = "Password";

            label16.Visible = true; label16.Text = "Search by Id,Name";
            label15.Visible = true;
            label14.Visible = true;
            label13.Visible = true;

            textBox9.ReadOnly = true;
            textBox8.ReadOnly = true;
            textBox9.Visible = true;
            textBox8.Visible = true;

            comboBox2.Visible = true;
            comboBox3.Visible = true;

            button2.Text = "Delete User";
            button2.Visible = true;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            setAllComponentsUnvisible();
        }

        //Add user button
        private void button9_Click(object sender, EventArgs e)
        {
            setAllComponentsUnvisible();
            label15.Text = "Add User";
            label14.Text = "User Name";
            label13.Text = "Create Password";
            label12.Text = "Repeat Password";
            label11.Text = "Email";

            label15.Visible = true;
            label14.Visible = true;
            label13.Visible = true;
            label12.Visible = true;
            label11.Visible = true;

            textBox9.ReadOnly = false;
            textBox8.ReadOnly = false;
            textBox7.ReadOnly = false;
            textBox6.ReadOnly = false;
            textBox9.Visible = true;
            textBox8.Visible = true;
            textBox7.Visible = true;
            textBox6.Visible = true;

            button2.Text = "Create User";
            button2.Visible = true;
            button16.Visible = true;
        }

      

      

     
       

      

        private void label18_Click_1(object sender, EventArgs e)
        {

        }

        //File chooser to upload picture to server
        private void button15_Click(object sender, EventArgs e)
        {
            string path = "";
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                 path = file.FileName;
            }

            //copy file to server

          //  PictureBox1.SizeMode = SizeMode.Stretch
            pictureBox1.ImageLocation = path;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label18.Text = path;
            label18.Visible = true;
            Console.WriteLine("{0}",path);
        }

        private void loadDefaultPicture()
        {
            pictureBox1.Image = Properties.Resources.Default;
        }

   
        //Change user password
        private void button16_Click(object sender, EventArgs e)
        {
            setAllComponentsUnvisible();
            label15.Text = "Change Password";
            label14.Text = "User Name";
            label13.Text = "New Password";
            label12.Text = "Repeat Password";

            label15.Visible = true;
            label14.Visible = true;
            label13.Visible = true;
            label12.Visible = true;

            textBox9.ReadOnly = false;
            textBox9.ReadOnly = false;
            textBox9.ReadOnly = false;
            textBox9.Visible = true;
            textBox8.Visible = true;
            textBox7.Visible = true;

            button2.Text = "change";
            button2.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
