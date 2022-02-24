
namespace BackpacForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemsListView = new System.Windows.Forms.ListView();
            this.Название = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Вес = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Стоимость = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddName = new System.Windows.Forms.TextBox();
            this.AddWeight = new System.Windows.Forms.TextBox();
            this.AddCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteLast = new System.Windows.Forms.Button();
            this.DeleteAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AnswerWeight = new System.Windows.Forms.Label();
            this.AnswerCost = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AnswerBackpack = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemsListView
            // 
            this.itemsListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.itemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Название,
            this.Вес,
            this.Стоимость});
            this.itemsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.itemsListView.HideSelection = false;
            this.itemsListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.itemsListView.LabelWrap = false;
            this.itemsListView.Location = new System.Drawing.Point(12, 12);
            this.itemsListView.Name = "itemsListView";
            this.itemsListView.Size = new System.Drawing.Size(499, 405);
            this.itemsListView.TabIndex = 0;
            this.itemsListView.UseCompatibleStateImageBehavior = false;
            this.itemsListView.View = System.Windows.Forms.View.Details;
            // 
            // Название
            // 
            this.Название.Text = "Название";
            this.Название.Width = 176;
            // 
            // Вес
            // 
            this.Вес.Text = "Вес";
            this.Вес.Width = 145;
            // 
            // Стоимость
            // 
            this.Стоимость.Text = "Стоимость";
            this.Стоимость.Width = 172;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Максимальный вес рюкзака:";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(703, 27);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(76, 20);
            this.weightTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(575, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Решить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Показать исходные данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(196, 67);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddName
            // 
            this.AddName.Location = new System.Drawing.Point(0, 41);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(131, 20);
            this.AddName.TabIndex = 6;
            // 
            // AddWeight
            // 
            this.AddWeight.Location = new System.Drawing.Point(137, 41);
            this.AddWeight.Name = "AddWeight";
            this.AddWeight.Size = new System.Drawing.Size(69, 20);
            this.AddWeight.TabIndex = 7;
            // 
            // AddCost
            // 
            this.AddCost.Location = new System.Drawing.Point(212, 41);
            this.AddCost.Name = "AddCost";
            this.AddCost.Size = new System.Drawing.Size(62, 20);
            this.AddCost.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Вес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Стоимость";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AddWeight);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddCost);
            this.groupBox1.Location = new System.Drawing.Point(517, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить предмет";
            // 
            // DeleteLast
            // 
            this.DeleteLast.Location = new System.Drawing.Point(11, 19);
            this.DeleteLast.Name = "DeleteLast";
            this.DeleteLast.Size = new System.Drawing.Size(122, 23);
            this.DeleteLast.TabIndex = 13;
            this.DeleteLast.Text = "Удалить последний";
            this.DeleteLast.UseVisualStyleBackColor = true;
            this.DeleteLast.Click += new System.EventHandler(this.DeleteLast_Click);
            // 
            // DeleteAll
            // 
            this.DeleteAll.Location = new System.Drawing.Point(164, 19);
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.Size = new System.Drawing.Size(98, 23);
            this.DeleteAll.TabIndex = 14;
            this.DeleteAll.Text = "Удалить все";
            this.DeleteAll.UseVisualStyleBackColor = true;
            this.DeleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteLast);
            this.groupBox2.Controls.Add(this.DeleteAll);
            this.groupBox2.Location = new System.Drawing.Point(517, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 55);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Удалить предмет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Общий вес:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Общая стоимость:";
            // 
            // AnswerWeight
            // 
            this.AnswerWeight.AutoSize = true;
            this.AnswerWeight.Location = new System.Drawing.Point(176, 26);
            this.AnswerWeight.Name = "AnswerWeight";
            this.AnswerWeight.Size = new System.Drawing.Size(10, 13);
            this.AnswerWeight.TabIndex = 18;
            this.AnswerWeight.Text = "-";
            // 
            // AnswerCost
            // 
            this.AnswerCost.AutoSize = true;
            this.AnswerCost.Location = new System.Drawing.Point(176, 57);
            this.AnswerCost.Name = "AnswerCost";
            this.AnswerCost.Size = new System.Drawing.Size(10, 13);
            this.AnswerCost.TabIndex = 19;
            this.AnswerCost.Text = "-";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AnswerBackpack);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.AnswerCost);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.AnswerWeight);
            this.groupBox3.Location = new System.Drawing.Point(534, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 111);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Общий ответ";
            // 
            // AnswerBackpack
            // 
            this.AnswerBackpack.AutoSize = true;
            this.AnswerBackpack.Location = new System.Drawing.Point(176, 86);
            this.AnswerBackpack.Name = "AnswerBackpack";
            this.AnswerBackpack.Size = new System.Drawing.Size(10, 13);
            this.AnswerBackpack.TabIndex = 21;
            this.AnswerBackpack.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Максимальный вес рюкзака:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 423);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Показать таблицу";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemsListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView itemsListView;
        private System.Windows.Forms.ColumnHeader Название;
        private System.Windows.Forms.ColumnHeader Вес;
        private System.Windows.Forms.ColumnHeader Стоимость;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AddName;
        private System.Windows.Forms.TextBox AddWeight;
        private System.Windows.Forms.TextBox AddCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteLast;
        private System.Windows.Forms.Button DeleteAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label AnswerWeight;
        private System.Windows.Forms.Label AnswerCost;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label AnswerBackpack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
    }
}

