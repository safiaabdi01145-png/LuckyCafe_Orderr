using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace LuckyCafe_Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomer_Name.Text = "";
            txtQuantity.Text = "";
            Order_List.Text = "";
            lblPrice.Text = "";
            lblLucky_Message.Text = "";
            chkStudent_Member.Checked = false;
            rdoTea.Checked = false;
            rdoJuice.Checked = false;
            rdoCoffee.Checked = false;
            Order_List.Items.Clear();
            lblDiscount.Text = "";
            txtCustomer_Name.Focus();
        }



        private void btnCalculate_Click(object sender, EventArgs e)
        {    if (txtCustomer_Name.Text == "")
            {
                MessageBox.Show("Macaamiilka Magaciisa Fadlann .");
            }
            else if (!rdoTea.Checked && !rdoJuice.Checked && !rdoCoffee.Checked)
            {
                MessageBox.Show("Dooro (Drink Type ka)");
            }
            else if (txtQuantity.Text == "")
            {
                MessageBox.Show(" (quantity ) Or Meeqo Dalab aa Rabty Sheeg ");
            }
            else
            {
                try
                {
                    

                    String name = txtCustomer_Name.Text;
                    int qty = int.Parse(txtQuantity.Text);
                    double price = 0;
                    String drink = "";

                    if (rdoCoffee.Checked)
                    {
                        price = 2;
                        drink = "Coffee";
                    }
                    else if (rdoTea.Checked)
                    {
                        price = 1;
                        drink = "Tea";
                    }
                    else if (rdoJuice.Checked)
                    {
                        price = 3;
                        drink = "Juice";
                    }

                    Order_List.Items.Clear();

                    Random rand = new Random();
                    int lucy = 0;

                    for (int i = 1; i <= qty; i++)
                    {
                        lucy = rand.Next(1, 51);
                        Order_List.Items.Add(name + " - " + drink + " - " + " Lucky Number Is : " + lucy);
                    }
                    double total = price * qty;
                    double beforTotal = price * qty;
                    double discount = 0;


                    lblPrice.Text = "Total Is: $" + total;
                    if (chkStudent_Member.Checked)
                    {
                        discount = beforTotal * 0.10;

                    }
                    double afterTotal = beforTotal - discount;


                    string discountmsge =
                        chkStudent_Member.Checked ? "Member Discount: 10% " : "Member Discount: 0% ";
                    lblDiscount.Text = "Total Befor Discount: $" + beforTotal.ToString("0.00") + "\n" +
                    "Total After Discount: $" + afterTotal.ToString("0.00") +
                    "\n" + "Member Discount 10%";

                    if (lucy == 7 || lucy == 17)
                    {
                        lblLucky_Message.Text = "You Got a Free Cookie !";
                    }
                    else
                    {
                        lblLucky_Message.Text = "No Prize This Time .";

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSave_File_Click(object sender, EventArgs e)
        {
            if (Order_List.Items.Count > 0)
            {

                DialogResult dr = saveFileDialog1.ShowDialog(); 
            if (dr == DialogResult.OK) { 

                try
                {

                    StreamWriter regesterFile;
                    regesterFile = File.AppendText(saveFileDialog1.FileName + "txt");
                    for (int i = 0; i < Order_List.Items.Count; i++)
                    {
                        regesterFile.WriteLine(Order_List.Items[i].ToString());

                    }

                    regesterFile.Close();

                    MessageBox.Show("File Has Been Registred Successfully !");



                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }

            }
          }
            else
            {
                MessageBox.Show("Loser Ado Order Samenin Save Masamen kartid !");
            }

        }

        private void btnLoad_FromFile_Click(object sender, EventArgs e)
        {
           

                DialogResult dr = openFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {

                    try
                    {
                        Order_List.Items.Clear();

                        StreamReader readFile;
                        readFile = File.OpenText(openFileDialog1.FileName); 

                        string line;

                        while ((line = readFile.ReadLine()) != null)
                        {
                            Order_List.Items.Add(line);
                        }

                        readFile.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                   
                }
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
    }

