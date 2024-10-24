/*
  Team 13 Ahjeossi's
  Group Members: Everest Law, Patrick Heard, Quinton Mclain
  Pizza Place Part 2

  This program is a continuation of the My Pizza Place assignment. 
  The program uses forms, for a user to select different pizza options and 
  adds the price of everything together. 
  Form1 passes data to form2 for order summary
*/

namespace pizza
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.smallRadio = new System.Windows.Forms.RadioButton();
            this.mediumRadio = new System.Windows.Forms.RadioButton();
            this.largeRadio = new System.Windows.Forms.RadioButton();
            this.XLRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Breadsticks = new System.Windows.Forms.CheckBox();
            this.wings = new System.Windows.Forms.CheckBox();
            this.salad = new System.Windows.Forms.CheckBox();
            this.pasta = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pepCheck = new System.Windows.Forms.CheckBox();
            this.mushrooms = new System.Windows.Forms.CheckBox();
            this.onions = new System.Windows.Forms.CheckBox();
            this.sausage = new System.Windows.Forms.CheckBox();
            this.bacon = new System.Windows.Forms.CheckBox();
            this.olive = new System.Windows.Forms.CheckBox();
            this.peppers = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.pizzaSize = new System.Windows.Forms.Label();
            this.Toppings = new System.Windows.Forms.Label();
            this.cheese = new System.Windows.Forms.Label();
            this.sides = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.sauce = new System.Windows.Forms.Label();
            this.orderSummary = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(373, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team Ahjeossi\'s Pizza Place";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // smallRadio
            // 
            this.smallRadio.AutoSize = true;
            this.smallRadio.Location = new System.Drawing.Point(6, 19);
            this.smallRadio.Name = "smallRadio";
            this.smallRadio.Size = new System.Drawing.Size(86, 17);
            this.smallRadio.TabIndex = 1;
            this.smallRadio.TabStop = true;
            this.smallRadio.Text = "Small ($7.00)";
            this.smallRadio.UseVisualStyleBackColor = true;
            this.smallRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // mediumRadio
            // 
            this.mediumRadio.AutoSize = true;
            this.mediumRadio.Location = new System.Drawing.Point(6, 53);
            this.mediumRadio.Name = "mediumRadio";
            this.mediumRadio.Size = new System.Drawing.Size(104, 17);
            this.mediumRadio.TabIndex = 2;
            this.mediumRadio.TabStop = true;
            this.mediumRadio.Text = "Medium ($10.00)";
            this.mediumRadio.UseVisualStyleBackColor = true;
            this.mediumRadio.CheckedChanged += new System.EventHandler(this.mediumRadio_CheckedChanged);
            // 
            // largeRadio
            // 
            this.largeRadio.AutoSize = true;
            this.largeRadio.Location = new System.Drawing.Point(6, 85);
            this.largeRadio.Name = "largeRadio";
            this.largeRadio.Size = new System.Drawing.Size(94, 17);
            this.largeRadio.TabIndex = 3;
            this.largeRadio.TabStop = true;
            this.largeRadio.Text = "Large ($12.00)";
            this.largeRadio.UseVisualStyleBackColor = true;
            this.largeRadio.CheckedChanged += new System.EventHandler(this.largeRadio_CheckedChanged);
            // 
            // XLRadio
            // 
            this.XLRadio.AutoSize = true;
            this.XLRadio.Location = new System.Drawing.Point(6, 120);
            this.XLRadio.Name = "XLRadio";
            this.XLRadio.Size = new System.Drawing.Size(80, 17);
            this.XLRadio.TabIndex = 4;
            this.XLRadio.TabStop = true;
            this.XLRadio.Text = "XL ($14.00)";
            this.XLRadio.UseVisualStyleBackColor = true;
            this.XLRadio.CheckedChanged += new System.EventHandler(this.XLRadio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.smallRadio);
            this.groupBox1.Controls.Add(this.XLRadio);
            this.groupBox1.Controls.Add(this.mediumRadio);
            this.groupBox1.Controls.Add(this.largeRadio);
            this.groupBox1.Location = new System.Drawing.Point(39, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 167);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // Breadsticks
            // 
            this.Breadsticks.AutoSize = true;
            this.Breadsticks.Location = new System.Drawing.Point(19, 29);
            this.Breadsticks.Name = "Breadsticks";
            this.Breadsticks.Size = new System.Drawing.Size(117, 17);
            this.Breadsticks.TabIndex = 6;
            this.Breadsticks.Text = "Breadsticks ($6.99)";
            this.Breadsticks.UseVisualStyleBackColor = true;
            this.Breadsticks.CheckedChanged += new System.EventHandler(this.breadsticks_CheckedChanged);
            // 
            // wings
            // 
            this.wings.AutoSize = true;
            this.wings.Location = new System.Drawing.Point(19, 52);
            this.wings.Name = "wings";
            this.wings.Size = new System.Drawing.Size(98, 17);
            this.wings.TabIndex = 7;
            this.wings.Text = "Wings ($12.00)";
            this.wings.UseVisualStyleBackColor = true;
            this.wings.CheckedChanged += new System.EventHandler(this.wings_CheckedChanged);
            // 
            // salad
            // 
            this.salad.AutoSize = true;
            this.salad.Location = new System.Drawing.Point(19, 75);
            this.salad.Name = "salad";
            this.salad.Size = new System.Drawing.Size(131, 17);
            this.salad.TabIndex = 8;
            this.salad.Text = "Caesar Salad ($10.99)";
            this.salad.UseVisualStyleBackColor = true;
            this.salad.CheckedChanged += new System.EventHandler(this.salad_CheckedChanged);
            // 
            // pasta
            // 
            this.pasta.AutoSize = true;
            this.pasta.Location = new System.Drawing.Point(19, 98);
            this.pasta.Name = "pasta";
            this.pasta.Size = new System.Drawing.Size(155, 17);
            this.pasta.TabIndex = 9;
            this.pasta.Text = "Over-Baked Pasta ($14.99)";
            this.pasta.UseVisualStyleBackColor = true;
            this.pasta.CheckedChanged += new System.EventHandler(this.pasta_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Breadsticks);
            this.groupBox2.Controls.Add(this.pasta);
            this.groupBox2.Controls.Add(this.wings);
            this.groupBox2.Controls.Add(this.salad);
            this.groupBox2.Location = new System.Drawing.Point(39, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 134);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // pepCheck
            // 
            this.pepCheck.AutoSize = true;
            this.pepCheck.Location = new System.Drawing.Point(44, 27);
            this.pepCheck.Name = "pepCheck";
            this.pepCheck.Size = new System.Drawing.Size(74, 17);
            this.pepCheck.TabIndex = 11;
            this.pepCheck.Text = "Pepperoni";
            this.pepCheck.UseVisualStyleBackColor = true;
            this.pepCheck.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // mushrooms
            // 
            this.mushrooms.AutoSize = true;
            this.mushrooms.Location = new System.Drawing.Point(44, 60);
            this.mushrooms.Name = "mushrooms";
            this.mushrooms.Size = new System.Drawing.Size(80, 17);
            this.mushrooms.TabIndex = 12;
            this.mushrooms.Text = "Mushrooms";
            this.mushrooms.UseVisualStyleBackColor = true;
            this.mushrooms.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // onions
            // 
            this.onions.AutoSize = true;
            this.onions.Location = new System.Drawing.Point(44, 92);
            this.onions.Name = "onions";
            this.onions.Size = new System.Drawing.Size(59, 17);
            this.onions.TabIndex = 13;
            this.onions.Text = "Onions";
            this.onions.UseVisualStyleBackColor = true;
            this.onions.CheckedChanged += new System.EventHandler(this.onions_CheckedChanged);
            // 
            // sausage
            // 
            this.sausage.AutoSize = true;
            this.sausage.Location = new System.Drawing.Point(154, 26);
            this.sausage.Name = "sausage";
            this.sausage.Size = new System.Drawing.Size(68, 17);
            this.sausage.TabIndex = 14;
            this.sausage.Text = "Sausage";
            this.sausage.UseVisualStyleBackColor = true;
            this.sausage.CheckedChanged += new System.EventHandler(this.sausage_CheckedChanged);
            // 
            // bacon
            // 
            this.bacon.AutoSize = true;
            this.bacon.Location = new System.Drawing.Point(154, 60);
            this.bacon.Name = "bacon";
            this.bacon.Size = new System.Drawing.Size(57, 17);
            this.bacon.TabIndex = 15;
            this.bacon.Text = "Bacon";
            this.bacon.UseVisualStyleBackColor = true;
            this.bacon.CheckedChanged += new System.EventHandler(this.bacon_CheckedChanged);
            // 
            // olive
            // 
            this.olive.AutoSize = true;
            this.olive.Location = new System.Drawing.Point(154, 92);
            this.olive.Name = "olive";
            this.olive.Size = new System.Drawing.Size(85, 17);
            this.olive.TabIndex = 16;
            this.olive.Text = "Black Olives";
            this.olive.UseVisualStyleBackColor = true;
            this.olive.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // peppers
            // 
            this.peppers.AutoSize = true;
            this.peppers.Location = new System.Drawing.Point(88, 128);
            this.peppers.Name = "peppers";
            this.peppers.Size = new System.Drawing.Size(97, 17);
            this.peppers.TabIndex = 17;
            this.peppers.Text = "Green Peppers";
            this.peppers.UseVisualStyleBackColor = true;
            this.peppers.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox3.Controls.Add(this.sausage);
            this.groupBox3.Controls.Add(this.peppers);
            this.groupBox3.Controls.Add(this.pepCheck);
            this.groupBox3.Controls.Add(this.olive);
            this.groupBox3.Controls.Add(this.mushrooms);
            this.groupBox3.Controls.Add(this.bacon);
            this.groupBox3.Controls.Add(this.onions);
            this.groupBox3.Location = new System.Drawing.Point(301, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 167);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Gorgonzola",
            "Mozzarella",
            "Provolone",
            "American",
            "Cheddar"});
            this.comboBox1.Location = new System.Drawing.Point(21, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Buffalo Sauce",
            "Marinara",
            "Blue Cheese",
            "Ranch"});
            this.comboBox2.Location = new System.Drawing.Point(21, 105);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Location = new System.Drawing.Point(639, 61);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 167);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Sauces";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Cheese";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.Red;
            this.totalLabel.Location = new System.Drawing.Point(4, 16);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(62, 24);
            this.totalLabel.TabIndex = 22;
            this.totalLabel.Text = "Total:";
            this.totalLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.totalLabel);
            this.groupBox5.Location = new System.Drawing.Point(301, 277);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(212, 113);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            // 
            // pizzaSize
            // 
            this.pizzaSize.AutoSize = true;
            this.pizzaSize.Location = new System.Drawing.Point(17, 31);
            this.pizzaSize.Name = "pizzaSize";
            this.pizzaSize.Size = new System.Drawing.Size(58, 13);
            this.pizzaSize.TabIndex = 24;
            this.pizzaSize.Text = "Pizza Size:";
            // 
            // Toppings
            // 
            this.Toppings.AutoSize = true;
            this.Toppings.Location = new System.Drawing.Point(17, 54);
            this.Toppings.Name = "Toppings";
            this.Toppings.Size = new System.Drawing.Size(54, 13);
            this.Toppings.TabIndex = 25;
            this.Toppings.Text = "Toppings:";
            // 
            // cheese
            // 
            this.cheese.AutoSize = true;
            this.cheese.Location = new System.Drawing.Point(17, 81);
            this.cheese.Name = "cheese";
            this.cheese.Size = new System.Drawing.Size(46, 13);
            this.cheese.TabIndex = 26;
            this.cheese.Text = "Cheese:";
            // 
            // sides
            // 
            this.sides.AutoSize = true;
            this.sides.Location = new System.Drawing.Point(17, 127);
            this.sides.Name = "sides";
            this.sides.Size = new System.Drawing.Size(36, 13);
            this.sides.TabIndex = 27;
            this.sides.Text = "Sides:";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox6.Controls.Add(this.sauce);
            this.groupBox6.Controls.Add(this.pizzaSize);
            this.groupBox6.Controls.Add(this.sides);
            this.groupBox6.Controls.Add(this.Toppings);
            this.groupBox6.Controls.Add(this.cheese);
            this.groupBox6.Location = new System.Drawing.Point(619, 250);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(299, 153);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            // 
            // sauce
            // 
            this.sauce.AutoSize = true;
            this.sauce.Location = new System.Drawing.Point(17, 105);
            this.sauce.Name = "sauce";
            this.sauce.Size = new System.Drawing.Size(41, 13);
            this.sauce.TabIndex = 28;
            this.sauce.Text = "Sauce:";
            // 
            // orderSummary
            // 
            this.orderSummary.Location = new System.Drawing.Point(437, 396);
            this.orderSummary.Name = "orderSummary";
            this.orderSummary.Size = new System.Drawing.Size(75, 23);
            this.orderSummary.TabIndex = 29;
            this.orderSummary.Text = "Finalize";
            this.orderSummary.UseVisualStyleBackColor = true;
            this.orderSummary.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(45, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Pizza Size";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Orange;
            this.label8.Location = new System.Drawing.Point(307, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Toppings";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Orange;
            this.label9.Location = new System.Drawing.Point(645, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Cheese and Sauce";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Orange;
            this.label10.Location = new System.Drawing.Point(42, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Sides";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Orange;
            this.label11.Location = new System.Drawing.Point(306, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "Order Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Orange;
            this.label12.Location = new System.Drawing.Point(616, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 16);
            this.label12.TabIndex = 34;
            this.label12.Text = "Order";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.orderSummary);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "My Pizza Place";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.RadioButton smallRadio;
        private System.Windows.Forms.RadioButton mediumRadio;
        private System.Windows.Forms.RadioButton largeRadio;
        private System.Windows.Forms.RadioButton XLRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Breadsticks;
        private System.Windows.Forms.CheckBox wings;
        private System.Windows.Forms.CheckBox salad;
        private System.Windows.Forms.CheckBox pasta;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox pepCheck;
        private System.Windows.Forms.CheckBox mushrooms;
        private System.Windows.Forms.CheckBox onions;
        private System.Windows.Forms.CheckBox sausage;
        private System.Windows.Forms.CheckBox bacon;
        private System.Windows.Forms.CheckBox olive;
        private System.Windows.Forms.CheckBox peppers;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label pizzaSize;
        private System.Windows.Forms.Label Toppings;
        private System.Windows.Forms.Label cheese;
        private System.Windows.Forms.Label sides;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button orderSummary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label sauce;
    }
}

