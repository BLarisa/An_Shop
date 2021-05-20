
namespace WindowsFormsApp1
{
    partial class UserForm
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
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.buttonExitSystem = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.currencyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(189, 63);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowHeadersWidth = 51;
            this.dataGridViewItems.RowTemplate.Height = 24;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(600, 432);
            this.dataGridViewItems.TabIndex = 0;
            this.dataGridViewItems.SelectionChanged += new System.EventHandler(this.dataGridViewItems_SelectionChanged);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(5, 63);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(178, 45);
            this.buttonAddItem.TabIndex = 1;
            this.buttonAddItem.Text = "Добавить товар";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.Location = new System.Drawing.Point(5, 114);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(178, 45);
            this.buttonDeleteItem.TabIndex = 2;
            this.buttonDeleteItem.Text = "Удалить товар";
            this.buttonDeleteItem.UseVisualStyleBackColor = true;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            // 
            // buttonExitSystem
            // 
            this.buttonExitSystem.Location = new System.Drawing.Point(5, 450);
            this.buttonExitSystem.Name = "buttonExitSystem";
            this.buttonExitSystem.Size = new System.Drawing.Size(178, 45);
            this.buttonExitSystem.TabIndex = 4;
            this.buttonExitSystem.Text = "Выйти из системы";
            this.buttonExitSystem.UseVisualStyleBackColor = true;
            this.buttonExitSystem.Click += new System.EventHandler(this.buttonExitSystem_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(12, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(46, 17);
            this.labelUser.TabIndex = 5;
            this.labelUser.Text = "label1";
            // 
            // currencyBtn
            // 
            this.currencyBtn.Location = new System.Drawing.Point(683, 9);
            this.currencyBtn.Name = "currencyBtn";
            this.currencyBtn.Size = new System.Drawing.Size(106, 34);
            this.currencyBtn.TabIndex = 6;
            this.currencyBtn.Text = "Курс валют";
            this.currencyBtn.UseVisualStyleBackColor = true;
            this.currencyBtn.Click += new System.EventHandler(this.currencyBtn_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 507);
            this.Controls.Add(this.currencyBtn);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.buttonExitSystem);
            this.Controls.Add(this.buttonDeleteItem);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.dataGridViewItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserForm";
            this.Text = "Пользователь";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.Button buttonExitSystem;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button currencyBtn;
    }
}