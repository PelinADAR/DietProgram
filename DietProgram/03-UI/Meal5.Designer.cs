namespace _03_UI
{
    partial class Meal5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meal5));
            this.grpMyMeal = new System.Windows.Forms.GroupBox();
            this.lvwFoodsOfMeal = new System.Windows.Forms.ListView();
            this.foodName = new System.Windows.Forms.ColumnHeader();
            this.calory = new System.Windows.Forms.ColumnHeader();
            this.quantity = new System.Windows.Forms.ColumnHeader();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblTotalCal = new System.Windows.Forms.Label();
            this.txtUpdateAmount = new System.Windows.Forms.TextBox();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblCaloryValue = new System.Windows.Forms.Label();
            this.lblTotalCalory = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.flpFood = new System.Windows.Forms.FlowLayoutPanel();
            this.grpMyMeal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMyMeal
            // 
            this.grpMyMeal.BackColor = System.Drawing.Color.LemonChiffon;
            this.grpMyMeal.Controls.Add(this.lvwFoodsOfMeal);
            this.grpMyMeal.Controls.Add(this.btnDelete);
            this.grpMyMeal.Controls.Add(this.btnUpdate);
            this.grpMyMeal.Controls.Add(this.lblTotalCal);
            this.grpMyMeal.Controls.Add(this.txtUpdateAmount);
            this.grpMyMeal.Controls.Add(this.lblUpdate);
            this.grpMyMeal.Controls.Add(this.lblCaloryValue);
            this.grpMyMeal.Controls.Add(this.lblTotalCalory);
            this.grpMyMeal.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpMyMeal.Location = new System.Drawing.Point(8, 338);
            this.grpMyMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMyMeal.Name = "grpMyMeal";
            this.grpMyMeal.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMyMeal.Size = new System.Drawing.Size(464, 320);
            this.grpMyMeal.TabIndex = 0;
            this.grpMyMeal.TabStop = false;
            this.grpMyMeal.Text = "My Meal";
            // 
            // lvwFoodsOfMeal
            // 
            this.lvwFoodsOfMeal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvwFoodsOfMeal.BackgroundImage")));
            this.lvwFoodsOfMeal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.foodName,
            this.calory,
            this.quantity});
            this.lvwFoodsOfMeal.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lvwFoodsOfMeal.Location = new System.Drawing.Point(6, 21);
            this.lvwFoodsOfMeal.Name = "lvwFoodsOfMeal";
            this.lvwFoodsOfMeal.Size = new System.Drawing.Size(452, 207);
            this.lvwFoodsOfMeal.TabIndex = 12;
            this.lvwFoodsOfMeal.UseCompatibleStateImageBehavior = false;
            this.lvwFoodsOfMeal.View = System.Windows.Forms.View.Details;
            this.lvwFoodsOfMeal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvwFoodsOfMeal_MouseClick);
            // 
            // foodName
            // 
            this.foodName.Text = "Food Name";
            this.foodName.Width = 150;
            // 
            // calory
            // 
            this.calory.Text = "Total Calory";
            this.calory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.calory.Width = 150;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantity.Width = 145;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.LemonChiffon;
            this.btnDelete.FlatAppearance.BorderSize = 5;
            this.btnDelete.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnDelete.Location = new System.Drawing.Point(324, 234);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 39);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.LemonChiffon;
            this.btnUpdate.FlatAppearance.BorderSize = 5;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnUpdate.Location = new System.Drawing.Point(324, 277);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 39);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTotalCal
            // 
            this.lblTotalCal.AutoSize = true;
            this.lblTotalCal.Location = new System.Drawing.Point(173, 243);
            this.lblTotalCal.Name = "lblTotalCal";
            this.lblTotalCal.Size = new System.Drawing.Size(0, 21);
            this.lblTotalCal.TabIndex = 11;
            // 
            // txtUpdateAmount
            // 
            this.txtUpdateAmount.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtUpdateAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpdateAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUpdateAmount.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtUpdateAmount.Location = new System.Drawing.Point(171, 275);
            this.txtUpdateAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUpdateAmount.Multiline = true;
            this.txtUpdateAmount.Name = "txtUpdateAmount";
            this.txtUpdateAmount.Size = new System.Drawing.Size(89, 33);
            this.txtUpdateAmount.TabIndex = 10;
            this.txtUpdateAmount.Text = "0";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUpdate.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUpdate.Location = new System.Drawing.Point(30, 277);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(136, 21);
            this.lblUpdate.TabIndex = 9;
            this.lblUpdate.Text = "Update Amount:";
            this.lblUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCaloryValue
            // 
            this.lblCaloryValue.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCaloryValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCaloryValue.Location = new System.Drawing.Point(171, 235);
            this.lblCaloryValue.Name = "lblCaloryValue";
            this.lblCaloryValue.Size = new System.Drawing.Size(88, 34);
            this.lblCaloryValue.TabIndex = 9;
            this.lblCaloryValue.Text = "0 kcal";
            this.lblCaloryValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCalory
            // 
            this.lblTotalCalory.AutoSize = true;
            this.lblTotalCalory.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCalory.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotalCalory.Location = new System.Drawing.Point(30, 238);
            this.lblTotalCalory.Name = "lblTotalCalory";
            this.lblTotalCalory.Size = new System.Drawing.Size(115, 28);
            this.lblTotalCalory.TabIndex = 9;
            this.lblTotalCalory.Text = "Total Calory:";
            this.lblTotalCalory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtSearch.Location = new System.Drawing.Point(95, 74);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(377, 33);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.BackColor = System.Drawing.Color.Transparent;
            this.lblFoodName.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFoodName.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblFoodName.Location = new System.Drawing.Point(8, 74);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(70, 28);
            this.lblFoodName.TabIndex = 11;
            this.lblFoodName.Text = "Search:";
            // 
            // flpFood
            // 
            this.flpFood.BackColor = System.Drawing.Color.LemonChiffon;
            this.flpFood.Location = new System.Drawing.Point(8, 112);
            this.flpFood.Name = "flpFood";
            this.flpFood.Size = new System.Drawing.Size(464, 221);
            this.flpFood.TabIndex = 12;
            // 
            // Meal5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 669);
            this.Controls.Add(this.flpFood);
            this.Controls.Add(this.lblFoodName);
            this.Controls.Add(this.grpMyMeal);
            this.Controls.Add(this.txtSearch);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Meal5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meal5";
            this.Load += new System.EventHandler(this.Meal5_Load);
            this.grpMyMeal.ResumeLayout(false);
            this.grpMyMeal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpMyMeal;
        private Label lblTotalCal;
        private TextBox txtUpdateAmount;
        private Label lblUpdate;
        private Label lblCaloryValue;
        private Label lblTotalCalory;
        private Button btnUpdate;
        private Button btnDelete;
        private ListView lvwFoodsOfMeal;
        private TextBox txtSearch;
        private Label lblFoodName;
        private FlowLayoutPanel flpFood;
        private ColumnHeader foodName;
        private ColumnHeader calory;
        private ColumnHeader quantity;
    }
}