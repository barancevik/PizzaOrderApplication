using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaorderApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        double Sizevalue;
        double PizzaValue;
        double Piece;



        private void Form1_Load(object sender, EventArgs e)
        {


            List<Size> sizes = new List<Size>()
            {
                new Size{Name="Small",Price=1},
                new Size{Name="Medium",Price=1.5},
                new Size{Name="Large",Price=2},
                new Size{Name="Maxi",Price=2.25}

            };
            CbSizes.DataSource = sizes;
            CbSizes.ValueMember = "Price";
            CbSizes.DisplayMember = "Name";


            List<Pizza> pizzas = new List<Pizza>()
            { 
                new Pizza{Name="Mexicano Pizza",Price=12},
                new Pizza{Name="Pizza With Cheddar Sauce",Price=14},
                new Pizza{Name="Extravaganzza",Price=13},
                new Pizza{Name="Callypso",Price=15},
                new Pizza{Name="Plenty Of Meat",Price=14},
                new Pizza{Name="Pastrami & Sausage",Price=16},
                new Pizza{Name="Margarita",Price=14},
                new Pizza{Name="Loves Mushrooms",Price=18},
                new Pizza{Name="loves Sausage",Price=18},

            };
            lstPizzas.DataSource = pizzas;
            lstPizzas.ValueMember = "Price";
            lstPizzas.DisplayMember = "Name";





        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                Piece = Convert.ToDouble(txtPieces.Text);
                txtAmount.Text = Convert.ToString((Sizevalue*PizzaValue)*Piece);

            }
            catch (Exception)
            {

                MessageBox.Show("Please enter quantity", "Error");
            }

        }

        private void CbSizes_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {
                Sizevalue = (double)CbSizes.SelectedValue;
            }
            catch (Exception)
            {

                MessageBox.Show("Please select size...");
            }

        }

        private void lstPizzas_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                PizzaValue = (double)lstPizzas.SelectedValue;
            }
            catch (Exception)
            {

                MessageBox.Show("Please select pizza");
            }

        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            string total = Convert.ToString(lblAmount.Text);
            MessageBox.Show("Total "+"" +txtPieces.Text + ""+ "pieces" +""+lblTotal.Text +""+"of your order");
            txtPieces.Clear();
            txtAmount.Clear();
            lblTotal.ResetText();


        }


        List<PizzaBasket> pizzass = new List<PizzaBasket>();
        double totalprices = 0.0;

        private void btnAddToBasket_Click(object sender, EventArgs e)
        {

            lstOrder.Items.Clear();
            string ingredients = "";

            foreach (CheckBox item in gbIngredients.Controls)
            {
                if (item.Checked)
                {
                    ingredients += item.Text + ",";
                }

            }
            string doughts = "";
            foreach (RadioButton item in gbDough.Controls)
            {
                if (radioButton1.Checked)
                {
                    doughts = radioButton1.Text;
                }
                else
                {
                    doughts = radioButton2.Text;
                }


            }

            try
            {
                PizzaBasket p = new PizzaBasket();
                p.Size = CbSizes.Text;
                p.Type = lstPizzas.Text;
                p.TotalPrice = Convert.ToDouble(txtAmount.Text);
                p.Ingredients = ingredients;
                p.Dough = doughts;
                p.pieces = Convert.ToDouble(txtPieces.Text);
                p.SizeValue = Sizevalue;
                p.PizzaValue = PizzaValue;
                p.DoughValue = doughts;
                pizzass.Add(p);

            }
            catch (Exception)
            {

                MessageBox.Show("Please enter the requested value");
            }

            foreach (PizzaBasket item in pizzass)
            {
                lstOrder.Items.Add(item.Size + "" + item.Type +"" + item.DoughValue + ""+ item.Ingredients + ""+item.pieces + " x " + "(" + item.SizeValue + " x "+ item.PizzaValue +")" + "=" + item.TotalPrice.ToString());
                totalprices += item.TotalPrice;

            }
            lblTotal.Text = totalprices.ToString() + "Pound";




        }
    }
}
