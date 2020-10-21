using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel_FlowPanel
{
    public partial class FlowPanelDemo : Form
    {

        List<Drink> list_drink = new List<Drink>();
        DataTable invoice = new DataTable();
        private int SelectedRowIndex;
        public FlowPanelDemo()
        {
            InitializeComponent();

            list_drink.Add(new Drink(1, "tra sua", 12000));
            list_drink.Add(new Drink(2, "tea", 15000));
            list_drink.Add(new Drink(3, "tra tac", 19000));
            list_drink.Add(new Drink(4, "tra chanh", 32000));
            list_drink.Add(new Drink(5, "tra buoi", 55000));

            invoice.Columns.Add("ID",typeof(int));
            invoice.Columns.Add("Name",typeof(string));
            invoice.Columns.Add("Price",typeof(int));
            invoice.Columns.Add("Amount",typeof(int));
            invoice.Columns.Add("Total",typeof(int));

            dataGridView_invoice.DataSource = invoice;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "hello";
            myFlowLayoutPanel.Controls.Add(btn);
        }

        //------------------------- render menu button 


        private void button_render_mybtn_Click(object sender, EventArgs e)
        { 
            foreach(var drink in list_drink)
            {
                MyDrinkButton drinkButton = new MyDrinkButton(drink);
                drinkButton.Click += DrinkButton_Click;
                drinkButton.Text = drinkButton.MyDrink.Name;
                myFlowLayoutPanel.Controls.Add(drinkButton);
            }
        }

        private void DrinkButton_Click(object sender, EventArgs e)
        {
            MyDrinkButton drinkbtn = ((MyDrinkButton)sender);
            int drink_id = drinkbtn.MyDrink.Id;

            //check item in invoice, if exist increase amount add update total
            for (int index =0;index<invoice.Rows.Count;index++)
            {
                if (((int)invoice.Rows[index]["Id"]) == drink_id)
                {
                    invoice.Rows[index]["Amount"] = ((int)invoice.Rows[index]["Amount"]) + 1;
                    invoice.Rows[index]["Total"] = ((int)invoice.Rows[index]["Price"]) * ((int)invoice.Rows[index]["Amount"]);
                    return;
                }
            }
            


            invoice.Rows.Add(drinkbtn.MyDrink.Id, drinkbtn.MyDrink.Name, drinkbtn.MyDrink.Price, 1, drinkbtn.MyDrink.Price);
            dataGridView_invoice.DataSource = invoice;
       
        }

        private void dataGridView_invoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            MessageBox.Show(selectedRowIndex+"");
            //int selectedId = Convert.ToInt32(dataGridView_invoice.Rows[selectedRowIndex].Cells[0]);

            invoice.Rows[selectedRowIndex]["Total"] = ((int)invoice.Rows[selectedRowIndex]["Price"]) * ((int)invoice.Rows[selectedRowIndex]["Amount"]);

            dataGridView_invoice.DataSource = invoice;


        }
    }

    public class Drink
    {
        int id;
        string name;
        int price;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }

        public Drink(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
    }
    public class MyButton : Button
    {
        private string btnName;
        private int btnPrice;
        private int ID;

        public string BtnName { get => btnName; set => btnName = value; }
        public int BtnPrice { get => btnPrice; set => btnPrice = value; }

        public MyButton(string btnName, int btnPrice)
        {

        }
    }

    public class MyDrinkButton : Button
    {
        private Drink myDrink;


        public MyDrinkButton(Drink drink)
        {
            this.MyDrink = drink;
        }

        public Drink MyDrink { get => myDrink; set => myDrink = value; }
    }

    public class MyButtonGeneric : Button
    {
        private string btnName;
        private int btnPrice;
        private int ID;

        public string BtnName { get => btnName; set => btnName = value; }
        public int BtnPrice { get => btnPrice; set => btnPrice = value; }

        public MyButtonGeneric(string btnName, int btnPrice)
        {
            this.btnName = btnName;
            this.btnPrice = btnPrice;
        }
    }
}
