using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackpacForm
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
            AddItems();
            ShowItems(items);
        }

        private List<Item> items;

        private void AddItems() {
            items = new List<Item>();
            items.Add(new Item("Книга", 1, 1500));
            items.Add(new Item("Бинокль", 3, 2000));
            items.Add(new Item("Аптечка", 4, 3000));
        }

        private void ShowItems(List<Item> _items) {
            double answerWeight = 0;
            double answerCost = 0;
            itemsListView.Items.Clear();

            foreach (Item i in _items) {
                itemsListView.Items.Add(new ListViewItem(new string[] { i.name, i.weigth.ToString(),
            i.price.ToString() }));
                answerWeight += i.weigth;
                answerCost += i.price;
            }
            AnswerWeight.Text = Convert.ToString(answerWeight);
            AnswerCost.Text = Convert.ToString(answerCost);
            AnswerBackpack.Text = Convert.ToString(weightTextBox.Text);
            AddName.Clear();
            AddWeight.Clear();
            AddCost.Clear();
        }

        private void button2_Click(object sender, EventArgs e) {
            ShowItems(items);      
        }

        private void button1_Click(object sender, EventArgs e) {
            if (weightTextBox.Text != "")
            {
                try { 
                Backpack bp = new Backpack(Convert.ToDouble(weightTextBox.Text));
                bp.MakeAllSets(items);
                List<Item> solve = bp.GetBestSet();
                    if (solve == null)
                    {
                        MessageBox.Show("Нет решения!");
                    }
                    else
                    {
                        itemsListView.Items.Clear();
                        ShowItems(solve);
                        MessageBox.Show("Решение приведено в таблице");
                    }
                }
                catch {
                    MessageBox.Show("Поле 'Максимальный вес рюкзака' не должно содержать текст!");
                }
            }
            else
            {
                MessageBox.Show("Поле 'Максимальный вес рюкзака' не заполнено!");
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if ((AddName.Text != "") && (AddWeight.Text != "") && (AddCost.Text != "")){
                try
                {
                    if (Convert.ToDouble(AddWeight.Text) >= 0)
                    {
                        if (Convert.ToDouble(AddCost.Text) >= 0)
                        {
                            Item NewItem = new Item(AddName.Text, Convert.ToDouble(AddWeight.Text), Convert.ToDouble(AddCost.Text));
                            items.Add(NewItem);
                            ShowItems(items);
                        }
                        else MessageBox.Show("Поле 'Стоимость' не может быть отрицательным!");
                    }
                    else MessageBox.Show("Поле 'Вес' не может быть отрицательным!");
                }
                catch {
                    MessageBox.Show("Одно из полей заполнено неверно!");
                }
            }
            else MessageBox.Show("Одно из полей не заполнено!");
        }

        private void DeleteLast_Click(object sender, EventArgs e)
        {
            if (items.Count > 0)
            {
                items.RemoveAt(items.Count - 1);
                ShowItems(items);
            }
            else MessageBox.Show("Список предметов пуст!");
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            if (items.Count > 0)
            {
                items.Clear();
                ShowItems(items);
            }
            else MessageBox.Show("Список предметов пуст!");
        }
    }
}
